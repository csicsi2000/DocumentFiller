using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_autósiskola
{
    class tanulo
    {
        public string Nev;
        public string SzuleteskoriNev;
        public string SzuletesiHely;
        public string SzuletesiIdo;
        public string Anyja;
        public string Lakcim;
        public string ErtesitesCim;
        public string TAzonosito;
        public string TKezdete;
        public string TanuloAzonositoja;
        public string TanuloIktatoszama;
        public string VezetesiKarton;
        public string ElsoElmelet;
        public string ElmeletTargy;
        public string ElsoElmeletVizsga;
        public string SikeresElmeletVizsga;
        public string SikertelenSzama;
        public string Korlatozasok;


        public tanulo(string Adatsor)
        {
            int count = 0;
            foreach (char c in Adatsor)
                if (c == ';') count++;

            if (count < 30)
            {
                StringBuilder sb = new StringBuilder(Adatsor);
                for (int i = count; i <= 30; i++)
                {
                    sb.Append(";");
                }
                Adatsor = Convert.ToString(sb);
            }

            string[] adatok = Adatsor.Split(';');

            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] == "x" || adatok[i] == null)
                {
                    adatok[i] = "-";
                }
                if (adatok[i].Contains(" 0:00:00"))
                {
                    adatok[i] = adatok[i].Replace(" 0:00:00", "");
                }
            }

            Nev = adatok[1];
            if (adatok[2] == "U.A." || adatok[2] == "U.A")
            {
                SzuleteskoriNev = adatok[1];
            }
            else
            {
                SzuleteskoriNev = adatok[2];
            }
            SzuletesiHely = adatok[3];
            SzuletesiIdo = adatok[4];
            Anyja = adatok[5];
            Lakcim = adatok[7];
            if (adatok[8] == "U.A." || adatok[8] == "U.A")
            {
                ErtesitesCim = adatok[7];
            }
            else
            {
                ErtesitesCim = adatok[8];
            }
            TanuloAzonositoja = adatok[16];
            if (TanuloAzonositoja.Length < 10)
            {
                TAzonosito = "0";
            }
            else
            {
                TAzonosito = adatok[16].Substring(0, 12);
            }
            TKezdete = adatok[14];
            TanuloIktatoszama = adatok[17];
            VezetesiKarton = adatok[20];
            ElsoElmelet = adatok[14];
            ElmeletTargy = adatok[15];
            ElsoElmeletVizsga = adatok[18];
            SikeresElmeletVizsga = adatok[19];
            SikertelenSzama = adatok[30];
            Korlatozasok = adatok[11];

        }
    }
}