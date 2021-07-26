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
using WindowsFormsApp_autósiskola.Classes;

namespace WindowsFormsApp_autósiskola
{
    class WordFile
    {
        #region Képzési Igazolás Létrehozása
        public void KepzesiIgazolasLetrehozas(Excel.Workbooks xlWorkbooks, string sorszam, object filename, object saveAs, string format)
        {
            tanulo kivalasztott;
            ExcelRead.getExcelData(xlWorkbooks, sorszam, out kivalasztott);

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

                    this.FindAndReplace(wordApp, "<Nev>", kivalasztott.Nev);
                    this.FindAndReplace(wordApp, "<SzuleteskoriNev>", kivalasztott.SzuleteskoriNev.Trim());
                    this.FindAndReplace(wordApp, "<SzuletesiHelyIdo>", kivalasztott.SzuletesiHely + ", " + kivalasztott.SzuletesiIdo);
                    this.FindAndReplace(wordApp, "<Anyja>", kivalasztott.Anyja);
                    this.FindAndReplace(wordApp, "<Lakcim>", kivalasztott.Lakcim);
                    this.FindAndReplace(wordApp, "<ErtesitesCim>", kivalasztott.ErtesitesCim);
                    this.FindAndReplace(wordApp, "<TAzonosito>", kivalasztott.TAzonosito);
                    this.FindAndReplace(wordApp, "<Kategoria>", kivalasztott.Kategoria);
                    this.FindAndReplace(wordApp, "<TKezdete>", kivalasztott.TKezdete + " - " + kivalasztott.TVege);
                    this.FindAndReplace(wordApp, "<TanuloAzonositoja>", kivalasztott.TanuloAzonositoja);
                    this.FindAndReplace(wordApp, "<TanuloIktatoszama>", kivalasztott.TanuloIktatoszama);
                    this.FindAndReplace(wordApp, "<VezetesiKarton>", kivalasztott.VezetesiKarton);
                    this.FindAndReplace(wordApp, "<ElsoElmelet>", kivalasztott.ElsoElmelet);
                    this.FindAndReplace(wordApp, "<ElmeletTargy>", kivalasztott.ElmeletTargy);
                    this.FindAndReplace(wordApp, "<ElsoElmeletVizsga>", kivalasztott.ElsoElmeletVizsga);
                    this.FindAndReplace(wordApp, "<SikeresElmeletVizsga>", kivalasztott.SikeresElmeletVizsga);
                    this.FindAndReplace(wordApp, "<SikertelenSzama>", kivalasztott.SikertelenSzama);
                    this.FindAndReplace(wordApp, "<Korlatozasok>", kivalasztott.Korlatozasok);



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
                    else if (format == ".pdf")
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

        #endregion

        #endregion

        #region Jelentkezési lap létrehozása
        public void JelentkezesiLapLetrehozas(Excel.Workbooks xlWorkbooks, string sorszam, object filename, object saveAs, string format)
        {

            tanulo kivalasztott;
            ExcelRead.getExcelData(xlWorkbooks, sorszam, out kivalasztott);

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

                    this.FindAndReplace(wordApp, "<Nev>", kivalasztott.Nev);
                    this.FindAndReplace(wordApp, "<SzuleteskoriNev>", kivalasztott.SzuleteskoriNev.Trim());
                    this.FindAndReplace(wordApp, "<SzuletesiHelyIdo>", kivalasztott.SzuletesiHely + ", " + kivalasztott.SzuletesiIdo);
                    this.FindAndReplace(wordApp, "<szuletesiHely>", kivalasztott.SzuletesiHely);
                    this.FindAndReplace(wordApp, "<szuletesiDatum>", kivalasztott.SzuletesiIdo);


                    this.FindAndReplace(wordApp, "<Anyja>", kivalasztott.Anyja);
                    this.FindAndReplace(wordApp, "<Lakcim>", kivalasztott.Lakcim);
                    this.FindAndReplace(wordApp, "<ErtesitesCim>", kivalasztott.ErtesitesCim);

                    if (kivalasztott.TanuloAzonositoja == "-")
                    {
                        this.FindAndReplace(wordApp, "<TanuloAzonositoja>", "\t");
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<TanuloAzonositoja>", kivalasztott.TanuloAzonositoja.Substring(5, kivalasztott.TanuloAzonositoja.Length - 5));
                    }
                    this.FindAndReplace(wordApp, "<Kategoria>", kivalasztott.Kategoria.Replace(", ", ""));

                    if (kivalasztott.TKezdete == "")
                    {
                        this.FindAndReplace(wordApp, "<TKezdete>", "\t");
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<TKezdete>", kivalasztott.TKezdete);
                    }

                    if (kivalasztott.allampolgarsag == "-")
                    {
                        this.FindAndReplace(wordApp, "<allampolgarsag>", "\t");
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<allampolgarsag>", kivalasztott.allampolgarsag);
                    }
                    this.FindAndReplace(wordApp, "<Telefonszam>", kivalasztott.telefonszam);
                    this.FindAndReplace(wordApp, "<Email>", kivalasztott.email);


                    //az extra rubtikák

                    int nevIndex = 0;
                    if (kivalasztott.Nev.ToLower().Contains("dr."))
                    {
                        this.FindAndReplace(wordApp, "<Dr>", "Dr.");
                        nevIndex++;
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<Dr>", "");
                    }

                    string[] nevelemek = kivalasztott.Nev.Split(' ');

                    this.FindAndReplace(wordApp, "<vezeteknev>", nevelemek[nevIndex]);

                    string utonev = "";
                    for (int i = nevIndex + 1; i < nevelemek.Length; i++)
                    {
                        utonev = utonev + " " + nevelemek[i];
                    }
                    this.FindAndReplace(wordApp, "<utonev>", utonev);


                    //Lakcim
                    string[] lakcimek = kivalasztott.Lakcim.Split(' ');
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
                    string[] ertesitesiCim = kivalasztott.ErtesitesCim.Split(' ');
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
        #endregion

        #endregion

        #region Beiratkozási Adatlap
        public void BeiratkozasLetrehozas(Excel.Workbooks xlWorkbooks, string sorszam, object filename, object saveAs, string format)
        {
            tanulo kivalasztott;
            ExcelRead.getExcelData(xlWorkbooks, sorszam, out kivalasztott);

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

                    this.FindAndReplace(wordApp, "<Nev>", kivalasztott.Nev);

                    if (kivalasztott.Nev == kivalasztott.SzuleteskoriNev.Trim())
                    {
                        this.FindAndReplace(wordApp, "<SzuleteskoriNev>", "");
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<SzuleteskoriNev>", kivalasztott.SzuleteskoriNev.Trim());
                    }

                    this.FindAndReplace(wordApp, "<szuletesiHely>", kivalasztott.SzuletesiHely);
                    this.FindAndReplace(wordApp, "<szuletesiDatum>", kivalasztott.SzuletesiIdo);
                    this.FindAndReplace(wordApp, "<Anyja>", kivalasztott.Anyja);
                    this.FindAndReplace(wordApp, "<Lakcim>", kivalasztott.Lakcim);
                    this.FindAndReplace(wordApp, "<ErtesitesCim>", kivalasztott.ErtesitesCim);

                    this.FindAndReplace(wordApp, "<Telefonszam>", kivalasztott.telefonszam);
                    this.FindAndReplace(wordApp, "<Email>", kivalasztott.email);
                    this.FindAndReplace(wordApp, "<allampolgarsag>", kivalasztott.allampolgarsag);


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
        #endregion

        #endregion

        #region Felnőttképzési szerződés
        public void FelnottSzerzodesLetrehozas(Excel.Workbooks xlWorkbooks, string sorszam, object filename, object saveAs, string format)
        {
            tanulo kivalasztott;
            ExcelRead.getExcelData(xlWorkbooks, sorszam, out kivalasztott);

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

                    this.FindAndReplace(wordApp, "<Nev>", kivalasztott.Nev);

                    if (kivalasztott.Nev == kivalasztott.SzuleteskoriNev.Trim())
                    {
                        this.FindAndReplace(wordApp, "<SzuleteskoriNev>", "");
                    }
                    else
                    {
                        this.FindAndReplace(wordApp, "<SzuleteskoriNev>", kivalasztott.SzuleteskoriNev.Trim());
                    }

                    this.FindAndReplace(wordApp, "<SzuletesiHelyIdo>", kivalasztott.SzuletesiHely + ", " + kivalasztott.SzuletesiIdo);

                    this.FindAndReplace(wordApp, "<Anyja>", kivalasztott.Anyja);
                    this.FindAndReplace(wordApp, "<Lakcim>", kivalasztott.Lakcim);
                    this.FindAndReplace(wordApp, "<ErtesitesCim>", kivalasztott.ErtesitesCim);
                    this.FindAndReplace(wordApp, "<Telefonszam>", kivalasztott.telefonszam);
                    this.FindAndReplace(wordApp, "<Email>", kivalasztott.email);
                    this.FindAndReplace(wordApp, "<allampolgarsag>", kivalasztott.allampolgarsag);
                    this.FindAndReplace(wordApp, "<TanuloAzonositoja>", kivalasztott.TanuloAzonositoja);
                    this.FindAndReplace(wordApp, "<TKezdete>", kivalasztott.TKezdete);


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
