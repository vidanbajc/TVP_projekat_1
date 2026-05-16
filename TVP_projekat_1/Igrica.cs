using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_projekat_1
{
    class Igrica
    {
        private int id_igrice;
        private string naziv_igrice;
        private string naziv_studija;
        private string zanr;
        private int godina_izdavanja;
        private string platforma;
        private string opis;
        private double cena_izdavanja;
        private int broj_dostupnih_primeraka;
        private int starosna_granica;

        public int Id_igrice { get => id_igrice; set => id_igrice = value; }
        public string Naziv_igrice { get => naziv_igrice; set => naziv_igrice = value; }
        public string Naziv_studija { get => naziv_studija; set => naziv_studija = value; }
        public string Zanr { get => zanr; set => zanr = value; }
        public int Godina_izdavanja { get => godina_izdavanja; set => godina_izdavanja = value; }
        public string Platforma { get => platforma; set => platforma = value; }
        public string Opis { get => opis; set => opis = value; }
        public double Cena_izdavanja { get => cena_izdavanja; set => cena_izdavanja = value; }
        public int Broj_dostupnih_primeraka { get => broj_dostupnih_primeraka; set => broj_dostupnih_primeraka = value; }
        public int Starosna_granica { get => starosna_granica; set => starosna_granica = value; }

        public Igrica() { }

        public Igrica(int id_igrice, string naziv_igrice, string naziv_studija, string zanr, int godina_izdavanja, string platforma, string opis, double cena_izdavanja, int broj_dostupnih_primeraka, int starosna_granica)
        {
            this.id_igrice = id_igrice;
            this.naziv_igrice = naziv_igrice;
            this.naziv_studija = naziv_studija;
            this.zanr = zanr;
            this.godina_izdavanja = godina_izdavanja;
            this.platforma = platforma;
            this.opis = opis;
            this.cena_izdavanja = cena_izdavanja;
            this.broj_dostupnih_primeraka = broj_dostupnih_primeraka;
            this.starosna_granica = starosna_granica;
        }
    }
}
