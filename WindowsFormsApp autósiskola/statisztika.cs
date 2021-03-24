using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp_autósiskola
{
    public partial class statisztika : UserControl
    {
        Excel.Workbooks xlWorkbooks;
        string adatTipus;
        public statisztika()
        {
            InitializeComponent();
        }
        public void books(Excel.Workbooks books)
        {
            xlWorkbooks = books;
        }
        public void adatokListazas(string sorszam, string excelHelye)
        {
            if (excelHelye == "" || excelHelye == null)
            {
                MessageBox.Show("Válaszd ki az olvasni kívánt excel fájlt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            bool elso = true;

            fileMethods.FajlOlvasas();
            List<string> adatTipusok = new List<string>();
            List<string> sorszamok = new List<string>();

            if (Properties.Settings.Default.ExcelFajlHelye != null && sorszam != null)
            {
                if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".csv")
                {
                    try
                    {
                        var fs = new FileStream(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using (var Olvas = new StreamReader(fs, Encoding.Default))
                        {

                            for (int i = 0; i <= (Convert.ToInt32(sorszam)); i++)
                            {
                                string sor = Olvas.ReadLine();
                                if (sor == null)
                                {
                                    MessageBox.Show("Üres a fájl", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.Visible = false;
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
                            }

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nem található a kiválasztott fájl.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Visible = false;
                        return;
                    }
                }

                else if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
                {
                    fileMethods.FajlOlvasas();

                    var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                    Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[Properties.Settings.Default.oldalszam + 1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;
                    int totalRows = excelApp.GetMinimalUsedRangeAddress(xlWorksheet);
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
                    fileMethods.DisposeExcelInstance(xlWorkbook);
                }

                for (int i = 0; i < adatTipusok.Count - 2; i++)
                {
                    var index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = adatTipusok[i];
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Üres a fájl!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Visible = false;
                    return;
                }
            }
            this.BringToFront();
            this.Show();
            return;
        }

        private void statList_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Válassz adattípust!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            statList.Enabled = false;
            int index = dataGridView1.CurrentCell.RowIndex;
            adatTipus = Convert.ToString(dataGridView1.CurrentCell.Value);

            statisztikak.Rows.Clear();
            dataGridView1.Refresh();

            List<string> adatok = new List<string>();
            List<double> db = new List<double>();
            adatok.Add("Hiányos adat");
            db.Add(0);
            double totalRows = 0;

            if (fileMethods.isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
            {
                var xlWorkbook = xlWorkbooks.Open(Properties.Settings.Default.ExcelFajlMasolata);
                Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[Properties.Settings.Default.oldalszam + 1];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                totalRows = excelApp.GetMinimalUsedRangeAddress(xlWorksheet);
                int totalColumns = xlRange.Columns.Count-1;

                for (int i = 2; i < totalRows; i++)
                {
                    bool vanE = false;
                    string data = Convert.ToString(xlWorksheet.Cells[i, index + 1].Text);
                    if (data == null || data == "")
                    {
                        db[0]++;
                        continue;
                    }
                    for (int j = 0; j < adatok.Count; j++)
                    {
                        if (data == adatok[j])
                        {
                            db[j]++;
                            vanE = true;
                            break;
                        }
                    }
                    if (vanE == false)
                    {
                        adatok.Add(data);
                        db.Add(1);
                    }
                }
                totalRows = totalRows - 1;
                excelApp.MRCO(xlWorkbook);
                excelApp.MRCO(xlWorksheet);
            }
            if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".csv") 
            {
                StreamReader olvas = new StreamReader(Properties.Settings.Default.ExcelFajlHelye, Encoding.Default);
                string fejlec = olvas.ReadLine();
                while (!olvas.EndOfStream)
                {
                    totalRows++;
                    string sor = olvas.ReadLine();
                    string[] sorelemek = sor.Split(';');
                    string data = sorelemek[index];

                    bool vanE = false;
                    if (data == null || data == "")
                    {
                        db[0]++;
                        continue;
                    }
                    for (int j = 0; j < adatok.Count; j++)
                    {
                        if (data == adatok[j])
                        {
                            db[j]++;
                            vanE = true;
                            break;
                        }
                    }
                    if (vanE == false)
                    {
                        adatok.Add(data);
                        db.Add(1);
                    }
                }
            }
            List<adatDB> adatLista = new List<adatDB>();

            for (int i = 1; i < adatok.Count; i++)
            {
                adatLista.Add(new adatDB(adatok[i], db[i]));
            }
            adatLista = adatLista.OrderByDescending(item => item.db).ToList();
            for(int i = 0; i < adatLista.Count; i++)
            {
                int row = statisztikak.Rows.Add();
                statisztikak.Rows[row].Cells[0].Value = adatLista[i].adat;
                statisztikak.Rows[row].Cells[1].Value = adatLista[i].db;

                double szamitas = (adatLista[i].db / totalRows) * 100d;
                double szazalek = Math.Round(szamitas, 2);
                statisztikak.Rows[row].Cells[2].Value = szazalek+ "%";
            }
            int utolsoSor = statisztikak.Rows.Add();

            statisztikak.Rows[utolsoSor].Cells[0].Value = adatok[0];
            statisztikak.Rows[utolsoSor].Cells[1].Value = db[0];

            double sz = (db[0] / totalRows) * 100d;
            double er = Math.Round(sz, 2);
            statisztikak.Rows[utolsoSor].Cells[2].Value = er + "%";

            statList.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application userApp = new Excel.Application();
            var workbooks = userApp.Workbooks;
            Excel.Workbook workbook = workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = workbook.ActiveSheet;
            Excel.Range xlRange = worksheet.UsedRange;

            worksheet.Name = "statisztika";

            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 3]].Merge();
            worksheet.Cells[1, 1] = "Statisztika";
            worksheet.Cells[1, 1].Font.Size = 15;
            worksheet.Columns[1].ColumnWidth = 25;
            worksheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[2, 1] = "Adat";
            worksheet.Cells[2, 2] = "Darabszám";
            worksheet.Cells[2, 3] = "Százalék";


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < statisztikak.Rows.Count; j++)
                {
                    worksheet.Cells[j+2, i+1] = statisztikak.Rows[j].Cells[i].Value;
                }
            }
            userApp.Visible = true;
        }
    } 
}
