using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WindowsFormsApp_autósiskola.Classes;

namespace WindowsFormsApp_autósiskola
{
    class Tanulo
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
        public string TVege;
        public string TanuloAzonositoja;
        public string TanuloIktatoszama;
        public string VezetesiKarton;
        public string ElsoElmelet;
        public string ElmeletTargy;
        public string ElsoElmeletVizsga;
        public string SikeresElmeletVizsga;
        public string SikertelenSzama;
        public string Korlatozasok;
        public string Kategoria;

        public string allampolgarsag;
        public string telefonszam;
        public string email;

        public Tanulo() { }
        public Tanulo(string Adatsor)
        {
            int index = Properties.Settings.Default.comboIndex;
            List<string> sablonok = new List<string>();
            StreamReader oszlopokOlvas = new StreamReader(DocumentAccess.OszlopRendezes, Encoding.UTF8);
            string fejlec = oszlopokOlvas.ReadLine();
            while (!oszlopokOlvas.EndOfStream)
            {
                sablonok.Add(oszlopokOlvas.ReadLine());
            }
            oszlopokOlvas.Close();
            //string[] sablonok = Properties.Settings.Default.tablaSync.Split('Ł');
            string[] szamString = sablonok[index].Split(';');
            int[] szamok = new int[szamString.Length];
            for (int i = 0; i < (szamString.Length - 1); i++)
            {
                szamok[i] = Convert.ToInt32(szamString[i]);
            }

            string[] adatok = Adatsor.Split(';');
            if (adatok.Length < 30)
            {
                StringBuilder sb = new StringBuilder(Adatsor);
                for (int i = 0; i <= 30; i++)
                {
                    sb.Append(";");
                }
                Adatsor = Convert.ToString(sb);
            }
            adatok = Adatsor.Split(';');

            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] == "0")
                {
                    adatok[i] = "\t";
                }
            }

            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] == "x" || adatok[i] == null || adatok[i] == "")
                {
                    adatok[i] = "-";
                }
                if (adatok[i].Contains(" 0:00:00"))
                {
                    adatok[i] = adatok[i].Replace(" 0:00:00", "");
                }
            }
            adatok[0] = "";



            Nev = adatok[szamok[0]];
            SzuleteskoriNev = Nev;
            SzuletesiHely = adatok[szamok[2]];
            SzuletesiIdo = adatok[szamok[3]];
            Anyja = adatok[szamok[4]];
            Lakcim = adatok[szamok[5]];
            if (adatok[szamok[6]] == "U.A." || adatok[szamok[6]] == "U.A" || adatok[szamok[6]] == "u.a." || adatok[szamok[6]] == "u.a.")
            {
                ErtesitesCim = adatok[szamok[5]];
            }
            else
            {
                ErtesitesCim = adatok[szamok[6]];
            }
            TanuloAzonositoja = adatok[szamok[7]];
            if (TanuloAzonositoja.Length < 12)
            {
                TAzonosito = "0";
            }
            else
            {
                TAzonosito = adatok[szamok[7]].Substring(0, 12);
            }
            TKezdete = adatok[szamok[8]];
            TanuloIktatoszama = adatok[szamok[9]];
            VezetesiKarton = adatok[szamok[10]];
            ElsoElmelet = adatok[szamok[11]];
            ElmeletTargy = adatok[szamok[12]];
            ElsoElmeletVizsga = adatok[szamok[13]];
            SikeresElmeletVizsga = adatok[szamok[14]];
            SikertelenSzama = adatok[szamok[15]];
            Korlatozasok = adatok[szamok[16]];
            telefonszam = adatok[szamok[19]];
            email = adatok[szamok[20]];
            allampolgarsag = "-";

            if (sablonok[index].Contains("abc"))
            {
                if (adatok[szamok[0]].Contains("("))
                {
                    string[] szed = adatok[szamok[0]].Split('(');
                    Nev = szed[0].Trim();
                    SzuleteskoriNev = szed[1].Replace(")", "");

                }
                else
                {
                    SzuleteskoriNev = Nev;
                }
                try
                {
                    SikertelenSzama = "\t";
                    if (adatok[15].Contains("M"))
                    {
                        SikeresElmeletVizsga = adatok[15].Replace("M", "");
                    }
                    else
                    {
                        ElsoElmeletVizsga = adatok[15].Substring(0, 10);
                        SikeresElmeletVizsga = adatok[16].Replace("M", "");
                    }
                }
                catch
                {
                    ElsoElmeletVizsga = "\t";
                    SikeresElmeletVizsga = "\t";

                }
                
                Kategoria = ", " + adatok[szamok[17]];
                TVege = adatok[szamok[21]];
            }
            else if(sablonok[index].Contains("fout"))
            {
                if (adatok[szamok[1]] == "U.A." || adatok[szamok[1]] == "U.A" || adatok[szamok[1]] == "u.a." || adatok[szamok[1]] == "u.a")
                {
                    SzuleteskoriNev = adatok[szamok[0]];
                }
                else
                {
                    SzuleteskoriNev = adatok[szamok[1]];
                }
                allampolgarsag = adatok[szamok[18]];
                Kategoria = ", B";
                TVege = adatok[szamok[12]];
            }
            else
            {
                Kategoria = adatok[szamok[17]];
                TVege = adatok[szamok[21]];
            }
        }
    }
}