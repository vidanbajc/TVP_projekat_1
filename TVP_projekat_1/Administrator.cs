using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void Administrator_Load(object sender, EventArgs e)
        {
            lbl_korisnik1.Text = $"Ulogovani ste kao admin {korisnik.Korisnicko_ime}";
            lbl_korisnik2.Text = $"Ulogovani ste kao admin {korisnik.Korisnicko_ime}";
            lbl_korisnik3.Text = $"Ulogovani ste kao admin {korisnik.Korisnicko_ime}";

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

                Podaci.Korisnici.Add(new Korisnik(
                    id,
                    tb_ime.Text,
                    tb_prezime.Text,
                    tb_korisnicko_ime.Text.ToLower(),
                    tb_lozinka.Text,
                    tb_vrsta_korisnika.Text
                ));
                Podaci.Sacuvaj();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Podaci.Korisnici;

                MessageBox.Show("Uspesno ste dodali novog korisnika!", "Obavestenje", MessageBoxButtons.OK);
                Pocetna.Ocisti(this);
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
                Pocetna.Ocisti(this);
            }
            else
                MessageBox.Show("Morate ispravno popuniti polja (godina, cena, broj dostupnih primeraka ili starosna granica)!", "Upozorenje", MessageBoxButtons.OK);
        }

        private void btn_dodaj_izdavanje_Click(object sender, EventArgs e)
        {
            // videti po pitanju statusa da li uopste moze da se doda izdavanje,
            // a da status bude vraceno

            // isto oko izmene, ako neko ranije vrati nego sto je rezervisao,
            // da li mu se smanjuje cena i to
            // mada je to vec prica za Klijenta, ako se uopste zahteva
            if (string.IsNullOrEmpty(tb_id_korisnika_i.Text) ||
                string.IsNullOrEmpty(tb_id_igrice_i.Text) ||
                string.IsNullOrEmpty(tb_status_izdavanja.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if (tb_status_izdavanja.Text.ToLower() != "aktivno" && tb_status_izdavanja.Text.ToLower() != "vraceno")
                MessageBox.Show("Morate uneti validnu vrstu aktivnosti!", "Upozorenje", MessageBoxButtons.OK);

            else if(dtp_datum_vracanja.Value.Date < DateTime.Now.Date)
                MessageBox.Show("Morate uneti validan datum vracanja!", "Upozorenje", MessageBoxButtons.OK);

            else if (int.TryParse(tb_id_korisnika_i.Text, out int id_korisnika) &&
                     int.TryParse(tb_id_igrice_i.Text, out int id_igrice))
            {
                Korisnik korisnik = Podaci.Korisnici.FirstOrDefault(k => k.Id_korisnika == id_korisnika);
                Igrica igrica = Podaci.Igrice.FirstOrDefault(i => i.Id_igrice == id_igrice);

                if (korisnik == null || igrica == null)
                {
                    MessageBox.Show("Morate uneti id postojeceg korisnika i igrice!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                int broj_dana = (dtp_datum_vracanja.Value.Date - DateTime.Now.Date).Days;
                double ukupna_cena = broj_dana * igrica.Cena_izdavanja;

                Podaci.Izdavanja.Add(new Izdavanje(
                    id_korisnika,
                    id_igrice,
                    DateTime.Now,
                    dtp_datum_vracanja.Value.Date,
                    ukupna_cena,
                    tb_status_izdavanja.Text.ToLower()
                ));
                Podaci.Sacuvaj();

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = Podaci.Izdavanja;

                MessageBox.Show("Uspesno ste dodali novo izdavanje!", "Obavestenje", MessageBoxButtons.OK);
                Pocetna.Ocisti(this);
            }
            else
                MessageBox.Show("Morate ispravno popuniti polja (id korisnika, id igrice, ukupnu cenu)!", "Upozorenje", MessageBoxButtons.OK);
        }

        private void btn_izmeni_korisnika_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ime.Text) ||
                string.IsNullOrWhiteSpace(tb_prezime.Text) ||
                string.IsNullOrWhiteSpace(tb_korisnicko_ime.Text) ||
                string.IsNullOrWhiteSpace(tb_lozinka.Text) ||
                string.IsNullOrWhiteSpace(tb_vrsta_korisnika.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if(dataGridView1.CurrentRow == null || string.IsNullOrWhiteSpace(tb_id_korisnik.Text))
                MessageBox.Show("Morate selektovati korisnika koga zelite da izmenite", "Upozorenje", MessageBoxButtons.OK);

            else
            {
                DataGridViewRow red = dataGridView1.CurrentRow;
                int.TryParse(red.Cells[0].Value.ToString(), out int id);

                Korisnik korisnik = Podaci.Korisnici.FirstOrDefault(k => k.Id_korisnika == id);

                if(korisnik == null)
                {
                    MessageBox.Show("Korisnik nije pronadjen!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                if (tb_vrsta_korisnika.Text.ToLower() != "admin" && tb_vrsta_korisnika.Text.ToLower() != "klijent")
                {
                    MessageBox.Show("Morate uneti validnu vrstu korisnika!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                if (tb_id_korisnik.Text != id.ToString())
                {
                    MessageBox.Show("Zabranjeno je menjanje id!", "Upozorenje", MessageBoxButtons.OK);
                    tb_id_korisnik.Text = id.ToString();
                    return;
                }

                if (korisnik.Ime == tb_ime.Text &&
                    korisnik.Prezime == tb_prezime.Text &&
                    korisnik.Korisnicko_ime.ToLower() == tb_korisnicko_ime.Text.ToLower() &&
                    korisnik.Lozinka == tb_lozinka.Text &&
                    korisnik.Vrsta_korisnika == tb_vrsta_korisnika.Text.ToLower())
                {
                    MessageBox.Show("Niste izvrsili nikakvu izmenu!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                if (Podaci.Korisnici.Any(k => k.Korisnicko_ime == tb_korisnicko_ime.Text.ToLower()))
                {
                    MessageBox.Show($"Korisnicko ime {tb_korisnicko_ime.Text.ToLower()} je zauzeto, pokusajte ponovo!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                if(this.korisnik == korisnik)
                {
                    lbl_korisnik1.Text = $"Ulogovani ste kao admin {tb_korisnicko_ime.Text.ToLower()}";
                    lbl_korisnik2.Text = $"Ulogovani ste kao admin {tb_korisnicko_ime.Text.ToLower()}";
                    lbl_korisnik3.Text = $"Ulogovani ste kao admin {tb_korisnicko_ime.Text.ToLower()}";
                }

                korisnik.Ime = tb_ime.Text;
                korisnik.Prezime = tb_prezime.Text;
                korisnik.Korisnicko_ime = tb_korisnicko_ime.Text.ToLower();
                korisnik.Lozinka = tb_lozinka.Text;
                korisnik.Vrsta_korisnika = tb_vrsta_korisnika.Text.ToLower();

                Podaci.Sacuvaj();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Podaci.Korisnici;

                MessageBox.Show("Uspesno ste izmenili podatke o korisniku!", "Obavestenje", MessageBoxButtons.OK);
                Pocetna.Ocisti(this);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView1.CurrentRow;

                tb_id_korisnik.Text = red.Cells[0].Value.ToString();
                tb_ime.Text = red.Cells[1].Value.ToString();
                tb_prezime.Text = red.Cells[2].Value.ToString();
                tb_korisnicko_ime.Text = red.Cells[3].Value.ToString();
                tb_lozinka.Text = red.Cells[4].Value.ToString();
                tb_vrsta_korisnika.Text = red.Cells[5].Value.ToString();
            }
        }

        private void btn_izmeni_igricu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_naziv_igrice.Text) ||
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

            else if(dataGridView2.CurrentRow == null || string.IsNullOrWhiteSpace(tb_id_igrice.Text))
                MessageBox.Show("Morate selektovati igricu koju zelite da izmenite!", "Upozorenje", MessageBoxButtons.OK);
            
            else
            {
                DataGridViewRow red = dataGridView2.CurrentRow;
                int.TryParse(red.Cells[0].Value.ToString(), out int id);

                Igrica igrica = Podaci.Igrice.FirstOrDefault(i => i.Id_igrice == id);

                if(igrica == null)
                {
                    MessageBox.Show("Igrica nije pronadjena!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                if (tb_id_igrice.Text != id.ToString())
                {
                    MessageBox.Show("Zabranjeno je menjanje id!", "Upozorenje", MessageBoxButtons.OK);
                    tb_id_igrice.Text = id.ToString();
                    return;
                }

                if (Podaci.Izdavanja.Any(i => i.Id_igrice == id && i.Status_izdavanja == "aktivno"))
                {
                    MessageBox.Show("Nije moguce menjati igricu koja je iznajmljena!", "Upozorenje", MessageBoxButtons.OK);
                    Pocetna.Ocisti(this);
                    return;
                }

                if (int.TryParse(tb_godina_izdavanja.Text, out int godina_izdavanja) &&
                    double.TryParse(tb_cena_izdavanja.Text, out double cena_izdavanja) &&
                    int.TryParse(tb_broj_dostupnih_primeraka.Text, out int broj_dostupnih_primeraka) &&
                    int.TryParse(tb_starosna_granica.Text, out int starosna_granica))
                {
                    if (godina_izdavanja < 1950 || cena_izdavanja < 0 || broj_dostupnih_primeraka < 1 || starosna_granica < 0)
                    {
                        MessageBox.Show("Morate uneti validne vrednosti (godina, cena, broj dostupnih primeraka ili starosna granica)!", "Upozorenje", MessageBoxButtons.OK);
                        return;
                    }

                    if (igrica.Naziv_igrice == tb_naziv_igrice.Text &&
                        igrica.Naziv_studija == tb_naziv_studija.Text &&
                        igrica.Zanr == tb_zanr.Text &&
                        igrica.Godina_izdavanja == godina_izdavanja &&
                        igrica.Platforma == tb_platforma.Text &&
                        igrica.Opis == tb_opis.Text &&
                        igrica.Cena_izdavanja == cena_izdavanja &&
                        igrica.Broj_dostupnih_primeraka == broj_dostupnih_primeraka &&
                        igrica.Starosna_granica == starosna_granica)
                    {
                        MessageBox.Show("Niste izvrsili nikakvu izmenu!", "Upozorenje", MessageBoxButtons.OK);
                        return;
                    }

                    if (Podaci.Igrice.Any(i => i.Naziv_igrice == tb_naziv_igrice.Text &&
                                          i.Naziv_studija == tb_naziv_studija.Text &&
                                          i.Zanr == tb_zanr.Text &&
                                          i.Godina_izdavanja == godina_izdavanja &&
                                          i.Platforma == tb_platforma.Text &&
                                          i.Opis == tb_opis.Text &&
                                          i.Cena_izdavanja == cena_izdavanja &&
                                          i.Broj_dostupnih_primeraka == broj_dostupnih_primeraka &&
                                          i.Starosna_granica == starosna_granica))
                    {
                        MessageBox.Show("Igrica sa istim nazivom, studijom, zanrom, godinom izdavanja i platformom, cenom... vec postoji!", "Upozorenje", MessageBoxButtons.OK);
                        return;
                    }

                    igrica.Naziv_igrice = tb_naziv_igrice.Text;
                    igrica.Naziv_studija = tb_naziv_studija.Text;
                    igrica.Zanr = tb_zanr.Text;
                    igrica.Godina_izdavanja = godina_izdavanja;
                    igrica.Platforma = tb_platforma.Text;
                    igrica.Opis = tb_opis.Text;
                    igrica.Cena_izdavanja = cena_izdavanja;
                    igrica.Broj_dostupnih_primeraka = broj_dostupnih_primeraka;
                    igrica.Starosna_granica = starosna_granica;

                    Podaci.Sacuvaj();

                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = Podaci.Igrice;

                    MessageBox.Show("Uspesno ste izmenili podatke o igrici!", "Obavestenje", MessageBoxButtons.OK);
                    Pocetna.Ocisti(this);
                }
                else
                    MessageBox.Show("Niste uneli dobre podatke!", "Upozorenje", MessageBoxButtons.OK);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView2.CurrentRow;

                tb_id_igrice.Text = red.Cells[0].Value.ToString();
                tb_naziv_igrice.Text = red.Cells[1].Value.ToString();
                tb_naziv_studija.Text = red.Cells[2].Value.ToString();
                tb_zanr.Text = red.Cells[3].Value.ToString();
                tb_godina_izdavanja.Text = red.Cells[4].Value.ToString();
                tb_platforma.Text = red.Cells[5].Value.ToString();
                tb_opis.Text = red.Cells[6].Value.ToString();
                tb_cena_izdavanja.Text = red.Cells[7].Value.ToString();
                tb_broj_dostupnih_primeraka.Text = red.Cells[8].Value.ToString();
                tb_starosna_granica.Text = red.Cells[9].Value.ToString();
            }
        }

        private void btn_izmeni_izdavanje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_id_korisnika_i.Text) ||
                string.IsNullOrEmpty(tb_id_igrice_i.Text) ||
                string.IsNullOrEmpty(tb_status_izdavanja.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
            }

            else if (tb_status_izdavanja.Text.ToLower() != "aktivno" && tb_status_izdavanja.Text.ToLower() != "vraceno")
                MessageBox.Show("Morate uneti validnu vrstu aktivnosti!", "Upozorenje", MessageBoxButtons.OK);

            else if (dtp_datum_vracanja.Value.Date < DateTime.Now.Date)
                MessageBox.Show("Morate uneti validan datum vracanja!", "Upozorenje", MessageBoxButtons.OK);

            else
            {
                DataGridViewRow red = dataGridView3.CurrentRow;
                int.TryParse(red.Cells[0].Value.ToString(), out int id_korisnika);
                int.TryParse(red.Cells[1].Value.ToString(), out int id_igrice);

                Izdavanje izdavanje = Podaci.Izdavanja.FirstOrDefault(i => i.Id_korisnika == id_korisnika && i.Id_igrice == id_igrice);

                if (izdavanje == null)
                {
                    MessageBox.Show("Igrica nije pronadjena!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                if (tb_id_korisnika_i.Text != id_korisnika.ToString() || tb_id_igrice_i.Text != id_igrice.ToString())
                {
                    MessageBox.Show("Zabranjeno je menjanje id korisnika i igrice!", "Upozorenje", MessageBoxButtons.OK);
                    tb_id_korisnika_i.Text = id_korisnika.ToString();
                    tb_id_igrice_i.Text = id_igrice.ToString();
                    return;
                }

                if(izdavanje.Datum_vracanja.Date == dtp_datum_vracanja.Value.Date &&
                   izdavanje.Status_izdavanja == tb_status_izdavanja.Text.ToLower())
                {
                    MessageBox.Show("Niste izvrsili nikakvu izmenu!", "Upozorenje", MessageBoxButtons.OK);
                    return;
                }

                Igrica igrica = Podaci.Igrice.FirstOrDefault(i => i.Id_igrice == id_igrice);
                int broj_dana = (dtp_datum_vracanja.Value.Date - izdavanje.Datum_izdavanja.Date).Days;

                izdavanje.Datum_vracanja = dtp_datum_vracanja.Value.Date;
                izdavanje.Status_izdavanja = tb_status_izdavanja.Text.ToLower();
                izdavanje.Ukupna_cena = broj_dana * igrica.Cena_izdavanja;

                Podaci.Sacuvaj();

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = Podaci.Izdavanja;

                MessageBox.Show("Uspesno ste izmenili podatke o izdavanju!", "Obavestenje", MessageBoxButtons.OK);
                Pocetna.Ocisti(this);
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null)
            {
                DataGridViewRow red = dataGridView3.CurrentRow;

                tb_id_korisnika_i.Text = red.Cells[0].Value.ToString();
                tb_id_igrice_i.Text = red.Cells[1].Value.ToString();
                tb_ukupna_cena.Text = red.Cells[4].Value.ToString();
                tb_status_izdavanja.Text = red.Cells[5].Value.ToString();

                if (DateTime.TryParse(red.Cells[3].Value.ToString(), out DateTime datum))
                    dtp_datum_vracanja.Value = datum.Date;
            }
        }
    }
}
