using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;

namespace WindowsFormsApp_autósiskola
{
    class WordFile
    {
        #region Képzési Igazolás Létrehozása
        public void KepzesiIgazolasLetrehozas(Excel.Workbooks xlWorkbooks, string sorszam,object filename, object saveAs, string format)
        {
            bool sikeres = true;
            List<tanulo> kivalasztott = new List<tanulo>();
            if (Properties.Settings.Default.ExcelFajlHelye != null && sorszam != null)
            {
                if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".csv")
                {
                    try
                    {
                        var fs = new FileStream(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using (var Olvas = new StreamReader(fs, Encoding.Default))
                        {
                            if (generalMethods.isDigitOnly(sorszam))
                            {
                                for (int i = 0; i <= (Convert.ToInt32(sorszam)); i++)
                                {
                                    if (i == Convert.ToInt32(sorszam))
                                    {
                                        string Sor = Olvas.ReadLine();
                                        kivalasztott.Add(new tanulo(Sor));
                                    }
                                    else
                                    {
                                        string nem = Olvas.ReadLine();
                                    }
                                }
                            }
                            else if (!generalMethods.isDigitOnly(sorszam))
                            {
                                int count = 0;
                                List<string> sorszamok = new List<string>();
                                string nev = sorszam.ToLower().Trim();

                                while (!Olvas.EndOfStream)
                                {
                                    string sor = Olvas.ReadLine();
                                    string[] Sorelemek = sor.Split(';');
                                    string nev2 = Sorelemek[1].ToLower();
                                    if (!Properties.Settings.Default.ekezetek)
                                    {
                                        nev = generalMethods.RemoveDiacritics(nev);
                                        nev2 = generalMethods.RemoveDiacritics(nev2);
                                    }
                                    if (!Properties.Settings.Default.szokoz)
                                    {
                                        nev = nev.Replace(" ", "").Replace("-", "");
                                        nev2 = nev2.Replace(" ", "").Replace("-", "");
                                    }

                                    nev = nev.Replace("dr.", "");
                                    nev2 = nev2.Replace("dr.", "");
                                    if (nev2.Contains("("))
                                    {
                                        string[] ketNev = nev2.Split('(');
                                        nev2 = ketNev[0].Trim();
                                    }

                                    if (nev == nev2)
                                    {
                                        kivalasztott.Add(new tanulo(sor));
                                        count++;
                                        sorszamok.Add(Sorelemek[0]);
                                    }
                                }
                                if (count > 1)
                                {
                                    string sorString = String.Join(", ", sorszamok.ToArray());
                                    string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.\n(Azonos nevűek sorszáma: " + sorString + ")";
                                    MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    sikeres = false;
                                }
                                if (count == 0)
                                {
                                    MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    sikeres = false;

                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nem található a kiválasztott fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
                {
                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[Properties.Settings.Default.oldalszam + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = excelApp.GetMinimalUsedRangeAddress(xlWorksheet);
                    int totalColumns = xlRange.Columns.Count;

                    if (generalMethods.isDigitOnly(sorszam))
                    {
                        int szam = Convert.ToInt32(sorszam) + 1;
                        var sb = new StringBuilder();
                        for (int ColumnNum = 2; ColumnNum <= totalColumns; ColumnNum++)
                        {
                            string row = Convert.ToString(xlWorksheet.Cells[szam, ColumnNum].Text);
                            if (row == null)
                            {
                                row = "";
                            }
                            sb.Append(";");
                            sb.Append(row);
                        }
                        kivalasztott.Add(new tanulo(sb.ToString()));
                    }
                    if (!generalMethods.isDigitOnly(sorszam))
                    {
                        List<string> sorszamok = new List<string>();
                        int count = 0;
                        string nev = sorszam.ToLower().Trim();

                        for (int Row = 1; Row <= totalRows; Row++)
                        {
                            string nev2 = Convert.ToString(xlWorksheet.Cells[Row, 2].Text);
                            if (nev2 == null)
                            {
                                nev2 = "";
                            }
                            nev2 = nev2.ToLower();
                            if (!Properties.Settings.Default.ekezetek)
                            {
                                nev = generalMethods.RemoveDiacritics(nev);
                                nev2 = generalMethods.RemoveDiacritics(nev2);
                            }
                            if (!Properties.Settings.Default.szokoz)
                            {
                                nev = nev.Replace(" ", "").Replace("-", "");
                                nev2 = nev2.Replace(" ", "").Replace("-", "");
                            }

                            nev = nev.Replace("dr.", "");
                            nev2 = nev2.Replace("dr.", "");

                            if (nev2.Contains("("))
                            {
                                string[] ketNev = nev2.Split('(');
                                nev2 = ketNev[0].Trim();
                            }

                            if (nev == nev2)
                            {
                                var sb = new StringBuilder();
                                for (int ColumnNum = 2; ColumnNum <= totalColumns; ColumnNum++) //select starting row here
                                {
                                    string nextData = Convert.ToString(xlWorksheet.Cells[Row, ColumnNum].Text);
                                    if (nextData == null)
                                    {
                                        nextData = "";
                                    }
                                    sb.Append(";");
                                    sb.Append(nextData);
                                }
                                kivalasztott.Add(new tanulo(sb.ToString()));
                                count++;
                                sorszamok.Add(Convert.ToString(xlWorksheet.Cells[Row, 1].Text));
                            }
                        }
                        if (count > 1)
                        {
                            string sorString = String.Join(", ", sorszamok.ToArray());
                            string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.\n(Azonos nevűek sorszáma: " + sorString + ")";
                            MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            sikeres = false;

                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            sikeres = false;
                        }
                    }
                    fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
                }
                if (sikeres == false)
                {
                    return;
                }
                #region word fájlozás

                object missing = System.Reflection.Missing.Value;

                Word.Application wordApp = null;
                try
                {
                    wordApp = (Word.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application");
                    if (wordApp.Visible == true)
                    {
                        wordApp = new Word.Application();
                    }
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    wordApp = new Word.Application();
                }
                wordApp.Visible = false;

                try
                {
                    Word.Document aDoc = null;

                    if (File.Exists((string)filename))
                    {
                        object readOnly = false;
                        object isVisible = false;
                        wordApp.Visible = false;

                        aDoc = wordApp.Documents.Open(ref filename, ref missing,
                                                        ref readOnly, ref missing, ref missing, ref missing,
                                                        ref missing, ref missing, ref missing, ref missing,
                                                        ref missing, ref isVisible, ref missing, ref missing,
                                                        ref missing, ref missing);
                        aDoc.Activate();
                        this.FindAndReplace(wordApp, "<iskolaAzonosito>", Properties.Settings.Default.iskolaAzonosito);
                        this.FindAndReplace(wordApp, "<iskolaNev>", Properties.Settings.Default.iskolaNev);
                        this.FindAndReplace(wordApp, "<iskolaCim>", Properties.Settings.Default.iskolaCim);

                        this.FindAndReplace(wordApp, "<Nev>", kivalasztott[0].Nev);
                        this.FindAndReplace(wordApp, "<SzuleteskoriNev>", kivalasztott[0].SzuleteskoriNev.Trim());
                        this.FindAndReplace(wordApp, "<SzuletesiHelyIdo>", kivalasztott[0].SzuletesiHely + ", " + kivalasztott[0].SzuletesiIdo);
                        this.FindAndReplace(wordApp, "<Anyja>", kivalasztott[0].Anyja);
                        this.FindAndReplace(wordApp, "<Lakcim>", kivalasztott[0].Lakcim);
                        this.FindAndReplace(wordApp, "<ErtesitesCim>", kivalasztott[0].ErtesitesCim);
                        this.FindAndReplace(wordApp, "<TAzonosito>", kivalasztott[0].TAzonosito);
                        this.FindAndReplace(wordApp, "<Kategoria>", kivalasztott[0].Kategoria);
                        this.FindAndReplace(wordApp, "<TKezdete>", kivalasztott[0].TKezdete + " - " + kivalasztott[0].TVege);
                        this.FindAndReplace(wordApp, "<TanuloAzonositoja>", kivalasztott[0].TanuloAzonositoja);
                        this.FindAndReplace(wordApp, "<TanuloIktatoszama>", kivalasztott[0].TanuloIktatoszama);
                        this.FindAndReplace(wordApp, "<VezetesiKarton>", kivalasztott[0].VezetesiKarton);
                        this.FindAndReplace(wordApp, "<ElsoElmelet>", kivalasztott[0].ElsoElmelet);
                        this.FindAndReplace(wordApp, "<ElmeletTargy>", kivalasztott[0].ElmeletTargy);
                        this.FindAndReplace(wordApp, "<ElsoElmeletVizsga>", kivalasztott[0].ElsoElmeletVizsga);
                        this.FindAndReplace(wordApp, "<SikeresElmeletVizsga>", kivalasztott[0].SikeresElmeletVizsga);
                        this.FindAndReplace(wordApp, "<SikertelenSzama>", kivalasztott[0].SikertelenSzama);
                        this.FindAndReplace(wordApp, "<Korlatozasok>", kivalasztott[0].Korlatozasok);



                        if (Properties.Settings.Default.helyIdo)
                        {
                            string ido = DateTime.Now.ToString("MM/dd/yyyy");
                            string ev = ido.Substring(8, 4) + ".";
                            string honap = ido.Substring(0, 2) + ".";
                            if (Properties.Settings.Default.honapBetu)
                            {
                                honap = DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("hu-HU")) + " ";
                            }
                            string nap = ido.Substring(4, 2) + ".";
                            this.FindAndReplace(wordApp, "<helyido>", " " + Properties.Settings.Default.kiallitasiHely + ", " + ev + honap + nap);
                        }
                        else
                        {
                            this.FindAndReplace(wordApp, "<helyido>", "\t,\tév\thónap\tnap");
                        }

                        if (format == ".docx")
                        {
                            saveAs = createNewFile(saveAs.ToString(), format);
                            aDoc.SaveAs2(saveAs, ref missing,
                                                ref readOnly, ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing, ref missing,
                                                ref missing, ref isVisible, ref missing, ref missing,
                                                ref missing, ref missing);

                        } 
                        else if(format == ".pdf")
                        {
                            saveAs = createNewFile(saveAs.ToString(), format);

                            aDoc.SaveAs2(saveAs, WdSaveFormat.wdFormatPDF, ref readOnly, ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing, ref missing,
                                                ref missing, ref isVisible, ref missing, ref missing,
                                                ref missing, ref missing);
                        }

                        if (Properties.Settings.Default.wordMegnyitasa == true)
                        {
                            File.SetAttributes(Convert.ToString(saveAs), FileAttributes.Normal);
                            System.Diagnostics.Process.Start(saveAs.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Sikerült!");
                        }
                        //prevent original file changes on save
                        object saveOption = Word.WdSaveOptions.wdDoNotSaveChanges;
                        object originalFormat = Word.WdOriginalFormat.wdOriginalDocumentFormat;
                        object routeDocument = false;
                        aDoc.Close(ref saveOption, ref originalFormat, ref routeDocument);
                    }
                    else
                    {
                        MessageBox.Show("Nincs meg a Word fájl.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Zárja be a word fájlt a feladatkezelőben!", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    wordApp.Quit();
                }
            }
        }
        #endregion

        #endregion

        #region Jelentkezési lap létrehozása
        public void JelentkezesiLapLetrehozas(Excel.Workbooks xlWorkbooks, string sorszam, object filename, object saveAs, string format)
        {
            bool sikeres = true;
            List<tanulo> kivalasztott = new List<tanulo>();
            if (Properties.Settings.Default.ExcelFajlHelye != null && sorszam != null)
            {
                if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".csv")
                {
                    try
                    {
                        var fs = new FileStream(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using (var Olvas = new StreamReader(fs, Encoding.Default))
                        {
                            if (generalMethods.isDigitOnly(sorszam))
                            {
                                for (int i = 0; i <= (Convert.ToInt32(sorszam)); i++)
                                {
                                    if (i == Convert.ToInt32(sorszam))
                                    {
                                        string Sor = Olvas.ReadLine();
                                        kivalasztott.Add(new tanulo(Sor));
                                    }
                                    else
                                    {
                                        string nem = Olvas.ReadLine();
                                    }
                                }
                            }
                            else if (!generalMethods.isDigitOnly(sorszam))
                            {
                                int count = 0;
                                List<string> sorszamok = new List<string>();
                                string nev = sorszam.ToLower().Trim();

                                while (!Olvas.EndOfStream)
                                {
                                    string sor = Olvas.ReadLine();
                                    string[] Sorelemek = sor.Split(';');
                                    string nev2 = Sorelemek[1].ToLower();
                                    if (!Properties.Settings.Default.ekezetek)
                                    {
                                        nev = generalMethods.RemoveDiacritics(nev);
                                        nev2 = generalMethods.RemoveDiacritics(nev2);
                                    }
                                    if (!Properties.Settings.Default.szokoz)
                                    {
                                        nev = nev.Replace(" ", "").Replace("-", "");
                                        nev2 = nev2.Replace(" ", "").Replace("-", "");
                                    }

                                    nev = nev.Replace("dr.", "");
                                    nev2 = nev2.Replace("dr.", "");
                                    if (nev2.Contains("("))
                                    {
                                        string[] ketNev = nev2.Split('(');
                                        nev2 = ketNev[0].Trim();
                                    }

                                    if (nev == nev2)
                                    {
                                        kivalasztott.Add(new tanulo(sor));
                                        count++;
                                        sorszamok.Add(Sorelemek[0]);
                                    }
                                }
                                if (count > 1)
                                {
                                    string sorString = String.Join(", ", sorszamok.ToArray());
                                    string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.\n(Azonos nevűek sorszáma: " + sorString + ")";
                                    MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    sikeres = false;
                                }
                                if (count == 0)
                                {
                                    MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    sikeres = false;

                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nem található a kiválasztott fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
                {

                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[Properties.Settings.Default.oldalszam + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = excelApp.GetMinimalUsedRangeAddress(xlWorksheet);
                    int totalColumns = xlRange.Columns.Count;

                    if (generalMethods.isDigitOnly(sorszam))
                    {
                        int szam = Convert.ToInt32(sorszam) + 1;
                        var sb = new StringBuilder();
                        for (int ColumnNum = 2; ColumnNum <= totalColumns; ColumnNum++)
                        {
                            string row = Convert.ToString(xlWorksheet.Cells[szam, ColumnNum].Text);
                            if (row == null)
                            {
                                row = "";
                            }
                            sb.Append(";");
                            sb.Append(row);
                        }
                        kivalasztott.Add(new tanulo(sb.ToString()));
                    }
                    if (!generalMethods.isDigitOnly(sorszam))
                    {
                        List<string> sorszamok = new List<string>();
                        int count = 0;
                        string nev = sorszam.ToLower().Trim();

                        for (int Row = 1; Row <= totalRows; Row++)
                        {
                            string nev2 = Convert.ToString(xlWorksheet.Cells[Row, 2].Text);
                            if (nev2 == null)
                            {
                                nev2 = "";
                            }
                            nev2 = nev2.ToLower();
                            if (!Properties.Settings.Default.ekezetek)
                            {
                                nev = generalMethods.RemoveDiacritics(nev);
                                nev2 = generalMethods.RemoveDiacritics(nev2);
                            }
                            if (!Properties.Settings.Default.szokoz)
                            {
                                nev = nev.Replace(" ", "").Replace("-", "");
                                nev2 = nev2.Replace(" ", "").Replace("-", "");
                            }

                            nev = nev.Replace("dr.", "");
                            nev2 = nev2.Replace("dr.", "");

                            if (nev2.Contains("("))
                            {
                                string[] ketNev = nev2.Split('(');
                                nev2 = ketNev[0].Trim();
                            }

                            if (nev == nev2)
                            {
                                var sb = new StringBuilder();
                                for (int ColumnNum = 2; ColumnNum <= totalColumns; ColumnNum++) //select starting row here
                                {
                                    string nextData = Convert.ToString(xlWorksheet.Cells[Row, ColumnNum].Text);
                                    if (nextData == null)
                                    {
                                        nextData = "";
                                    }
                                    sb.Append(";");
                                    sb.Append(nextData);
                                }
                                kivalasztott.Add(new tanulo(sb.ToString()));
                                count++;
                                sorszamok.Add(Convert.ToString(xlWorksheet.Cells[Row, 1].Text));
                            }
                        }
                        if (count > 1)
                        {
                            string sorString = String.Join(", ", sorszamok.ToArray());
                            string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.\n(Azonos nevűek sorszáma: " + sorString + ")";
                            MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            sikeres = false;

                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            sikeres = false;
                        }
                    }
                    fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
                }
                if (sikeres == false)
                {
                    return;
                }
                #region word fájlozás

                object missing = System.Reflection.Missing.Value;

                Word.Application wordApp = null;
                try
                {
                    wordApp = (Word.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application");
                    if (wordApp.Visible == true)
                    {
                        wordApp = new Word.Application();
                    }
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    wordApp = new Word.Application();
                }
                wordApp.Visible = false;

                try
                {
                    Word.Document aDoc = null;

                    if (File.Exists((string)filename))
                    {
                        object readOnly = false;
                        object isVisible = false;
                        wordApp.Visible = false;

                        aDoc = wordApp.Documents.Open(ref filename, ref missing,
                                                        ref readOnly, ref missing, ref missing, ref missing,
                                                        ref missing, ref missing, ref missing, ref missing,
                                                        ref missing, ref isVisible, ref missing, ref missing,
                                                        ref missing, ref missing);
                        aDoc.Activate();
                        this.FindAndReplace(wordApp, "<iskolaAzonosito>", Properties.Settings.Default.iskolaAzonosito);
                        this.FindAndReplace(wordApp, "<iskolaNev>", Properties.Settings.Default.iskolaNev);
                        this.FindAndReplace(wordApp, "<iskolaCim>", Properties.Settings.Default.iskolaCim);

                        this.FindAndReplace(wordApp, "<Nev>", kivalasztott[0].Nev);
                        this.FindAndReplace(wordApp, "<SzuleteskoriNev>", kivalasztott[0].SzuleteskoriNev.Trim());
                        this.FindAndReplace(wordApp, "<SzuletesiHelyIdo>", kivalasztott[0].SzuletesiHely + ", " + kivalasztott[0].SzuletesiIdo);
                        this.FindAndReplace(wordApp, "<szuletesiHely>", kivalasztott[0].SzuletesiHely);
                        this.FindAndReplace(wordApp, "<szuletesiDatum>", kivalasztott[0].SzuletesiIdo);


                        this.FindAndReplace(wordApp, "<Anyja>", kivalasztott[0].Anyja);
                        this.FindAndReplace(wordApp, "<Lakcim>", kivalasztott[0].Lakcim);
                        this.FindAndReplace(wordApp, "<ErtesitesCim>", kivalasztott[0].ErtesitesCim);

                        if(kivalasztott[0].TanuloAzonositoja == "-")
                        {
                            this.FindAndReplace(wordApp, "<TanuloAzonositoja>", "\t");
                        }
                        else
                        {
                            this.FindAndReplace(wordApp, "<TanuloAzonositoja>", kivalasztott[0].TanuloAzonositoja.Substring(5,kivalasztott[0].TanuloAzonositoja.Length-5));
                        }
                        this.FindAndReplace(wordApp, "<Kategoria>", kivalasztott[0].Kategoria.Replace(", ",""));

                        if (kivalasztott[0].TKezdete == "")
                        {
                            this.FindAndReplace(wordApp, "<TKezdete>", "\t");
                        }
                        else {
                            this.FindAndReplace(wordApp, "<TKezdete>", kivalasztott[0].TKezdete); 
                        }

                        if(kivalasztott[0].allampolgarsag == "-")
                        {
                            this.FindAndReplace(wordApp, "<allampolgarsag>", "\t");
                        }
                        else
                        {
                            this.FindAndReplace(wordApp, "<allampolgarsag>", kivalasztott[0].allampolgarsag);
                        }
                        this.FindAndReplace(wordApp, "<Telefonszam>", kivalasztott[0].telefonszam);
                        this.FindAndReplace(wordApp, "<Email>", kivalasztott[0].email);


                        //az extra rubtikák

                        int nevIndex = 0;
                        if (kivalasztott[0].Nev.ToLower().Contains("dr."))
                        {
                            this.FindAndReplace(wordApp, "<Dr>", "Dr.");
                            nevIndex++;
                        }
                        else
                        {
                            this.FindAndReplace(wordApp, "<Dr>", "");
                        }

                        string[] nevelemek = kivalasztott[0].Nev.Split(' ');

                        this.FindAndReplace(wordApp, "<vezeteknev>", nevelemek[nevIndex]);

                        string utonev = "";
                        for(int i = nevIndex+1; i < nevelemek.Length; i++)
                        {
                            utonev = utonev + " " + nevelemek[i];
                        }
                        this.FindAndReplace(wordApp, "<utonev>", utonev);


                        //Lakcim
                        string[] lakcimek = kivalasztott[0].Lakcim.Split(' ');
                        if (lakcimek.Length > 2)
                        {
                            this.FindAndReplace(wordApp, "<LakcimOrszag>", "Magyarország, " + lakcimek[0] + " " + lakcimek[1]);

                            int szamlal = 2;
                            string lakcim = "";
                            while (szamlal < lakcimek.Length)
                            {
                                lakcim = lakcim + " " + lakcimek[szamlal];
                                szamlal++;

                            }
                            this.FindAndReplace(wordApp, "<LakcimKozterulet>", lakcim);
                        }
                        else
                        {
                            this.FindAndReplace(wordApp, "<LakcimOrszag>", "");
                            this.FindAndReplace(wordApp, "<LakcimKozterulet>", "");

                        }

                        //ErtesitesiCim
                        string[] ertesitesiCim = kivalasztott[0].ErtesitesCim.Split(' ');
                        if (ertesitesiCim.Length > 2)
                        {
                            this.FindAndReplace(wordApp, "<TartozkodasicimOrszag>", "Magyarország, " + ertesitesiCim[0] + " " + ertesitesiCim[1]);

                            int szamlal = 2;
                            string ertesCim = "";
                            while (szamlal < ertesitesiCim.Length)
                            {
                                ertesCim = ertesCim + " " + ertesitesiCim[szamlal];
                                szamlal++;
                            }
                            this.FindAndReplace(wordApp, "<TartozkodasicimKozterulet>", ertesCim);
                        }
                        else
                        {
                            this.FindAndReplace(wordApp, "<TartozkodasicimOrszag>", "");
                            this.FindAndReplace(wordApp, "<TartozkodasicimKozterulet>", "");
                        }
                        //hely idő kitöltése
                        if (Properties.Settings.Default.helyIdo)
                        {
                            string ido = DateTime.Now.ToString("MM/dd/yyyy");
                            string ev = ido.Substring(8, 4) + ".";
                            string honap = ido.Substring(0, 2) + ".";
                            if (Properties.Settings.Default.honapBetu)
                            {
                                honap = DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("hu-HU")) + " ";
                            }
                            string nap = ido.Substring(4, 2) + ".";
                            this.FindAndReplace(wordApp, "<helyido>", " " + Properties.Settings.Default.kiallitasiHely + ", " + ev + honap + nap);
                        }
                        else
                        {
                            this.FindAndReplace(wordApp, "<helyido>", "\t,\tév\thónap\tnap");
                        }

                        if (format == ".docx")
                        {
                            saveAs = createNewFile(saveAs.ToString(), format);

                            aDoc.SaveAs2(ref saveAs, ref missing,
                                                ref readOnly, ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing, ref missing,
                                                ref missing, ref isVisible, ref missing, ref missing,
                                                ref missing, ref missing);
                        }
                        else if (format == ".pdf")
                        {
                            saveAs = createNewFile(saveAs.ToString(), format);

                            aDoc.SaveAs2(ref saveAs, WdSaveFormat.wdFormatPDF, ref readOnly, ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing, ref missing,
                                                ref missing, ref isVisible, ref missing, ref missing,
                                                ref missing, ref missing);
                        }


                        if (Properties.Settings.Default.wordMegnyitasa == true)
                        {
                            File.SetAttributes(Convert.ToString(saveAs), FileAttributes.Normal);
                            System.Diagnostics.Process.Start(saveAs.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Sikerült!");
                        }
                        object saveOption = Word.WdSaveOptions.wdDoNotSaveChanges;
                        object originalFormat = Word.WdOriginalFormat.wdOriginalDocumentFormat;
                        object routeDocument = false;
                        aDoc.Close(ref saveOption, ref originalFormat, ref routeDocument);
                    }
                    else
                    {
                        MessageBox.Show("Nincs meg a Word fájl.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Zárja be a word fájlt a feladatkezelőben!", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    wordApp.Quit();
                }
            }
        }
        #endregion

        #endregion


        #region FindAndReplace
        private void FindAndReplace(Word.Application wordApp,
            object findText, object replaceText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            wordApp.Selection.Find.Execute(ref findText, ref matchCase,
                ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
                ref matchAllWordForms, ref forward, ref wrap, ref format,
                ref replaceText, ref replace, ref matchKashida,
                        ref matchDiacritics,
                ref matchAlefHamza, ref matchControl);
        }
        #endregion

        /*
        public Excel.Application StartExcel()
        {
            Excel.Application instance = null;
            try
            {
                instance = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
                if (instance.Visible == true)
                {
                    instance = new Excel.Application();
                }
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                instance = new Excel.Application();
            }
            instance.Visible = false;
            return instance;
        }
        */
        public string createNewFile(string saveAs, string format)
        {
            string NewFile = saveAs + format;
            int i = 1;
            while (File.Exists(NewFile.ToString()))
            {
                NewFile = saveAs + "(" + i + ")" + format;
                i++;
            }

            return NewFile;
        }
    }
}
