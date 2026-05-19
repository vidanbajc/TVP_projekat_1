using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_projekat_1
{
    public partial class Klijent : Form
    {
        public Pocetna p;
        private Korisnik korisnik;
        public Klijent(Pocetna p, Korisnik korisnik)
        {
            InitializeComponent();
            this.p = p;
            this.korisnik = korisnik;
        }

        public IznajmljivanjeIgrica pretvori_u_iznajmljivanje_igrica(Izdavanje iz)
        {
            Igrica igrica = Podaci.Igrice.FirstOrDefault(ig => ig.Id_igrice == iz.Id_igrice);

            if (igrica == null)
                return null;

            return new IznajmljivanjeIgrica(
                iz.Id_korisnika,
                igrica.Id_igrice,
                igrica.Naziv_igrice,
                igrica.Naziv_studija,
                igrica.Zanr,
                igrica.Godina_izdavanja,
                igrica.Platforma,
                igrica.Opis,
                iz.Datum_izdavanja,
                iz.Datum_vracanja,
                iz.Ukupna_cena,
                iz.Status_izdavanja
            );
        }

        public List<IznajmljivanjeIgrica> UcitajAktivne()
        {
            return Podaci.Izdavanja
                .Where(iz => iz.Id_korisnika == korisnik.Id_korisnika && iz.Status_izdavanja == "aktivno")
                .Select(pretvori_u_iznajmljivanje_igrica).ToList();
        }

        public List<IznajmljivanjeIgrica> UcitajVracene()
        {
            return Podaci.Izdavanja
                .Where(iz => iz.Id_korisnika == korisnik.Id_korisnika && iz.Status_izdavanja == "vraceno")
                .Select(pretvori_u_iznajmljivanje_igrica).ToList();
        }

        private void Klijent_Load(object sender, EventArgs e)
        {
            lbl_korisnik1.Text = $"Ulogovani ste kao {korisnik.Korisnicko_ime}";
            lbl_korisnik2.Text = $"Ulogovani ste kao {korisnik.Korisnicko_ime}";
            lbl_korisnik3.Text = $"Ulogovani ste kao {korisnik.Korisnicko_ime}";

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;

            dataGridView1.DataSource = UcitajAktivne();
            dataGridView2.DataSource = UcitajVracene();
            dataGridView3.DataSource = Podaci.Igrice;
        }

        // vezano za broj_dostupnih_primeraka, moram dodati i u adminu za status_izdavanja
        // dugme izmeni mora stalno da prebrojava ako je status_izdavanja -> vraceno
        // onda broj primeraka +1 ...

        private void Klijent_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Show();
        }

        private void btn_izmeni_izdavanje_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Morate selektovati iznajmljivanje koje zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);

            else if (dtp_datum_vracanja.Value.Date <= DateTime.Now.Date)
                MessageBox.Show("Morate uneti validan datum vracanja!", "Upozorenje", MessageBoxButtons.OK);

            else
            {
                DataGridViewRow red = dataGridView1.CurrentRow;
                int.TryParse(red.Cells[0].Value.ToString(), out int id_korisnika);
                int.TryParse(red.Cells[1].Value.ToString(), out int id_igrice);
                DateTime.TryParse(red.Cells[9].Value?.ToString(), out DateTime datum_vracanja);

                if (dtp_datum_vracanja.Value.Date == datum_vracanja.Date)
                {
                    MessageBox.Show("Niste promenili datum vracanja!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                Izdavanje izdavanje = Podaci.Izdavanja.FirstOrDefault(i => i.Id_korisnika == id_korisnika && i.Id_igrice == id_igrice);

                if (izdavanje == null)
                {
                    MessageBox.Show("Izdavanje nije pronadjeno!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                Igrica igrica = Podaci.Igrice.FirstOrDefault(i => i.Id_igrice == id_igrice);

                if (igrica == null)
                {
                    MessageBox.Show("Igrica nije pronadjena!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                int broj_dana = (dtp_datum_vracanja.Value.Date - izdavanje.Datum_izdavanja.Date).Days;

                izdavanje.Datum_vracanja = dtp_datum_vracanja.Value.Date;
                izdavanje.Ukupna_cena = broj_dana * igrica.Cena_izdavanja;

                Podaci.Sacuvaj();

                dataGridView1.DataSource = null;
                dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
                dataGridView1.DataSource = UcitajAktivne();
                dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

                MessageBox.Show("Uspesno ste promenili datum vracanja iznajmljivanja!", "Obavestenje", MessageBoxButtons.OK);
                p.Ocisti(this);
                p.Ocisti_panel(detalji1);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView1.CurrentRow;

                DateTime.TryParse(red.Cells[8].Value?.ToString(), out DateTime datum_izdavanja);
                DateTime.TryParse(red.Cells[9].Value?.ToString(), out DateTime datum_vracanja);

                dtp_datum_vracanja.Value = datum_vracanja.Date;

                lbl_naziv_igrice_a.Text = red.Cells[2].Value?.ToString() ?? "";
                lbl_naziv_studija_a.Text = red.Cells[3].Value?.ToString() ?? "";
                lbl_zanr_a.Text = red.Cells[4].Value?.ToString() ?? "";
                lbl_godina_izdavanja_a.Text = red.Cells[5].Value?.ToString() ?? "";
                lbl_platforma_a.Text = red.Cells[6].Value?.ToString() ?? "";
                lbl_opis_a.Text = red.Cells[7].Value?.ToString() ?? "";
                lbl_datum_izdavanja_a.Text = datum_izdavanja.ToString("dd.MM.yyyy HH:mm") ?? "";
                lbl_datum_vracanja_a.Text = datum_vracanja.ToString("dd.MM.yyyy") ?? "";
                lbl_ukupna_cena_a.Text = red.Cells[10].Value?.ToString() ?? "";
            }
        }

        private void btn_pretrazi_Click(object sender, EventArgs e)
        {
            List<IznajmljivanjeIgrica> iznajmljivanje_igrica = UcitajVracene();

            if(checkBox1.Checked && checkBox2.Checked)
            {
                if (string.IsNullOrEmpty(tb_naziv_igrice_filtriraj.Text))
                    MessageBox.Show("Pretraga nije moguca, morate popuniti polje za naziv igrice!", "Upozorenje", MessageBoxButtons.OK);

                else if (dtp_datum_iznajmljivanja_filtriraj.Value.Date > dtp_datum_vracanja_filtriraj.Value.Date)
                    MessageBox.Show("Pretraga nije moguca, unesite validne datume!", "Upozorenje", MessageBoxButtons.OK);

                else
                {
                    string naziv_igrice = tb_naziv_igrice_filtriraj.Text;
                    DateTime datum_iznajmljivanja = dtp_datum_iznajmljivanja_filtriraj.Value.Date;
                    DateTime datum_vracanja = dtp_datum_vracanja_filtriraj.Value.Date;

                    iznajmljivanje_igrica = iznajmljivanje_igrica
                        .Where(i => i.Naziv_igrice == naziv_igrice &&
                                    i.Datum_izdavanja >= datum_iznajmljivanja &&
                                    i.Datum_vracanja <= datum_vracanja).ToList();

                    dataGridView2.DataSource = null;
                    dataGridView2.SelectionChanged -= dataGridView2_SelectionChanged;
                    dataGridView2.DataSource = iznajmljivanje_igrica;
                    dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

                    if (iznajmljivanje_igrica.Count == 0)
                        p.Ocisti_panel(detalji2);
                }
            }

            else if (checkBox1.Checked)
            {
                if (string.IsNullOrEmpty(tb_naziv_igrice_filtriraj.Text))
                    MessageBox.Show("Pretraga nije moguca, morate popuniti polje za naziv igrice!", "Upozorenje", MessageBoxButtons.OK);

                else
                {
                    string naziv_igrice = tb_naziv_igrice_filtriraj.Text;

                    iznajmljivanje_igrica = iznajmljivanje_igrica
                        .Where(i => i.Naziv_igrice == naziv_igrice).ToList();

                    dataGridView2.DataSource = null;
                    dataGridView2.SelectionChanged -= dataGridView2_SelectionChanged;
                    dataGridView2.DataSource = iznajmljivanje_igrica;
                    dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

                    if (iznajmljivanje_igrica.Count == 0)
                        p.Ocisti_panel(detalji2);
                }
            }

            else if(checkBox2.Checked)
            {
                if (dtp_datum_iznajmljivanja_filtriraj.Value.Date > dtp_datum_vracanja_filtriraj.Value.Date)
                    MessageBox.Show("Pretraga nije moguca, unesite validne datume!", "Upozorenje", MessageBoxButtons.OK);

                else
                {
                    DateTime datum_iznajmljivanja = dtp_datum_iznajmljivanja_filtriraj.Value.Date;
                    DateTime datum_vracanja = dtp_datum_vracanja_filtriraj.Value.Date;

                    iznajmljivanje_igrica = iznajmljivanje_igrica
                        .Where(i => i.Datum_izdavanja >= datum_iznajmljivanja &&
                                    i.Datum_vracanja <= datum_vracanja).ToList();

                    dataGridView2.DataSource = null;
                    dataGridView2.SelectionChanged -= dataGridView2_SelectionChanged;
                    dataGridView2.DataSource = iznajmljivanje_igrica;
                    dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

                    if (iznajmljivanje_igrica.Count == 0)
                        p.Ocisti_panel(detalji2);
                }
            }

            else
            {
                dataGridView2.DataSource = null;
                dataGridView2.SelectionChanged -= dataGridView2_SelectionChanged;
                dataGridView2.DataSource = UcitajVracene();
                dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

                if (iznajmljivanje_igrica.Count == 0)
                    p.Ocisti_panel(detalji2);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView2.CurrentRow;

                DateTime.TryParse(red.Cells[8].Value?.ToString(), out DateTime datum_izdavanja);
                DateTime.TryParse(red.Cells[9].Value?.ToString(), out DateTime datum_vracanja);

                dtp_datum_iznajmljivanja.Value = datum_izdavanja.Date;
                dtp_datum_vracanja.Value = datum_vracanja.Date;

                lbl_naziv_igrice_v.Text = red.Cells[2].Value?.ToString() ?? "";
                lbl_naziv_studija_v.Text = red.Cells[3].Value?.ToString() ?? "";
                lbl_zanr_v.Text = red.Cells[4].Value?.ToString() ?? "";
                lbl_godina_izdavanja_v.Text = red.Cells[5].Value?.ToString() ?? "";
                lbl_platforma_v.Text = red.Cells[6].Value?.ToString() ?? "";
                lbl_opis_v.Text = red.Cells[7].Value?.ToString() ?? "";
                lbl_datum_izdavanja_v.Text = datum_izdavanja.ToString("dd.MM.yyyy HH:mm") ?? "";
                lbl_datum_vracanja_v.Text = datum_vracanja.ToString("dd.MM.yyyy") ?? "";
                lbl_ukupna_cena_v.Text = red.Cells[10].Value?.ToString() ?? "";
            }
        }

        private void btn_odjava1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
