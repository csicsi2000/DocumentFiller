using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp_autósiskola.GoogleSheet;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp_autósiskola
{
    public partial class TanuloAdatok : UserControl
    {
        public static int kivSor;
        private Excel.Workbooks xlWorkbooks;

        public TanuloAdatok()
        {
            InitializeComponent();
        }
        public void books(Excel.Workbooks books)
        {
            xlWorkbooks = books;
        }
        public bool TanuloAdatBetoltes(string sorszam, SheetAccess sheetAccess)
        {
            bool sikerült = false;
            if (sorszam == "" || sorszam == null)
            {
                MessageBox.Show("Írj be nevet vagy sorszámot", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sikerült;
            }
            if (!sheetAccess.IsValidSheetId())
            {
                MessageBox.Show("Nem Valid!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sikerült;
            }

            string Sorszam = "";
            List<string> allData= sheetAccess.GetAllDataTypes(ref Sorszam);


            return sikerült;
        }

        public bool TanuloAdatBetoltes(string sorszam, string excelHelye)
        {
            bool sikerült = false;
            if (sorszam == "" || sorszam == null)
            {
                MessageBox.Show("Írj be nevet vagy sorszámot", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sikerült;
            }
            if (excelHelye == "" || excelHelye == null)
            {
                MessageBox.Show("Válaszd ki az olvasni kívánt excel fájlt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sikerült;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            bool elso = true;

            fileMethods.FajlOlvasas();
            List<string> adatTipusok = new List<string>();
            List<string> kivalasztott = new List<string>();
            string megjegyzes = "";
            List<string> sorszamok = new List<string>();

            //csv fájl olvasása
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
                                    string sor = Olvas.ReadLine();
                                    if (sor == null)
                                    {
                                        MessageBox.Show("Üres a fájl", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        Visible = false;
                                        return sikerült;
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

                                    if (i == Convert.ToInt32(sorszam))
                                    {
                                        string[] Sorelemek = sor.Split(';');
                                        for (int j = 0; j < (Sorelemek.Length); j++)
                                        {
                                            kivalasztott.Add(Sorelemek[j].Replace("0:00:00", ""));
                                        }
                                        megjegyzes = Sorelemek.Last();
                                    }
                                }
                            }
                            else if (!generalMethods.isDigitOnly(sorszam))
                            {
                                int count = 0;
                                string nev = sorszam.ToLower().Trim();

                                while (!Olvas.EndOfStream)
                                {
                                    string sor = Olvas.ReadLine();
                                    string[] Sorelemek = sor.Split(';');
                                    string nev2 = Sorelemek[1].ToLower().Replace("0:00:00", "");

                                    if (sor == null)
                                    {
                                        MessageBox.Show("Üres a fájl", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        Visible = false;
                                        return sikerült;
                                    }
                                    if (elso == true)
                                    {
                                        for (int j = 0; j < (Sorelemek.Length); j++)
                                        {
                                            adatTipusok.Add(Sorelemek[j]);
                                            elso = false;
                                        }
                                    }
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
                                    Visible = false;
                                    return sikerült;
                                }
                                if (count == 0)
                                {
                                    MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Visible = false;
                                    return sikerült;
                                }
                            }
                        }
                        fs.Close();
                        fs.Dispose();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nem található a kiválasztott fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Visible = false;
                        return sikerült;
                    }
                    mentes.Visible = false;
                }

                else if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
                {

                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[Properties.Settings.Default.oldalszam + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = xlRange.Rows.Count;
                    int totalColumns = xlRange.Columns.Count;

                    if (elso == true)
                    {
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
                        string[] Sorelemek = sb.ToString().Split('đ');

                        for (int j = 1; j < Sorelemek.Length; j++)
                        {
                            adatTipusok.Add(Sorelemek[j]);
                            string test = Sorelemek[j];

                        }
                    }

                    if (generalMethods.isDigitOnly(sorszam))
                    {
                        int szam = Convert.ToInt32(sorszam) + 1;
                        kivSor = szam;
                        var sb = new StringBuilder();
                        for (int ColumnNum = 1; ColumnNum <= totalColumns + 1; ColumnNum++)
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
                        megjegyzes = Sorelemek[Sorelemek.Length - 2];
                    }

                    if (!generalMethods.isDigitOnly(sorszam))
                    {
                        int count = 0;
                        string nev = sorszam.ToLower().Trim();

                        for (int Row = 1; Row <= totalRows + 1; Row++)
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
                                kivSor = Row;
                                var sb = new StringBuilder();
                                for (int ColumnNum = 1; ColumnNum <= totalColumns + 1; ColumnNum++) //select starting row here
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
                                megjegyzes = Sorelemek[Sorelemek.Length - 2];

                            }
                        }
                        if (count > 1)
                        {
                            string sorString = String.Join(", ", sorszamok.ToArray());
                            string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.(Azonos nevűek sorszáma: " + sorString + ")";
                            MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
                            Visible = false;
                            return sikerült;
                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Visible = false;
                            return sikerült;
                        }
                    }
                    mentes.Visible = true;
                    fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
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
                for (int i = 0; i < adatTipusok.Count - 2; i++)
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
                    Visible = false;
                    return sikerült;
                }
            }
            sikerült = true;
            BringToFront();
            Show();
            return sikerült;
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
            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
            {
                if (fileMethods.IsFileLocked(Properties.Settings.Default.ExcelFajlHelye) == false)
                {
                    Excel.Workbook xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlHelye);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[Properties.Settings.Default.oldalszam + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = excelApp.GetMinimalUsedRangeAddress(xlWorksheet);
                    int totalColumns = xlRange.Columns.Count;


                    string sorszam = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    int szam = 0;
                    try
                    {
                        szam = Convert.ToInt32(sorszam) + 1;
                    }
                    catch (Exception)
                    {
                        fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
                        MessageBox.Show("Hiba a sorszám olvasásnál!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int count = 0;
                    szam = kivSor;
                    while (count < dataGridView1.RowCount - 1)
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
                        xlWorksheet.Cells[szam, count + 1].Value = data;
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
                    fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
                }
                else
                {
                    MessageBox.Show("Nem elérhető a fájl. Zárja be a szerkesztés miatt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            mentesFolyamatban.Visible = false;
        }

        public bool ujTanulo(string excelHelye)
        {
            if (excelHelye == "" || excelHelye == null)
            {
                MessageBox.Show("Válaszd ki az olvasni kívánt excel fájlt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int totalRows = 1;
            megjegyzesek.Text = "";
            List<string> adatTipusok = new List<string>();
            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
            {
                fileMethods.FajlOlvasas();

                bool szabadE = fileMethods.IsFileLocked(Properties.Settings.Default.ExcelFajlHelye);
                if (szabadE == true)
                {
                    MessageBox.Show("Nem elérhető a fájl. Zárja be a szerkesztés miatt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                Excel._Workbook xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[Properties.Settings.Default.oldalszam + 1];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                totalRows = excelApp.GetMinimalUsedRangeAddress(xlWorksheet);
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
                fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);

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
                return false;
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
                Visible = false;
                return false;
            }
            
            if (Properties.Settings.Default.ujTanuloIdo)
            {
                string ido = DateTime.Now.ToString("MM/dd/yyyy");
                string ev = ido.Substring(8, 4) + ".";
                string honap = ido.Substring(0, 2) + ".";
                string nap = ido.Substring(4, 2) + ".";
                megjegyzesek.Text = ("Hozzáadás dátuma: " + ev + honap + nap);
            }

            dataGridView1.Rows[0].ReadOnly = true;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Rows[0].DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Rows[0].DefaultCellStyle.SelectionForeColor = Color.Black;

            Application.DoEvents();
            BringToFront();
            Show();
            return true;
        }
        private DataGridView.HitTestInfo hitTestInfo;

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

        private void bezaras_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void torles_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".csv")
            {
                MessageBox.Show("Csak .xlsx és .xlsm fájllal működik!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
            {
                if (fileMethods.IsFileLocked(Properties.Settings.Default.ExcelFajlHelye) == false)
                {
                    torlesFolyamatban.Visible = true;
                    torlesFolyamatban.BringToFront();

                    Excel.Workbook xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlHelye);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[Properties.Settings.Default.oldalszam + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = excelApp.GetMinimalUsedRangeAddress(xlWorksheet);
                    int totalColumns = xlRange.Columns.Count;

                    int szam = kivSor;

                    Excel.Range delRange = xlWorksheet.Rows[szam];
                    delRange.EntireRow.Delete(Type.Missing);

                    for (int i = szam; i < totalRows; i++)
                    {
                        xlWorksheet.Cells[i, 1].Value = i - 1;
                    }

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
                    fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);

                    torlesFolyamatban.Visible = false;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nem elérhető a fájl. Zárja be a szerkesztés miatt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
