﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Threading.Tasks;
using System.Threading;


namespace WindowsFormsApp_autósiskola
{
    public partial class Form1 : Form
    {
        public int kivSor;
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.nyelv);

            InitializeComponent();
            this.MouseDown += label6_MouseDown;
            //Properties.Settings.Default.Reset();

            setDefault();
        }
        
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
              e.Effect = DragDropEffects.Link;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if(files.Length > 1)
            {
                MessageBox.Show("Több fájlt választott ki!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string fajlHely = files[0];

            if (Path.GetExtension(fajlHely) == ".xlsx")
            {
                Properties.Settings.Default.ExcelFajlMasolata = System.AppDomain.CurrentDomain.BaseDirectory + "\\ExcelMasolat.xlsx";
                System.IO.File.Copy(fajlHely, Properties.Settings.Default.ExcelFajlMasolata, true);

                using (var from = File.Open(fajlHely, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var to = File.OpenWrite(Properties.Settings.Default.ExcelFajlMasolata))
                {
                    from.CopyToAsync(to);
                    to.Dispose();
                    from.Dispose();
                }
            }
            else if (Path.GetExtension(fajlHely) == ".csv")
            {

            }
            else
            {
                excelHelye.Text = "";
                fajlHely = "";
                ExcelOldalNevek.Visible = false;
                frissites.Visible = false;
                MessageBox.Show("Nem megfelelő a megadott fájlformátum. (.csv , .xlsx)", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            excelHelye.Text = fajlHely;

            Properties.Settings.Default.ExcelFajlHelye = fajlHely;
            Properties.Settings.Default.Save();
            ListaJelenites();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setDefault();
            if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".xlsx")
            {
                ExcelOldalNevek.Visible = true;
                frissites.Visible = true;
            }
            else
            {
                ExcelOldalNevek.Visible = false;
                frissites.Visible = false;
                panel5.Visible = false;
            }
        }

        private void excelKereses_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                excelHelye.Text = openFD.FileName;
            }
            string fajlHely = excelHelye.Text;

            if (Path.GetExtension(fajlHely) == ".xlsx")
            {
                Properties.Settings.Default.ExcelFajlMasolata = System.AppDomain.CurrentDomain.BaseDirectory + "\\ExcelMasolat.xlsx";
                System.IO.File.Copy(fajlHely, Properties.Settings.Default.ExcelFajlMasolata, true);

                using (var from = File.Open(fajlHely, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var to = File.OpenWrite(Properties.Settings.Default.ExcelFajlMasolata))
                {
                    from.CopyToAsync(to);
                    to.Dispose();
                    from.Dispose();
                }
                
            }
            else if (Path.GetExtension(fajlHely) == ".csv")
            { 

            }
            else
            {
                excelHelye.Text = "";
                fajlHely = "";
                ExcelOldalNevek.Visible = false;
                frissites.Visible = false;
                MessageBox.Show("Nem megfelelő a megadott fájlformátum. (.csv , .xlsx)", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Properties.Settings.Default.ExcelFajlHelye = fajlHely;
            Properties.Settings.Default.Save();
            ListaJelenites();
        }

        private void SorSzam_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (mentettFajlNeve.Text == "")
            {
                MessageBox.Show("Adj nevet a fájlnak.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SorSzam.Text == "" || mentesHelye.Text == "" || excelHelye.Text == "")
            {
                MessageBox.Show("Ellenőrizd a megadott fájlokat, és adatokat.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mentettFajlNeve.Text == "Nincs találat")
            {
                MessageBox.Show("Nincs találat az adott sorszámra vagy névre az adott dokumentumban.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dokumentumKeszites.Enabled = false;
            panel4.BringToFront();
            panel4.Visible = true;
            fileMethods.FajlOlvasas();

            string kepzesiIgazolas = Path.GetFullPath("kepzesi igazolas sablon a programhoz.docx");
            string ujfajl = mentesHelye.Text + "\\" + mentettFajlNeve.Text + ".docx";
            int i = 1;
            while (File.Exists(ujfajl))
            {
                ujfajl = mentesHelye.Text + "\\" + mentettFajlNeve.Text + "(" + i + ")" + ".docx";
                i++;
            }
                
            WordFileLetrehozas(kepzesiIgazolas, ujfajl);
            await PutTaskDelay();
            dokumentumKeszites.Enabled = true;
            panel4.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mentesHelyeKereses_Click(object sender, EventArgs e)
        {
            if (filepath.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(filepath.SelectedPath))
            {
                mentesHelye.Text = filepath.SelectedPath;
            }
            string fajlHely = mentesHelye.Text;
            Properties.Settings.Default.KeszWord = fajlHely;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (SorSzam.Text == "" || SorSzam.Text == null)
            {
                MessageBox.Show("Írj be nevet vagy sorszámot", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (excelHelye.Text == "" || excelHelye.Text == null)
            {
                MessageBox.Show("Válaszd ki az olvasni kívánt excel fájlt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mentesHelye.Text == "" || mentesHelye.Text == null)
            {
                MessageBox.Show("Válaszd ki a mentés helyét!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string kivalasztott = "";
            if (Properties.Settings.Default.ExcelFajlHelye != null && SorSzam.Text != null)
            {
                if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".csv")
                {
                    try
                    {
                        var fs = new FileStream(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using (var Olvas = new StreamReader(fs, Encoding.Default))
                        {
                            if (generalMethods.isDigitOnly(SorSzam.Text))
                            {
                                for (int i = 0; i <= (Convert.ToInt32(SorSzam.Text)); i++)
                                {
                                    if (i == Convert.ToInt32(SorSzam.Text))
                                    {
                                        string Sor = Olvas.ReadLine();
                                        string[] Sorelemek = Sor.Split(';');
                                        kivalasztott = Sorelemek[1];
                                    }
                                    else
                                    {
                                        string nem = Olvas.ReadLine();
                                    }
                                }
                            }
                            if (!generalMethods.isDigitOnly(SorSzam.Text))
                            {
                                List<string> sorszamok = new List<string>();
                                var sorString = "";
                                string nev = SorSzam.Text.ToLower();
                                int count = 0;
                                while (!Olvas.EndOfStream)
                                {
                                    string sor = Olvas.ReadLine();
                                    string[] Sorelemek = sor.Split(';');
                                    string nev2 = Sorelemek[1].ToLower();
                                    if (!ekezetek.Checked)
                                    {
                                        nev = generalMethods.RemoveDiacritics(nev);
                                        nev2 = generalMethods.RemoveDiacritics(nev2);
                                    }
                                    if (!szokoz.Checked)
                                    {
                                        nev = nev.Replace(" ", "").Replace("-", "");
                                        nev2 = nev2.Replace(" ", "").Replace("-", "");
                                    }
                                    if (nev == nev2)
                                    {
                                        sorszamok.Add(Sorelemek[0]);
                                        kivalasztott = Sorelemek[1];
                                        count++;
                                    }
                                }
                                if (count > 1)
                                {
                                    sorString = String.Join(", ", sorszamok.ToArray());
                                    string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.(Azonos nevűek sorszáma: " + sorString + ")";
                                    MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                if (count == 0)
                                {
                                    MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Nem található a kiválasztott fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".xlsx")
                {
                    Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;

                    Excel.Application xlApp = StartExcel();
                    var xlWorkbooks = xlApp.Workbooks;
                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[ExcelOldalNevek.SelectedIndex + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = xlRange.Rows.Count;
                    int totalColumns = xlRange.Columns.Count;

                    if (generalMethods.isDigitOnly(SorSzam.Text))
                    {
                        int szam = Convert.ToInt32(SorSzam.Text) + 1;
                        kivalasztott = Convert.ToString(xlWorksheet.Cells[szam, 2].Text);
                    }
                    if (!generalMethods.isDigitOnly(SorSzam.Text))
                    {
                        List<string> sorszamok = new List<string>();
                        var sorString = "";
                        int count = 0;
                        string nev = SorSzam.Text.ToLower();
                        for (int Row = 1; Row <= totalRows; Row++)
                        {
                            string nev2 = Convert.ToString(xlWorksheet.Cells[Row, 2].Text);
                            if (nev2 == null)
                            {
                                nev2 = "";
                            }
                            nev2 = nev2.ToLower();
                            if (!ekezetek.Checked)
                            {
                                nev = generalMethods.RemoveDiacritics(nev);
                                nev2 = generalMethods.RemoveDiacritics(nev2);
                            }
                            if (!szokoz.Checked)
                            {
                                nev = nev.Replace(" ", "").Replace("-", "");
                                nev2 = nev2.Replace(" ", "").Replace("-", "");
                            }
                            if (nev == nev2)
                            {
                                sorszamok.Add(Convert.ToString(xlWorksheet.Cells[Row, 1].Text));
                                kivalasztott = Convert.ToString(xlWorksheet.Cells[Row, 2].Text);
                                count++;
                            }
                        }
                        if (count > 1)
                        {
                            sorString = String.Join(", ", sorszamok.ToArray());
                            string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.(Azonos nevűek sorszáma: " + sorString + ")";
                            MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Nincs találat. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    fileMethods.DisposeExcelInstance(xlApp, xlWorkbooks, xlWorksheet);
                }
            }
            if (kivalasztott == null || kivalasztott == "")
            {
                mentettFajlNeve.Text = "Nincs találat";
            }
            else
            {
                mentettFajlNeve.Text = (kivalasztott).Replace(' ', '_');
            }
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            WindowsFormsApp_autósiskola.Properties.Settings.Default.Checkbox = nyissaEMeg.Checked;
            Properties.Settings.Default.Save();
        }

        private void ExcelOldal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;
            Properties.Settings.Default.Save();
        }
                
        private void mentesHelye_TextChanged(object sender, EventArgs e)
        {

        }


        private void ekezetek_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ekezetek = ekezetek.Checked;
            Properties.Settings.Default.Save();
        }
        
        private void szokoz_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.szokoz = szokoz.Checked;
            Properties.Settings.Default.Save();
        }

        private async void frissites_Click(object sender, EventArgs e)
        {
            frissites.Enabled = false;
            panel5.Visible = true;
            panel5.BringToFront();
            try
            {
                fileMethods.FajlOlvasas();
            }
            catch(Exception)
            {
                MessageBox.Show("Nem található a fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ListaJelenites();
            await PutTaskDelay();
            panel5.Visible = false;
            frissites.Enabled = true;
        }
        async Task PutTaskDelay()
        {
            await Task.Delay(1500);
        }
        #region WordFileLetrehozas
        public void WordFileLetrehozas(object filename, object saveAs)
        {
            List<tanulo> kivalasztott = new List<tanulo>();
            if (Properties.Settings.Default.ExcelFajlHelye != null && SorSzam.Text != null)
            {
                if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".csv")
                {
                    try
                    {
                        var fs = new FileStream(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using (var Olvas = new StreamReader(fs, Encoding.Default))
                        {
                            if (generalMethods.isDigitOnly(SorSzam.Text))
                            {
                                for (int i = 0; i <= (Convert.ToInt32(SorSzam.Text)); i++)
                                {
                                    if (i == Convert.ToInt32(SorSzam.Text))
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
                            else if (!generalMethods.isDigitOnly(SorSzam.Text))
                            {
                                string nev = SorSzam.Text.ToLower();
                                while (!Olvas.EndOfStream)
                                {
                                    string sor = Olvas.ReadLine();
                                    string[] Sorelemek = sor.Split(';');
                                    string nev2 = Sorelemek[1].ToLower();
                                    if (!ekezetek.Checked)
                                    {
                                        nev = generalMethods.RemoveDiacritics(nev);
                                        nev2 = generalMethods.RemoveDiacritics(nev2);
                                    }
                                    if (!szokoz.Checked)
                                    {
                                        nev = nev.Replace(" ", "").Replace("-", "");
                                        nev2 = nev2.Replace(" ", "").Replace("-", "");
                                    }
                                    if (nev == nev2)
                                    {
                                        kivalasztott.Add(new tanulo(sor));
                                    }
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

                if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".xlsx")
                {
                    Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;

                    Excel.Application xlApp = StartExcel();
                    var xlWorkbooks = xlApp.Workbooks;
                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[ExcelOldalNevek.SelectedIndex + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = xlRange.Rows.Count;
                    int totalColumns = xlRange.Columns.Count;

                    if (generalMethods.isDigitOnly(SorSzam.Text))
                    {
                        int szam = Convert.ToInt32(SorSzam.Text) + 1;
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
                    if (!generalMethods.isDigitOnly(SorSzam.Text))
                    {
                        string nev = SorSzam.Text.ToLower();
                        for (int Row = 1; Row <= totalRows; Row++)
                        {
                            string nev2 = Convert.ToString(xlWorksheet.Cells[Row, 2].Text);
                            if (nev2 == null)
                            {
                                nev2 = "";
                            }
                            nev2 = nev2.ToLower();
                            if (!ekezetek.Checked)
                            {
                                nev = generalMethods.RemoveDiacritics(nev);
                                nev2 = generalMethods.RemoveDiacritics(nev2);
                            }
                            if (!szokoz.Checked)
                            {
                                nev = nev.Replace(" ", "").Replace("-", "");
                                nev2 = nev2.Replace(" ", "").Replace("-", "");
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
                            }
                        }
                    }
                    fileMethods.DisposeExcelInstance(xlApp, xlWorkbooks, xlWorksheet);
                    
                }
                #region word fájlozás

                string fajl = mentesHelye.Text + "/" + mentettFajlNeve;
                object missing = System.Reflection.Missing.Value;

                Word.Application wordApp = new Word.Application();

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

                        this.FindAndReplace(wordApp, "<Nev>", kivalasztott[0].Nev);
                        this.FindAndReplace(wordApp, "<SzuleteskoriNev>", kivalasztott[0].SzuleteskoriNev);
                        this.FindAndReplace(wordApp, "<SzuletesiHelyIdo>", kivalasztott[0].SzuletesiHely + ", " + kivalasztott[0].SzuletesiIdo);
                        this.FindAndReplace(wordApp, "<Anyja>", kivalasztott[0].Anyja);
                        this.FindAndReplace(wordApp, "<Lakcim>", kivalasztott[0].Lakcim);
                        this.FindAndReplace(wordApp, "<ErtesitesCim>", kivalasztott[0].ErtesitesCim);
                        this.FindAndReplace(wordApp, "<TAzonosito>", kivalasztott[0].TAzonosito);
                        this.FindAndReplace(wordApp, "<TKezdete>", kivalasztott[0].TKezdete + " - " + kivalasztott[0].SikeresElmeletVizsga);
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


                        aDoc.SaveAs2(ref saveAs, ref missing,
                                            ref readOnly, ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing,
                                            ref missing, ref isVisible, ref missing, ref missing,
                                            ref missing, ref missing);

                        if (nyissaEMeg.Checked == true)
                        {
                            wordApp.Visible = true;
                            File.SetAttributes(Convert.ToString(saveAs), FileAttributes.Normal);
                            System.Diagnostics.Process.Start(saveAs.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Sikerült!");
                        }
                        aDoc.Close();
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
        public void ListaJelenites()
        {
            if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".xlsx")
            {
                Excel.Application xlApp = StartExcel();
                Excel.Workbooks workbooks = xlApp.Workbooks;

                ExcelOldalNevek.Items.Clear();
                ExcelOldalNevek.Visible = true;
                frissites.Visible = true;
                try
                {
                    var excelBooks = workbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);

                    String[] excelSheets = new String[excelBooks.Worksheets.Count];
                    int i = 0;
                    foreach (Excel.Worksheet wSheet in excelBooks.Worksheets)
                    {
                        excelSheets[i] = wSheet.Name;
                        ExcelOldalNevek.Items.Add(wSheet.Name);
                        i++;
                    }
                    ExcelOldalNevek.SelectedIndex = Properties.Settings.Default.oldalszam;
                }
                catch (Exception)
                {
                    {
                        File.Delete(Properties.Settings.Default.ExcelFajlMasolata);
                        ExcelOldalNevek.Visible = false;
                        frissites.Visible = false;
                    }
                }
                finally
                {
                    fileMethods.DisposeExcelInstance(xlApp, workbooks);
                    GC.Collect();
                }
            }
            else
            {
                ExcelOldalNevek.Visible = false;
                frissites.Visible = false;
            } 
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else if (!panel1.Visible)
            {
                panel1.BringToFront();
                panel1.Visible = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.kiallitasiHely = kiallitasiHely.Text;
            Properties.Settings.Default.Save();
        }

        private void bezaras_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void helyIdo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.helyIdo = helyIdo.Checked;
            Properties.Settings.Default.Save();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void honapBetu_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.honapBetu = honapBetu.Checked;
            Properties.Settings.Default.Save();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool mouseDown;
        private Point lastLocation;
        private DataGridView.HitTestInfo hitTestInfo;

        private void label6_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void label6_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dokumentumKeszites_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void setDefault()
        {
            excelHelye.Text = Properties.Settings.Default.ExcelFajlHelye;
            mentesHelye.Text = Properties.Settings.Default.KeszWord;
            nyissaEMeg.Checked = Properties.Settings.Default.Checkbox;
            ekezetek.Checked = Properties.Settings.Default.ekezetek;
            szokoz.Checked = Properties.Settings.Default.szokoz;
            helyIdo.Checked = Properties.Settings.Default.helyIdo;
            honapBetu.Checked = Properties.Settings.Default.honapBetu;
            kiallitasiHely.Text = Properties.Settings.Default.kiallitasiHely;
            frissites.Visible = ExcelOldalNevek.Visible;
            mentesFolyamatban.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

            if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".xlsx")
            {
                try
                {
                    fileMethods.FajlOlvasas();
                }
                catch (Exception)
                {
                    excelHelye.Text = "";
                    Properties.Settings.Default.ExcelFajlHelye = "";
                    return;
                }

                //Excel.Application xlApp = new Excel.Application();
                //var workbooks = xlApp.Workbooks;
                //try
                //{
                //    var excelBook = workbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                //    fileMethods.DisposeExcelInstance(xlApp, workbooks);
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Az előző fájl meghibásodott!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    File.Delete(Properties.Settings.Default.ExcelFajlMasolata);
                //    fileMethods.DisposeExcelInstance(xlApp, workbooks);
                //    return;
                //}
                ExcelOldalNevek.Visible = true;
                frissites.Visible = true;
                ListaJelenites();
            }
            else
            {
                ExcelOldalNevek.Visible = false;
                frissites.Visible = false;
            }
        }
        

        private void mehet_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SorSzam.Text == "" || SorSzam.Text == null)
            {
                MessageBox.Show("Írj be nevet vagy sorszámot", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (excelHelye.Text == "" || excelHelye.Text == null)
            {
                MessageBox.Show("Válaszd ki az olvasni kívánt excel fájlt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mentesHelye.Text == "" || mentesHelye.Text == null)
            {
                MessageBox.Show("Válaszd ki a mentés helyét!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            panel7.BringToFront();
            panel7.Visible = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            bool elso = true;

            fileMethods.FajlOlvasas();
            List<string> adatTipusok = new List<string>();
            List<string> kivalasztott = new List<string>();
            string megjegyzes = "";
            List<string> sorszamok = new List<string>();

            if (Properties.Settings.Default.ExcelFajlHelye != null && SorSzam.Text != null)
            {
                if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".csv")
                {
                    try
                    {
                        var fs = new FileStream(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using (var Olvas = new StreamReader(fs, Encoding.Default))
                        {
                            if (generalMethods.isDigitOnly(SorSzam.Text))
                            {
                                for (int i = 0; i <= (Convert.ToInt32(SorSzam.Text)); i++)
                                {
                                    string sor = Olvas.ReadLine();
                                    if (sor == null)
                                    {
                                        MessageBox.Show("Üres a fájl", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        panel7.Visible = false;
                                        return;
                                    }
                                    if (elso == true)
                                    {
                                        string[] Sorelemek = sor.Split(';');
                                        for (int j = 0; j < (Sorelemek.Length); j++)
                                        {
                                            adatTipusok.Add(Sorelemek[j]);
                                            elso = false;
                                        }
                                    }

                                    if (i == Convert.ToInt32(SorSzam.Text))
                                    {
                                        string[] Sorelemek= sor.Split(';');
                                        for (int j = 0; j < (Sorelemek.Length); j++)
                                        {
                                            kivalasztott.Add(Sorelemek[j].Replace("0:00:00", ""));
                                        }
                                        megjegyzes = Sorelemek.Last();
                                    }
                                }
                            }
                            else if (!generalMethods.isDigitOnly(SorSzam.Text))
                            {
                                int count = 0;
                                string nev = SorSzam.Text.ToLower();
                                while (!Olvas.EndOfStream)
                                {
                                    string sor = Olvas.ReadLine();
                                    string[] Sorelemek = sor.Split(';');
                                    string nev2 = Sorelemek[1].ToLower().Replace("0:00:00", "");

                                    if (sor == null)
                                    {
                                        MessageBox.Show("Üres a fájl", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        panel7.Visible = false;
                                        return;
                                    }
                                    if (elso == true)
                                    {
                                        for (int j = 0; j < (Sorelemek.Length); j++)
                                        {
                                            adatTipusok.Add(Sorelemek[j]);
                                            elso = false;
                                        }
                                    }
                                    if (!ekezetek.Checked)
                                    {
                                        nev = generalMethods.RemoveDiacritics(nev);
                                        nev2 = generalMethods.RemoveDiacritics(nev2);
                                    }
                                    if (!szokoz.Checked)
                                    {
                                        nev = nev.Replace(" ", "").Replace("-", "");
                                        nev2 = nev2.Replace(" ", "").Replace("-", "");
                                    }
                                    if (nev == nev2)
                                    {
                                        sorszamok.Add(Sorelemek[0]);
                                        for (int j = 0; j < (Sorelemek.Length); j++)
                                        {
                                            kivalasztott.Add(Sorelemek[j]);
                                        }
                                        megjegyzes = Sorelemek.Last();
                                        count++;
                                    }
                                }
                                if (count > 1)
                                {
                                    string sorString = String.Join(", ", sorszamok.ToArray());
                                    string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.(Azonos nevűek sorszáma: " + sorString + ")";
                                    MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    panel7.Visible = false;
                                    return;
                                }
                                if (count == 0)
                                {
                                    MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    panel7.Visible = false;
                                    return;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nem található a kiválasztott fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        panel7.Visible = false;
                        return;
                    }
                    mentes.Visible = false;
                }

                else if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".xlsx")
                {
                    Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;

                    Excel.Application xlApp = StartExcel();
                    var xlWorkbooks = xlApp.Workbooks;
                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata, CorruptLoad: true);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[ExcelOldalNevek.SelectedIndex + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = xlRange.Rows.Count;
                    int totalColumns = xlRange.Columns.Count;

                    if (elso == true)
                    {
                        int szam = 1;
                        var sb = new StringBuilder();
                        for (int ColumnNum = 1; ColumnNum <= totalColumns+1; ColumnNum++)
                        {
                            string row = Convert.ToString(xlWorksheet.Cells[szam, ColumnNum].Text);
                            if (row == null)
                            {
                                row = "";
                            }
                            sb.Append("đ");
                            sb.Append(row);
                        }
                        string[] Sorelemek = sb.ToString().Split('đ');

                        for (int j = 1; j < Sorelemek.Length; j++)
                        {
                            adatTipusok.Add(Sorelemek[j]);
                            string test = Sorelemek[j];

                        }
                        elso = false;
                    }

                    if (generalMethods.isDigitOnly(SorSzam.Text))
                    {
                        int szam = Convert.ToInt32(SorSzam.Text) + 1;
                        kivSor = szam;
                        var sb = new StringBuilder();
                        for (int ColumnNum = 1; ColumnNum <= totalColumns+1; ColumnNum++)
                        {
                            string row = Convert.ToString(xlWorksheet.Cells[szam, ColumnNum].Text);
                            if (row == null)
                            {
                                row = "";
                            }
                            sb.Append("đ");
                            sb.Append(row.Replace("0:00:00", ""));
                        }
                        string[] Sorelemek = sb.ToString().Split('đ');
                        
                        for (int j = 1; j < Sorelemek.Length; j++)
                        {
                            kivalasztott.Add(Sorelemek[j]);
                        }
                        megjegyzes = Sorelemek[Sorelemek.Length-2];
                    }
                    
                    if (!generalMethods.isDigitOnly(SorSzam.Text))
                    {
                        int count = 0;
                        string nev = SorSzam.Text.ToLower();
                        for (int Row = 1; Row <= totalRows+1; Row++)
                        {
                            string nev2 = Convert.ToString(xlWorksheet.Cells[Row, 2].Text);
                            if (nev2 == null)
                            {
                                nev2 = "";
                            }
                            nev2 = nev2.ToLower();
                            if (!ekezetek.Checked)
                            {
                                nev = generalMethods.RemoveDiacritics(nev);
                                nev2 = generalMethods.RemoveDiacritics(nev2);
                            }
                            if (!szokoz.Checked)
                            {
                                nev = nev.Replace(" ", "").Replace("-", "");
                                nev2 = nev2.Replace(" ", "").Replace("-", "");
                            }
                            if (nev == nev2)
                            {
                                kivSor = Row;
                                var sb = new StringBuilder();
                                for (int ColumnNum = 1; ColumnNum <= totalColumns+1; ColumnNum++) //select starting row here
                                {
                                    string nextData = Convert.ToString(xlWorksheet.Cells[Row, ColumnNum].Text);
                                    if (nextData == null)
                                    {
                                        nextData = "";
                                    }
                                    sb.Append("đ");
                                    sb.Append(nextData.Replace("0:00:00", ""));
                                }
                                string[] Sorelemek = sb.ToString().Split('đ');

                                count++;
                                sorszamok.Add(Convert.ToString(xlWorksheet.Cells[Row, 1].Text));
                                for (int j = 1; j < Sorelemek.Length; j++)
                                {
                                    kivalasztott.Add(Sorelemek[j]);
                                    string test2 = Sorelemek[j];

                                }
                                megjegyzes = Sorelemek[Sorelemek.Length-2];

                            }
                        }
                        if (count > 1)
                        {
                            string sorString = String.Join(", ", sorszamok.ToArray());
                            string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.(Azonos nevűek sorszáma: " + sorString + ")";
                            MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            fileMethods.DisposeExcelInstance(xlApp, xlWorkbooks, xlWorksheet);
                            panel7.Visible = false;
                            return;
                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            panel7.Visible = false;
                            return;
                        }
                    }
                    mentes.Visible = true;
                    fileMethods.DisposeExcelInstance(xlApp, xlWorkbooks, xlWorksheet);
                }

                if (adatTipusok.Count > kivalasztott.Count)
                {
                    int kulonbseg = adatTipusok.Count - kivalasztott.Count;
                    for (int j = 0; j < kulonbseg; j++)
                    {
                        kivalasztott.Add("");
                    }
                }
                megjegyzesek.Text = megjegyzes;
                elso = true;
                for (int i = 0; i < adatTipusok.Count-2; i++)
                {
                    var index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = adatTipusok[i];
                    dataGridView1.Rows[index].Cells[1].Value = kivalasztott[i];
                }
                
                dataGridView1.Rows[0].ReadOnly = true;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(224,224,224);
                dataGridView1.Rows[0].DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
                dataGridView1.Rows[0].DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            panel6.BringToFront();
            panel6.Visible = true;
            panel7.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void szerkesztes_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[1].Cells[1].Value == null || dataGridView1.Rows[1].Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Nem írt be nevet a tanulónak!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            mentesFolyamatban.Visible = true;
            mentesFolyamatban.BringToFront();
            var fajlhely = Properties.Settings.Default.ExcelFajlHelye;
            if (Path.GetExtension(fajlhely) == ".xlsx")
            {
                if (fileMethods.IsFileLocked(fajlhely) == false)
                {
                    Excel.Application xlAppMain = new Excel.Application();
                    var xlWorkbooks = xlAppMain.Workbooks;
                    var xlWorkbook = xlWorkbooks.Open(fajlhely);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[ExcelOldalNevek.SelectedIndex + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = xlRange.Rows.Count;
                    int totalColumns = xlRange.Columns.Count;


                    string sorszam = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    int szam = 0;
                    try
                    {
                        szam = Convert.ToInt32(sorszam)+1;
                    }
                    catch (Exception)
                    {
                        fileMethods.DisposeExcelInstance(xlAppMain, xlWorkbooks, xlWorksheet);
                        MessageBox.Show("Hiba a sorszám olvasásnál!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int count = 0;
                    szam = kivSor;
                    while (count < dataGridView1.RowCount-1)
                    {
                        string data;
                        if (dataGridView1.Rows[count].Cells[1].Value == null)
                        {
                            data = "";
                        }
                        else
                        {
                            data = (dataGridView1.Rows[count].Cells[1].Value.ToString());

                        }
                        xlWorksheet.Cells[szam, count+1].Value = data;
                        count++;
                    }
                    xlWorksheet.Columns.RowHeight = 15;

                    string megjegyzes = (megjegyzesek.Text);
                    xlWorksheet.Cells[szam, totalColumns].Value = megjegyzes;
                    try
                    {
                        xlWorkbook.Save();
                    }
                    catch
                    {
                        MessageBox.Show("Nem sikerült a mentés! Ellenőrizze hogy be van-e zárva a fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    fileMethods.DisposeExcelInstance(xlAppMain, xlWorkbooks, xlWorksheet);
                }
            }
            mentesFolyamatban.Visible = false;
        }

        private void ujTanulo_Click(object sender, EventArgs e)
        {

            if (excelHelye.Text == "" || excelHelye.Text == null)
            {
                MessageBox.Show("Válaszd ki az olvasni kívánt excel fájlt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int totalRows = 1;
            List<string> adatTipusok = new List<string>();
            if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".xlsx")
            {
                fileMethods.FajlOlvasas();

                Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;

                bool szabadE = fileMethods.IsFileLocked(Properties.Settings.Default.ExcelFajlHelye);
                if (szabadE == true)
                {
                    MessageBox.Show("Nincs bezárva a másolat fájl!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Excel.Application xlApp = StartExcel();
                var xlWorkbooks = xlApp.Workbooks;
                var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[ExcelOldalNevek.SelectedIndex + 1];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                totalRows = xlRange.Rows.Count;
                int totalColumns = xlRange.Columns.Count;
                kivSor = totalRows + 1;
                int szam = 1;
                var sb = new StringBuilder();
                for (int ColumnNum = 1; ColumnNum <= totalColumns + 1; ColumnNum++)
                {
                    string row = Convert.ToString(xlWorksheet.Cells[szam, ColumnNum].Text);
                    if (row == null)
                    {
                        row = "";
                    }
                    sb.Append("đ");
                    sb.Append(row);
                }
                fileMethods.DisposeExcelInstance(xlApp, xlWorkbooks, xlWorksheet);

                string[] Sorelemek = sb.ToString().Split('đ');

                for (int j = 1; j < Sorelemek.Length; j++)
                {
                    adatTipusok.Add(Sorelemek[j]);
                    string test = Sorelemek[j];

                }
            }
            else
            {
                MessageBox.Show("Csak .xlsx fájlnál működik a funkció!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Clear();
            for (int i = 0; i < adatTipusok.Count - 2; i++)
            {
                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = adatTipusok[i];
            }
            dataGridView1.Rows[0].Cells[1].Value = totalRows;
            megjegyzesek.Text = "";

            dataGridView1.Rows[0].ReadOnly = true;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Rows[0].DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Rows[0].DefaultCellStyle.SelectionForeColor = Color.Black;
        
            panel6.BringToFront();
            panel6.Visible = true;
            panel7.Visible = false;
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                    dataGridView1.BeginEdit(true);
                else
                    dataGridView1.EndEdit();
            }
        }

        private void megjegyzesek_TextChanged(object sender, EventArgs e)
        {

        }
        public Excel.Application StartExcel()
        {
            Excel.Application instance = null;
            try
            {
                instance = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                instance = new Excel.Application();
            }

            return instance;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetFullPath("SablonFajl.xlsx");
                Excel.Application excel = new Excel.Application();
                Excel.Workbook wb = excel.Workbooks.Open(path);
                excel.Visible = true;
            }
            catch
            {
                MessageBox.Show("Nem található meg a sablon fájl!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GC.Collect();
            }
        }
    }
}


