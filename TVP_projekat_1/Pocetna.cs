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

        public void OcistiKontrole(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Parent is Form && c is TextBox tb)
                    tb.Clear();

                else if (c.Parent is Form && c is DateTimePicker dtp)
                    dtp.ResetText();

                if (c.HasChildren)
                    OcistiKontrole(c);
            }
        }

        public void OcistiPanel(Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if (c is Label lbl && lbl.Name.StartsWith("lbl_"))
                    lbl.ResetText();
            }
        }

        private void btn_prijava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_korisnicko_ime.Text) || string.IsNullOrWhiteSpace(tb_lozinka.Text))
            {
                MessageBox.Show("Morate popuniti sva neophodna polja!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            string korisnicko_ime = tb_korisnicko_ime.Text;
            string lozinka = tb_lozinka.Text;

            Korisnik korisnik = Podaci.Korisnici
                .FirstOrDefault(k => k.Korisnicko_ime == korisnicko_ime && 
                                     k.Lozinka == lozinka);

            if (korisnik == null)
            {
                MessageBox.Show("Uneli ste nepostojeceg korisnika, pokusajte ponovo!", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (korisnik.Vrsta_korisnika == "admin")
            {
                MessageBox.Show($"Uspesno ste se ulogovali kao {korisnik.Vrsta_korisnika} {korisnicko_ime}!", "Dobrodosli", MessageBoxButtons.OK);

                Administrator admin = new Administrator(this, korisnik);
                admin.Show();
            }

            else
            {
                MessageBox.Show($"Uspesno ste se ulogovali kao {korisnik.Vrsta_korisnika} {korisnicko_ime}!", "Dobrodosli", MessageBoxButtons.OK);

                Klijent klijent = new Klijent(this, korisnik);
                klijent.Show();
            }

            OcistiKontrole(this);
            this.Hide();
        }

        private void btn_izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
