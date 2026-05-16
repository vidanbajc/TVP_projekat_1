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
    public partial class Administrator : Form
    {
        public Pocetna p;
        private Korisnik korisnik;
        public Administrator(Pocetna p, Korisnik korisnik)
        {
            InitializeComponent();
            this.p = p;
            this.korisnik = korisnik;
        }

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Show();
        }

        public void Ocisti()
        {
            foreach (Control c in this.Controls)
            {
                if(c is TextBox tb)
                    tb.Clear();
            }

            dtp_datum_vracanja.ResetText();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            lbl_korisnik1.Text += $"kao admin {korisnik.Korisnicko_ime}";
            lbl_korisnik2.Text += $"kao admin {korisnik.Korisnicko_ime}";
            lbl_korisnik3.Text += $"kao admin {korisnik.Korisnicko_ime}";

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;

            dataGridView1.DataSource = Podaci.Korisnici;
            dataGridView2.DataSource = Podaci.Igrice;
            dataGridView3.DataSource = Podaci.Izdavanja;
        }

        private void btn_dodaj_korisnika_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ime.Text) ||
                string.IsNullOrWhiteSpace(tb_prezime.Text) ||
                string.IsNullOrWhiteSpace(tb_korisnicko_ime.Text) ||
                string.IsNullOrWhiteSpace(tb_lozinka.Text) ||
                string.IsNullOrWhiteSpace(tb_vrsta_korisnika.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if (tb_vrsta_korisnika.Text.ToLower() != "admin" && tb_vrsta_korisnika.Text.ToLower() != "klijent")
                MessageBox.Show("Morate uneti validnu vrstu korisnika!", "Upozorenje", MessageBoxButtons.OK);

            else
            {
                string korisnicko_ime = tb_korisnicko_ime.Text;

                if(Podaci.Korisnici.Any(k => k.Korisnicko_ime == korisnicko_ime.ToLower()))
                {
                    MessageBox.Show($"Korisnicko ime {korisnicko_ime.ToLower()} je zauzeto, pokusajte ponovo!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                int id = Podaci.id_novog_korisnika();

                Podaci.Korisnici.Add(new Korisnik(id, tb_ime.Text, tb_prezime.Text, tb_korisnicko_ime.Text.ToLower(), tb_lozinka.Text, tb_vrsta_korisnika.Text));
                Podaci.Sacuvaj();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Podaci.Korisnici;

                MessageBox.Show("Uspesno ste dodali novog korisnika!", "Obavestenje", MessageBoxButtons.OK);
                Ocisti();
            }
        }

        private void btn_dodaj_igricu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_naziv_igrice.Text) ||
               string.IsNullOrEmpty(tb_naziv_studija.Text) ||
               string.IsNullOrEmpty(tb_zanr.Text) ||
               string.IsNullOrEmpty(tb_godina_izdavanja.Text) ||
               string.IsNullOrEmpty(tb_platforma.Text) ||
               string.IsNullOrEmpty(tb_opis.Text) ||
               string.IsNullOrEmpty(tb_cena_izdavanja.Text) ||
               string.IsNullOrEmpty(tb_broj_dostupnih_primeraka.Text) ||
               string.IsNullOrEmpty(tb_starosna_granica.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if(int.TryParse(tb_godina_izdavanja.Text, out int godina_izdavanja) &&
                    double.TryParse(tb_cena_izdavanja.Text, out double cena_izdavanja) &&
                    int.TryParse(tb_broj_dostupnih_primeraka.Text, out int broj_dostupnih_primeraka) &&
                    int.TryParse(tb_starosna_granica.Text, out int starosna_granica))
            {
                if(godina_izdavanja < 1950 || cena_izdavanja < 0 || broj_dostupnih_primeraka < 1 || starosna_granica < 0)
                {
                    MessageBox.Show("Morate uneti validne vrednosti (godina, cena, broj dostupnih primeraka ili starosna granica)!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                if(Podaci.Igrice.Any(i => i.Naziv_igrice == tb_naziv_igrice.Text &&
                                     i.Naziv_studija == tb_naziv_studija.Text &&
                                     i.Zanr == tb_zanr.Text &&
                                     i.Godina_izdavanja == godina_izdavanja &&
                                     i.Platforma == tb_platforma.Text))
                {
                    MessageBox.Show("Igrica sa istim nazivom, studijom, zanrom, godinom izdavanja i platformom vec postoji!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                int id = Podaci.id_nove_igrice();

                Podaci.Igrice.Add(new Igrica(
                    id, 
                    tb_naziv_igrice.Text, 
                    tb_naziv_studija.Text, 
                    tb_zanr.Text, 
                    godina_izdavanja, 
                    tb_platforma.Text, 
                    tb_opis.Text, 
                    cena_izdavanja, 
                    broj_dostupnih_primeraka, 
                    starosna_granica
                ));
                Podaci.Sacuvaj();

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Podaci.Igrice;

                MessageBox.Show("Uspesno ste dodali novu igricu!", "Obavestenje", MessageBoxButtons.OK);
                Ocisti();
            }
            else
                MessageBox.Show("Morate ispravno popuniti polja (godina, cena, broj dostupnih primeraka ili starosna granica)!", "Upozorenje", MessageBoxButtons.OK);
        }
    }
}
