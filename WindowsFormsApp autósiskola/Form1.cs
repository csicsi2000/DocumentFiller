using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp_autósiskola
{
    public partial class Form1 : Form
    {
        public int kivSor;
        public List<string> listOnit = new List<string>();
        List<string> listNew = new List<string>();
        private excelApp xlApp;
        private Excel.Workbooks xlWorkbooks;


        public Form1()
        {
            InitializeComponent();

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            xlApp = new excelApp();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.nyelv);
            statisztika1.books(xlApp.xlWorkbooks);
            tanuloAdatok1.books(xlApp.xlWorkbooks);
            xlWorkbooks = xlApp.xlWorkbooks;

            MouseDown += label6_MouseDown;
            //Properties.Settings.Default.Reset();
            setDefault();
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
            DocTipus.SelectedIndex = Properties.Settings.Default.dokumentumTipus;
            fileFormat.SelectedIndex = Properties.Settings.Default.fileFormat;
            staticLoading.Hide();
            loading1.Hide();
            statisztika1.Hide();
            tanuloAdatok1.Hide();
            panel1.Visible = false;
            panel5.Visible = false;
            AllowDrop = true;
            DragEnter += new DragEventHandler(Form1_DragEnter);
            DragDrop += new DragEventHandler(Form1_DragDrop);
            VersionDisplay.Text = System.Windows.Forms.Application.ProductVersion;

            try
            {
                string ido = DateTime.Now.ToString("MM/dd/yyyy");
                ido.Substring(8, 4);
                ujTanuloIdo.Enabled = true;
                ujTanuloIdo.Visible = true;

                helyIdo.Enabled = true;
                helyIdo.Visible = true;
            }
            catch
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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length > 1)
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
            }
            else
            {
                return;
            }
            string fajlHely = excelHelye.Text;

            if (!File.Exists(fajlHely))
            {
                MessageBox.Show("Nem található a fájl. (.csv , .xlsx, .xlsm)", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            staticLoading.Visible = true;
            staticLoading.BringToFront();
            Properties.Settings.Default.ExcelFajlHelye = fajlHely;

            if (fileMethods.isExcelComptaible(fajlHely))
            {
                if (xlApp == null)
                {
                    MessageBox.Show("Nem található Excel alkalmazás!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    excelHelye.Text = "";
                    ExcelOldalNevek.Visible = false;
                    frissites.Visible = false;
                    return;
                }
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
                ExcelOldalNevek.Visible = false;
                frissites.Visible = false;
                MessageBox.Show("Nem megfelelő a megadott fájlformátum. (.csv , .xlsx, .xlsm)", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Properties.Settings.Default.Save();
            staticLoading.Visible = false;
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
            panel3.Enabled = false;
            tableLayoutPanel3.Enabled = false;
            loading1.BringToFront();
            loading1.Visible = true;
            fileMethods.FajlOlvasas();

            string ujfajl = mentesHelye.Text + "\\" + mentettFajlNeve.Text;
            

            if (DocTipus.SelectedIndex == 0)
            {
                string kepzesiIgazolas = Path.GetFullPath("kepzesi igazolas sablon a programhoz.docx");
                string sorszam = SorSzam.Text;
                string format = fileFormat.Text;
                WordFile csinál = new WordFile();
                await (Task.Run(() => csinál.KepzesiIgazolasLetrehozas(xlWorkbooks, sorszam, kepzesiIgazolas, ujfajl, format)));
            }
            else if(DocTipus.SelectedIndex == 1)
            {
                string JelentkezesiLap = Path.GetFullPath("jelentkezesiLapSablon.docx");
                string sorszam = SorSzam.Text;
                string format = fileFormat.Text;
                WordFile csinál = new WordFile();
                await (Task.Run(() => csinál.JelentkezesiLapLetrehozas(xlWorkbooks, sorszam, JelentkezesiLap, ujfajl, format)));
            }
            panel3.Enabled = true;
            tableLayoutPanel3.Enabled = true;
            loading1.Visible = false;
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
            SorSzam.Items.Clear();
            listOnit.Clear();
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
            label8.Visible = true;
            label8.BringToFront();
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
                    catch (Exception)
                    {
                        MessageBox.Show("Nem található a kiválasztott fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
                {
                    string hely = Properties.Settings.Default.ExcelFajlMasolata;
                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[ExcelOldalNevek.SelectedIndex + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = excelApp.GetMinimalUsedRangeAddress(xlWorksheet);
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
                    fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
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
            Application.DoEvents();
            label8.Visible = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.wordMegnyitasa = nyissaEMeg.Checked;
            Properties.Settings.Default.Save();
        }

        private void ExcelOldal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.oldalszam = ExcelOldalNevek.SelectedIndex;
            Properties.Settings.Default.Save();
            mentettFajlNeve.Text = "";

            autoSuggestTolt();
        }
        public void autoSuggestTolt()
        {
            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
            {
                staticLoading.Visible = true;
                staticLoading.BringToFront();


                string hely = Properties.Settings.Default.ExcelFajlMasolata;
                var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[ExcelOldalNevek.SelectedIndex + 1];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                int totalRows = xlRange.Rows.Count;
                int totalColumns = xlRange.Columns.Count;
                AutoCompleteStringCollection nevek = new AutoCompleteStringCollection();
                string nev = SorSzam.Text.ToLower().Trim();

                SorSzam.Items.Clear();
                listOnit.Clear();
                for (int Row = 2; Row <= totalRows; Row++)
                {
                    string SzerkNev = Convert.ToString(xlWorksheet.Cells[Row, 2].Text);
                    if (SzerkNev.Contains("("))
                    {
                        string[] ketNev = SzerkNev.Split('(');
                        SzerkNev = ketNev[0].Trim();
                    }
                    string nev2 = SzerkNev;
                    if (SzerkNev == null)
                    {
                        SzerkNev = "";
                        continue;
                    }
                    listOnit.Add(nev2);
                }
                SorSzam.Items.AddRange(listOnit.ToArray());
                fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
                staticLoading.Visible = false;
            }
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
            catch (Exception)
            {
                MessageBox.Show("Nem található a fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ListaJelenites();
            Application.DoEvents();
            await PutTaskDelay();
            frissites.Enabled = true;
            panel5.Visible = false;
        }
        async Task PutTaskDelay()
        {
            await Task.Delay(1500);
        }

        public void ListaJelenites()
        {
            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
            {
                ExcelOldalNevek.Items.Clear();
                ExcelOldalNevek.Visible = true;
                frissites.Visible = true;
                Excel.Workbook excelBooks = null;
                try
                {
                    excelBooks = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);

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
                catch (Exception ex)
                {
                    MessageBox.Show("Hibás az excel fájl! "+ ex, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    excelHelye.Text = "";
                    Properties.Settings.Default.ExcelFajlHelye = "";
                    ExcelOldalNevek.Visible = false;
                    frissites.Visible = false;
                }
                finally
                {
                    if (excelBooks != null)
                    {
                        fileMethods.DisposeExcelInstance(excelBooks);
                    }
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

        private void label6_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }
        private void label6_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }
        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        private void button1_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void SorSzam_TextUpdate(object sender, EventArgs e)
        {
            mentettFajlNeve.Text = "";
            SorSzam.Items.Clear();
            listNew.Clear();
            if (SorSzam.Text == null || SorSzam.Text == "")
            {
                SorSzam.Items.Add("");
                SorSzam.DroppedDown = false;
            }
            if (!generalMethods.isDigitOnly(SorSzam.Text))
            {
                SorSzam.DroppedDown = true;

                string nev = SorSzam.Text.ToLower();
                string betu = SorSzam.Text;

                foreach (var item in listOnit)
                {
                    string nev2 = item.ToLower();
                    if (nev2 == null)
                    {
                        nev2 = "";
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
                    if (nev2.Contains(nev))
                    {
                        listNew.Add(item);
                    }
                }
                SorSzam.Items.AddRange(listNew.ToArray());
                if (listNew.Count == 0)
                {
                    SorSzam.Items.Add(SorSzam.Text);
                }
                if (SorSzam.Items.Count == 0)
                {
                    SorSzam.Items.Add(SorSzam.Text);
                }
            }
            SorSzam.SelectedItem = null;
            SorSzam.SelectionStart = SorSzam.Text.Length;
            Cursor = Cursors.Default;
            SorSzam.AutoCompleteMode = AutoCompleteMode.None;
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

        private void ujTanulo_Click(object sender, EventArgs e)
        {
            staticLoading.BringToFront();
            staticLoading.Show();
            tanuloAdatok1.ujTanulo(excelHelye.Text);
            staticLoading.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel7.BringToFront();
            panel7.Visible = true;
            tanuloAdatok1.TanuloAdatBetoltes(SorSzam.Text, excelHelye.Text);
            panel7.Visible = false;
        }

        private void fooldal_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            tanuloAdatok1.Hide();
            statisztika1.Hide();
        }

        private void statNyit_Click(object sender, EventArgs e)
        {
            staticLoading.Show();
            staticLoading.BringToFront();
            string text = SorSzam.Text;
            string hely = excelHelye.Text;
            statisztika1.adatokListazas(text, hely);
            staticLoading.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileMethods.DisposeExcelInstance(xlApp.xlApp, xlWorkbooks);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dokumentumTipus = DocTipus.SelectedIndex;
        }

        private void fileFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.fileFormat = fileFormat.SelectedIndex;
        }
    }
}


