using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TVP_projekat_1
{
    class Podaci
    {
        private static List<Korisnik> korisnici = new List<Korisnik>();
        private static List<Igrica> igrice = new List<Igrica>();
        private static List<Izdavanje> izdavanja = new List<Izdavanje>();

        internal static List<Korisnik> Korisnici { get => korisnici; set => korisnici = value; }
        internal static List<Igrica> Igrice { get => igrice; set => igrice = value; }
        internal static List<Izdavanje> Izdavanja { get => izdavanja; set => izdavanja = value; }

        public static void Sacuvaj()
        {
            XmlSerializer s1 = new XmlSerializer(typeof(List<Korisnik>));
            FileStream fs1 = new FileStream("korisnici.xml", FileMode.Create);
            s1.Serialize(fs1, korisnici);
            fs1.Close();

            XmlSerializer s2 = new XmlSerializer(typeof(List<Igrica>));
            FileStream fs2 = new FileStream("igrice.xml", FileMode.Create);
            s2.Serialize(fs2, igrice);
            fs2.Close();

            XmlSerializer s3 = new XmlSerializer(typeof(List<Izdavanje>));
            FileStream fs3 = new FileStream("izdavanja.xml", FileMode.Create);
            s3.Serialize(fs3, izdavanja);
            fs3.Close();
        }

        public static void Ucitaj()
        {
            if(File.Exists("korisnici.xml"))
            {
                XmlSerializer s1 = new XmlSerializer(typeof(List<Korisnik>));
                FileStream fs1 = new FileStream("korisnici.xml", FileMode.Open);
                korisnici = (List<Korisnik>)s1.Deserialize(fs1);
                fs1.Close();
            }

            if (File.Exists("igrice.xml"))
            {
                XmlSerializer s2 = new XmlSerializer(typeof(List<Igrica>));
                FileStream fs2 = new FileStream("igrice.xml", FileMode.Open);
                igrice = (List<Igrica>)s2.Deserialize(fs2);
                fs2.Close();
            }

            if (File.Exists("izdavanja.xml"))
            {
                XmlSerializer s3 = new XmlSerializer(typeof(List<Izdavanje>));
                FileStream fs3 = new FileStream("izdavanja.xml", FileMode.Open);
                izdavanja = (List<Izdavanje>)s3.Deserialize(fs3);
                fs3.Close();
            }
        }

        public static void Inicijalizuj()
        {
            if (File.Exists("korisnici.xml") && File.Exists("igrice.xml") && File.Exists("izdavanja.xml"))
                return;

            if(!File.Exists("korisnici.xml"))
            {
                korisnici.Add(new Korisnik(1, "a", "a", "a", "a", "admin"));
                korisnici.Add(new Korisnik(2, "Ognjen", "Colovic", "cj", "sifra", "klijent"));
                korisnici.Add(new Korisnik(3, "Nemanja", "Marinkovic", "sj", "sifra", "klijent"));
                korisnici.Add(new Korisnik(4, "b", "b", "b", "b", "klijent"));
            }

            if(!File.Exists("igrice.xml"))
            {
                igrice.Add(new Igrica(1, "League of Legends", "Riot", "moba", 2011, "aa", "aaaaaa", 2000, 5, 13));
                igrice.Add(new Igrica(2, "Counter Strike 2", "Valve", "moba", 2025, "aa", "aaaaaa", 2500, 10, 13));
                igrice.Add(new Igrica(3, "Rainbow", "aa", "aa", 2011, "aa", "aaaaaa", 3000, 5, 14));
            }

            if(!File.Exists("izdavanja.xml"))
            {
                izdavanja.Add(new Izdavanje(1, 1, new DateTime(2026,5,16), new DateTime(2026, 5, 26), 4000, "aktivno"));
            }
        }

        public static int id_novog_korisnika()
        {
            if (korisnici.Count == 0)
                return 1;

            int max = korisnici.Max(k => k.Id_korisnika) + 1;

            return max;
        }

        public static int id_nove_igrice()
        {
            if (igrice.Count == 0)
                return 1;

            int max = igrice.Max(i => i.Id_igrice) + 1;

            return max;
        }
    }
}
