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
        public statisztika()
        {
            InitializeComponent();
        }
        public void books (Excel.Workbooks books)
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
            int index = dataGridView1.CurrentCell.RowIndex; 

        }
    }
}
