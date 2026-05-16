using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_projekat_1
{
    class Korisnik
    {
        private int id_korisnika;
        private string ime;
        private string prezime;
        private string korisnicko_ime;
        private string lozinka;
        private string vrsta_korisnika;

        public int Id_korisnika { get => id_korisnika; set => id_korisnika = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Korisnicko_ime { get => korisnicko_ime; set => korisnicko_ime = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Vrsta_korisnika { get => vrsta_korisnika; set => vrsta_korisnika = value; }

        public Korisnik() { }

        public Korisnik(int id_korisnika, string ime, string prezime, string korisnicko_ime, string lozinka, string vrsta_korisnika)
        {
            this.id_korisnika = id_korisnika;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnicko_ime = korisnicko_ime;
            this.lozinka = lozinka;
            this.vrsta_korisnika = vrsta_korisnika;
        }
    }
}
