using System;
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
using OfficeOpenXml;
using OfficeOpenXml.Style;
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

            Properties.Settings.Default.ExcelFajlHelye = fajlHely;

            if (fileMethods.isExcelComptaible(fajlHely))
            {
                fileMethods.FajlOlvasas();
                ListaJelenites();
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
                MessageBox.Show("Nem megfelelő a megadott fájlformátum. (.csv , .xlsx, .xlsm)", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Properties.Settings.Default.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setDefault();
            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
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
            } else
            {
                return;
            }
            string fajlHely = excelHelye.Text;

            Properties.Settings.Default.ExcelFajlHelye = fajlHely;

            if (fileMethods.isExcelComptaible(fajlHely))
            {
                fileMethods.FajlOlvasas();
                ListaJelenites();
            }
            else if (Path.GetExtension(fajlHely) == ".csv")
            {
                ExcelOldalNevek.Visible = false;
                frissites.Visible = false;
            }
            else
            {
                excelHelye.Text = "";
                fajlHely = "";
                ExcelOldalNevek.Visible = false;
                frissites.Visible = false;
                MessageBox.Show("Nem megfelelő a megadott fájlformátum. (.csv , .xlsx, .xlsm)", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Properties.Settings.Default.Save();
        }

        private void SorSzam_TextChanged(object sender, EventArgs e)
        {
            mentettFajlNeve.Text = "";
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

        private void valaszt_Click_1(object sender, EventArgs e)
        {
            fileMethods.FajlOlvasas();
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
            valasztFolyamatban.Visible = true;
            valasztFolyamatban.BringToFront();
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
                                string nev = SorSzam.Text.ToLower().Trim();
                                
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
                                    
                                    nev = nev.Replace("dr.", "");
                                    nev2 = nev2.Replace("dr.", "");
                                    if (nev2.Contains("("))
                                    {
                                        string[] ketNev = nev2.Split('(');
                                        nev2 = ketNev[0].Trim();
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
                                    string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.\n(Azonos nevűek sorszáma: " + sorString + ")";
                                    MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    kivalasztott = "";
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
                if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
                {
                    Excel.Application xlApp = StartExcel();
                    var xlWorkbooks = xlApp.Workbooks;
                    string hely = Properties.Settings.Default.ExcelFajlMasolata;
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
                        string nev = SorSzam.Text.ToLower().Trim();
                        
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
                            nev = nev.Replace("dr.", "");
                            nev2 = nev2.Replace("dr.", "");

                            if (nev2.Contains("("))
                            {
                                string[] ketNev = nev2.Split('(');
                                nev2 = ketNev[0].Trim();
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
                            string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.\n(Azonos nevűek sorszáma: " + sorString + ")";
                            MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            kivalasztott = "";
                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Nincs találat. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    fileMethods.DisposeExcelInstance(xlApp, xlWorkbooks, xlWorksheet);
                }
            }
            if (kivalasztott.Contains("("))
            {
                string[] ketNev = kivalasztott.Split('(');
                kivalasztott = ketNev[0].Trim();
            }
            if (kivalasztott == null || kivalasztott == "")
            {
                mentettFajlNeve.Text = "Nincs találat";
            }
            else
            {
                mentettFajlNeve.Text = (kivalasztott).Replace(' ', '_');
            }
            valasztFolyamatban.Visible = false;
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            WindowsFormsApp_autósiskola.Properties.Settings.Default.wordMegnyitasa = nyissaEMeg.Checked;
            Properties.Settings.Default.Save();
        }

        private void ExcelOldal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;
            Properties.Settings.Default.Save();
            mentettFajlNeve.Text = "";
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
            bool sikeres = true;
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
                                int count = 0;
                                List<string> sorszamok = new List<string>();
                                string nev = SorSzam.Text.ToLower().Trim();
                                
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
                        List<string> sorszamok = new List<string>();
                        int count = 0;
                        string nev = SorSzam.Text.ToLower().Trim();
                        
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
                    fileMethods.DisposeExcelInstance(xlApp, xlWorkbooks, xlWorksheet);
                    
                }
                if (sikeres == false)
                {
                    return;
                }
                #region word fájlozás

                string fajl = mentesHelye.Text + "/" + mentettFajlNeve;
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
            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
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
                    try
                    {
                        ExcelOldalNevek.SelectedIndex = Properties.Settings.Default.oldalszam;
                    }
                    catch
                    {
                        ExcelOldalNevek.SelectedIndex = 0;
                        Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;
                        Properties.Settings.Default.Save();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hibás az excel fájl!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    excelHelye.Text = "";
                    Properties.Settings.Default.ExcelFajlHelye = "";
                    ExcelOldalNevek.Visible = false;
                    frissites.Visible = false;
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
            nyissaEMeg.Checked = Properties.Settings.Default.wordMegnyitasa;
            ekezetek.Checked = Properties.Settings.Default.ekezetek;
            szokoz.Checked = Properties.Settings.Default.szokoz;
            helyIdo.Checked = Properties.Settings.Default.helyIdo;
            honapBetu.Checked = Properties.Settings.Default.honapBetu;
            ujTanuloIdo.Checked = Properties.Settings.Default.ujTanuloIdo;
            kiallitasiHely.Text = Properties.Settings.Default.kiallitasiHely;
            frissites.Visible = ExcelOldalNevek.Visible;
            comboBox1.SelectedIndex = Properties.Settings.Default.comboIndex;
            iskolaAzonosito.Text = Properties.Settings.Default.iskolaAzonosito;
            iskolaNev.Text = Properties.Settings.Default.iskolaNev;
            iskolaCim.Text = Properties.Settings.Default.iskolaCim;
            mentesFolyamatban.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

            DateTime temp;
            string ido = DateTime.Now.ToString("MM/dd/yyyy"); 
            if (!DateTime.TryParse(ido, out temp))
            {
                Properties.Settings.Default.ujTanuloIdo = false;
                ujTanuloIdo.Checked = false;
                ujTanuloIdo.Enabled = false;
                ujTanuloIdo.Visible = false;

                Properties.Settings.Default.helyIdo = false;
                helyIdo.Checked = false;
                helyIdo.Enabled = false;
                helyIdo.Visible = false;
            }
            else
            {
                ujTanuloIdo.Enabled = true;
                ujTanuloIdo.Visible = true;

                helyIdo.Enabled = true;
                helyIdo.Visible = true;
            }
            Properties.Settings.Default.Save();

            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
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
                                string nev = SorSzam.Text.ToLower().Trim();
                                
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

                                    nev = nev.Replace("dr.", "");
                                    nev2 = nev2.Replace("dr.", "");

                                    if (nev2.Contains("("))
                                    {
                                        string[] ketNev = nev2.Split('(');
                                        nev2 = ketNev[0].Trim();
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

                else if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
                {
                    Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;

                    Excel.Application xlApp = StartExcel();
                    var xlWorkbooks = xlApp.Workbooks;
                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
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
                        string nev = SorSzam.Text.ToLower().Trim();
                        
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

                            nev = nev.Replace("dr.", "");
                            nev2 = nev2.Replace("dr.", "");
                            if (nev2.Contains("("))
                            {
                                string[] ketNev = nev2.Split('(');
                                nev2 = ketNev[0].Trim();
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

                try
                {
                    dataGridView1.Rows[0].ReadOnly = true;
                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
                    dataGridView1.Rows[0].DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
                    dataGridView1.Rows[0].DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                catch
                {
                    MessageBox.Show("Üres a fájl!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    panel7.Visible = false;
                    return;
                }
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
            if (fileMethods.isExcelComptaible(fajlhely))
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
                else
                {
                    MessageBox.Show("Nem elérhető a fájl. Zárja be a szerkesztés miatt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            megjegyzesek.Text = "";
            List<string> adatTipusok = new List<string>();
            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
            {
                fileMethods.FajlOlvasas();

                Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;

                bool szabadE = fileMethods.IsFileLocked(Properties.Settings.Default.ExcelFajlHelye);
                if (szabadE == true)
                {
                    MessageBox.Show("Nem elérhető a fájl. Zárja be a szerkesztés miatt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Csak .xlsx, vagy .xlsm fájlnál működik a funkció!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Clear();
            for (int i = 0; i < adatTipusok.Count - 2; i++)
            {
                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = adatTipusok[i];
            }
            try
            {
                dataGridView1.Rows[0].Cells[1].Value = totalRows;
            }
            catch
            {
                MessageBox.Show("Semmilyen adattípus nincs megadva a táblázatban!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel7.Visible = false;
                return;
            }
            string ido = DateTime.Now.ToString("MM/dd/yyyy");
            string ev = ido.Substring(8, 4) + ".";
            string honap = ido.Substring(0, 2) + ".";
            string nap = ido.Substring(4, 2) + ".";
            if (Properties.Settings.Default.ujTanuloIdo)
            {
                megjegyzesek.Text = ("Hozzáadás dátuma: " + ev + honap + nap);
            }

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

        private void torles_Click(object sender, EventArgs e)
        {
            string fajlhely = Properties.Settings.Default.ExcelFajlHelye;
            if (fileMethods.isExcelComptaible(fajlhely))
            {
                if (fileMethods.IsFileLocked(fajlhely) == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Biztosan kitörli a választott tanulót? Nem lehet visszavonni a törlés után.", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                    torlesFolyamatban.BringToFront();
                    torlesFolyamatban.Visible = true;

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
                        szam = Convert.ToInt32(sorszam) + 1;
                    }
                    catch (Exception)
                    {
                        fileMethods.DisposeExcelInstance(xlAppMain, xlWorkbooks, xlWorksheet);
                        MessageBox.Show("Hiba a sorszám olvasásnál!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    szam = kivSor;

                    Excel.Range row = xlWorksheet.Rows[szam];
                    row.Delete();

                    for(int i = szam; i < totalColumns; i++)
                    {
                        int ujSzam = szam - 1;
                        xlWorksheet.Cells[szam, 1].Value = ujSzam;
                    }
                    try
                    {
                        xlWorkbook.Save();
                    }
                    catch
                    {
                        MessageBox.Show("Nem sikerült a mentés! Ellenőrizze hogy be van-e zárva a fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    fileMethods.DisposeExcelInstance(xlAppMain, xlWorkbooks, xlWorksheet);
                    megjegyzesek.Text = "";
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Nem sikerült a hozzáférés! Ellenőrizze hogy be van-e zárva a fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            torlesFolyamatban.Visible = false;
            panel6.Visible = false;
            mentettFajlNeve.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.comboIndex = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.ujTanuloIdo = ujTanuloIdo.Checked;
            Properties.Settings.Default.Save();
        }

        private void iskolaAzonosito_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.iskolaAzonosito = iskolaAzonosito.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.iskolaNev = iskolaNev.Text;
            Properties.Settings.Default.Save();
        }

        private void iskolaCim_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.iskolaCim = iskolaCim.Text;
            Properties.Settings.Default.Save();
        }
    }
}


