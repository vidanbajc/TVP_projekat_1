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

        public IznajmljivanjeIgrica PrikazIznajmljivanja(Izdavanje iz)
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
                .Where(iz => 
                    iz.Id_korisnika == korisnik.Id_korisnika && 
                    iz.Status_izdavanja == "aktivno")
                .Select(PrikazIznajmljivanja).ToList();
        }

        public List<IznajmljivanjeIgrica> UcitajVracene()
        {
            return Podaci.Izdavanja
                .Where(iz =>
                    iz.Id_korisnika == korisnik.Id_korisnika && 
                    iz.Status_izdavanja == "vraceno")
                .Select(PrikazIznajmljivanja).ToList();
        }

        public void PopuniComboBox()
        {
            List<string> zanrovi = null;
            zanrovi = Podaci.Igrice.Select(i => i.Zanr).Distinct().ToList();

            cb_zanr.Items.AddRange(zanrovi.ToArray());
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

            PopuniComboBox();
        }

        private void Klijent_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Show();
        }

        private void btn_izmeni_izdavanje_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati iznajmljivanje koje zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (dtp_datum_vracanja.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Morate uneti validan datum vracanja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow red = dataGridView1.CurrentRow;

            int.TryParse(red.Cells[0].Value.ToString(), out int id_korisnika);
            int.TryParse(red.Cells[1].Value.ToString(), out int id_igrice);
            DateTime.TryParse(red.Cells[8].Value?.ToString(), out DateTime datum_iznajmljivanja);
            DateTime.TryParse(red.Cells[9].Value?.ToString(), out DateTime datum_vracanja);

            if(datum_iznajmljivanja.Date > datum_vracanja.Date)
            {
                MessageBox.Show("Morate uneti validan datum vracanja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (dtp_datum_vracanja.Value.Date == datum_vracanja.Date)
            {
                MessageBox.Show("Niste promenili datum vracanja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            Izdavanje izdavanje = Podaci.Izdavanja
                .FirstOrDefault(i => 
                    i.Id_korisnika == id_korisnika && 
                    i.Id_igrice == id_igrice &&
                    i.Status_izdavanja == "aktivno");

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
            p.OcistiKontrole(this);
            p.OcistiPanel(detalji1);
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

            if (!string.IsNullOrWhiteSpace(tb_naziv_igrice_pretrazi.Text))
            {
                string naziv = tb_naziv_igrice_pretrazi.Text;
                iznajmljivanje_igrica = iznajmljivanje_igrica.Where(i => i.Naziv_igrice == naziv).ToList();
            }

            if(checkBox1.Checked)
            {
                DateTime datum_iznajmljivanja = dtp_datum_iznajmljivanja_filtriraj.Value.Date;
                DateTime datum_vracanja = dtp_datum_vracanja_filtriraj.Value.Date;

                if (datum_iznajmljivanja > datum_vracanja)
                {
                    MessageBox.Show("Pretraga nije moguca, unesite validne datume!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                iznajmljivanje_igrica = iznajmljivanje_igrica
                    .Where(i => i.Datum_izdavanja >= datum_iznajmljivanja &&
                                i.Datum_vracanja <= datum_vracanja).ToList();
            }

            dataGridView2.DataSource = null;
            dataGridView2.SelectionChanged -= dataGridView2_SelectionChanged;
            dataGridView2.DataSource = iznajmljivanje_igrica;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

            if (iznajmljivanje_igrica.Count == 0)
                p.OcistiPanel(detalji2);
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

        private void btn_filtriraj_igrice_Click(object sender, EventArgs e)
        {
            List<Igrica> igrice = Podaci.Igrice;

            if (!string.IsNullOrWhiteSpace(tb_naziv_igrice_filtriraj.Text))
                igrice = igrice.Where(i => i.Naziv_igrice == tb_naziv_igrice_filtriraj.Text).ToList();

            if (!string.IsNullOrWhiteSpace(cb_zanr.Text))
                igrice = igrice.Where(i => i.Zanr == cb_zanr.Text).ToList();

            if (int.TryParse(tb_godina_izdavanja_filtriraj.Text, out int godina))
                igrice = igrice.Where(i => i.Godina_izdavanja == godina).ToList();

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = igrice;
        }
        private void btn_dodaj_izdavanje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_naziv_igrice.Text) ||
                string.IsNullOrWhiteSpace(tb_naziv_studija.Text) ||
                string.IsNullOrWhiteSpace(tb_zanr.Text) ||
                string.IsNullOrWhiteSpace(tb_godina_izdavanja.Text) ||
                string.IsNullOrWhiteSpace(tb_platforma.Text) ||
                nud_broj_dana.Value == 0)
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if(!int.TryParse(tb_godina_izdavanja.Text, out int godina_izdavanja))
            {
                MessageBox.Show("Morate uneti validnu godinu izdavanja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            List<IznajmljivanjeIgrica> iznajmljivanje = UcitajAktivne();

            DateTime datum_iznajmljivanja = dtp_datum_iznajmljivanja.Value;
            int.TryParse(nud_broj_dana.Value.ToString(), out int broj_dana);
            DateTime datum_vracanja = datum_iznajmljivanja.Date.AddDays(broj_dana);

            if(datum_iznajmljivanja.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Morate uneti validan datum pocetka iznajmljivanja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            Igrica igrica = Podaci.Igrice
                .FirstOrDefault(i => 
                    i.Naziv_igrice == tb_naziv_igrice.Text &&
                    i.Naziv_studija == tb_naziv_studija.Text &&
                    i.Zanr == tb_zanr.Text &&
                    i.Godina_izdavanja == godina_izdavanja &&
                    i.Platforma == tb_platforma.Text);

            if (igrica == null)
            {
                MessageBox.Show("Igrica nije pronadjena!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if(iznajmljivanje.Any(i => i.Id_igrice == igrica.Id_igrice))
            {
                MessageBox.Show("Vec ste iznajmili ovu igricu!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            Podaci.Izdavanja.Add(new Izdavanje(
                korisnik.Id_korisnika,
                igrica.Id_igrice,
                datum_iznajmljivanja,
                datum_vracanja,
                igrica.Cena_izdavanja * broj_dana,
                "aktivno"
            ));

            // mnogo je malo da imamo samo statuse aktivno i vraceno
            // zadatak zahteva da klijent moze da bira datum pocetka iznajmljivanja
            // kada bi smo imali dodatan status zakazano/rezervisano bilo bi lakse

            // iako je aktivna, moralo bi da se proveri da li je moguce iznajmiti igricu
            // na primer imamo samo 1 dostupan primerak
            // imamo jedno aktivno izdavanje (rezervisan) i neko hoce isto da iznajmi igricu
            // datumi ne smeju da se preklapaju (prvi 24. - 28., a drugi 22. - 25. )
            // isto i u Admin formi

            if (datum_iznajmljivanja.Date == DateTime.Now.Date)
                igrica.Broj_dostupnih_primeraka--;

            Podaci.Sacuvaj();
            p.OcistiKontrole(this);

            MessageBox.Show("Uspenso ste iznajmili novu igricu!", "Upozorenje", MessageBoxButtons.OK);

            tabControl1.SelectedTab = Aktivna_izdavanja;
        }

        private void Aktivna_izdavanja_Enter(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UcitajAktivne();
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView3.CurrentRow;

                tb_naziv_igrice.Text = red.Cells[0].Value?.ToString() ?? "";
                tb_naziv_studija.Text = red.Cells[1].Value?.ToString() ?? "";
                tb_zanr.Text = red.Cells[2].Value?.ToString() ?? "";
                tb_godina_izdavanja.Text = red.Cells[3].Value?.ToString() ?? "";
                tb_platforma.Text = red.Cells[4].Value?.ToString() ?? "";
            }
        }
    }
}
