using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp_autósiskola.Classes
{
    class ExcelRead
    {
        public static bool getExcelData(Excel.Workbooks xlWorkbooks, string sorszam, out tanulo kivalasztott)
        {
            kivalasztott = new tanulo();
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
                                        kivalasztott = new tanulo(Sor);
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
                                        kivalasztott = new tanulo(sor);
                                        count++;
                                        sorszamok.Add(Sorelemek[0]);
                                    }
                                }
                                if (count > 1)
                                {
                                    string sorString = String.Join(", ", sorszamok.ToArray());
                                    string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.\n(Azonos nevűek sorszáma: " + sorString + ")";
                                    MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        return false;
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
                        kivalasztott = new tanulo(sb.ToString());
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
                                kivalasztott = new tanulo(sb.ToString());
                                count++;
                                sorszamok.Add(Convert.ToString(xlWorksheet.Cells[Row, 1].Text));
                            }
                        }
                        if (count > 1)
                        {
                            string sorString = String.Join(", ", sorszamok.ToArray());
                            string uzenet = "Több ilyen nevű tanuló is van! Használd a sorszámát.\n(Azonos nevűek sorszáma: " + sorString + ")";
                            MessageBox.Show(uzenet, "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        if (count == 0)
                        {
                            MessageBox.Show("Nincs találat az adott excel táblázatban. Ellenőrizd a beírt nevet!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    fileMethods.DisposeExcelInstance(xlWorkbook, xlWorksheet);
                }
                return true;
            }
            return false;
        }
    }
}
