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
            Igrica igrica = Podaci.Igrice
                .FirstOrDefault(ig => ig.Id_igrice == iz.Id_igrice);

            return new IznajmljivanjeIgrica(
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
    }
}
