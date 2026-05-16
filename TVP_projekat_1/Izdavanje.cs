using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_projekat_1
{
    class Izdavanje
    {
        private int id_korisnika;
        private int id_igrice;
        private DateTime datum_izdavanja;
        private DateTime datum_vracanja;
        private double ukupna_cena;
        private bool status_izdavanja;

        public int Id_korisnika { get => id_korisnika; set => id_korisnika = value; }
        public int Id_igrice { get => id_igrice; set => id_igrice = value; }
        public DateTime Datum_izdavanja { get => datum_izdavanja; set => datum_izdavanja = value; }
        public DateTime Datum_vracanja { get => datum_vracanja; set => datum_vracanja = value; }
        public double Ukupna_cena { get => ukupna_cena; set => ukupna_cena = value; }
        public bool Status_izdavanja { get => status_izdavanja; set => status_izdavanja = value; }

        public Izdavanje() { }
        public Izdavanje(int id_korisnika, int id_igrice, DateTime datum_izdavanja, DateTime datum_vracanja, double ukupna_cena, bool status_izdavanja)
        {
            this.id_korisnika = id_korisnika;
            this.id_igrice = id_igrice;
            this.datum_izdavanja = datum_izdavanja;
            this.datum_vracanja = datum_vracanja;
            this.ukupna_cena = ukupna_cena;
            this.status_izdavanja = status_izdavanja;
        }
    }
}
