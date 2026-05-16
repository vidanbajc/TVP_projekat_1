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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
            Podaci.Inicijalizuj();
            Podaci.Ucitaj();
        }

        private void btn_prijava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_korisnicko_ime.Text))
                MessageBox.Show("Morate uneti korisnicko ime", "Upozorenje", MessageBoxButtons.OK);

            else if (string.IsNullOrWhiteSpace(tb_lozinka.Text))
                MessageBox.Show("Morate uneti lozinku", "Upozorenje", MessageBoxButtons.OK);

            else
            {
                string korisnicko_ime = tb_korisnicko_ime.Text;
                string lozinka = tb_lozinka.Text;

                Korisnik nadjen = null;
                nadjen = Podaci.Korisnici.FirstOrDefault(k => k.Korisnicko_ime == korisnicko_ime && k.Lozinka == lozinka);

                if (nadjen == null)
                    MessageBox.Show("Uneli ste nepostojeceg korisnika, pokusajte ponovo", "Upozorenje", MessageBoxButtons.OK);

                else if(nadjen.Vrsta_korisnika == "admin")
                {
                    MessageBox.Show($"Uspesno ste se ulogovali kao {nadjen.Vrsta_korisnika} {korisnicko_ime}!", "Dobrodosli", MessageBoxButtons.OK);
                    Administrator admin = new Administrator(this, nadjen);
                    admin.Show();

                    tb_korisnicko_ime.Clear();
                    tb_lozinka.Clear();
                    this.Hide();
                }

                else if (nadjen.Vrsta_korisnika == "klijent")
                {
                    MessageBox.Show($"Uspesno ste se ulogovali kao {nadjen.Vrsta_korisnika} {korisnicko_ime}!", "Dobrodosli", MessageBoxButtons.OK);
                    Klijent klijent = new Klijent(this, nadjen);
                    klijent.Show();

                    tb_korisnicko_ime.Clear();
                    tb_lozinka.Clear();
                    this.Hide();
                }
            }
        }

        private void btn_izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
