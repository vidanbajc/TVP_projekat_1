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
    }
}
