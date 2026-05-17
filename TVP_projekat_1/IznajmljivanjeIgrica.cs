using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_projekat_1
{
    public class IznajmljivanjeIgrica
    {
        private string naziv_igrice;
        private string naziv_studija;
        private string zanr;
        private int godina_izdavanja;
        private string platforma;
        private string opis;
        private DateTime datum_izdavanja;
        private DateTime datum_vracanja;
        private double ukupna_cena;
        private string status_izdavanja;

        public string Naziv_igrice { get => naziv_igrice; set => naziv_igrice = value; }
        public string Naziv_studija { get => naziv_studija; set => naziv_studija = value; }
        public string Zanr { get => zanr; set => zanr = value; }
        public int Godina_izdavanja { get => godina_izdavanja; set => godina_izdavanja = value; }
        public string Platforma { get => platforma; set => platforma = value; }
        public string Opis { get => opis; set => opis = value; }
        public DateTime Datum_izdavanja { get => datum_izdavanja; set => datum_izdavanja = value; }
        public DateTime Datum_vracanja { get => datum_vracanja; set => datum_vracanja = value; }
        public double Ukupna_cena { get => ukupna_cena; set => ukupna_cena = value; }
        public string Status_izdavanja { get => status_izdavanja; set => status_izdavanja = value; }

        public IznajmljivanjeIgrica() { }

        public IznajmljivanjeIgrica(string naziv_igrice, string naziv_studija, string zanr, int godina_izdavanja, string platforma, string opis, DateTime datum_izdavanja, DateTime datum_vracanja, double ukupna_cena, string status_izdavanja)
        {
            this.naziv_igrice = naziv_igrice;
            this.naziv_studija = naziv_studija;
            this.zanr = zanr;
            this.godina_izdavanja = godina_izdavanja;
            this.platforma = platforma;
            this.opis = opis;
            this.datum_izdavanja = datum_izdavanja;
            this.datum_vracanja = datum_vracanja;
            this.ukupna_cena = ukupna_cena;
            this.status_izdavanja = status_izdavanja;
        }
    }
}
