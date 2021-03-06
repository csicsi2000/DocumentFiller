using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace WindowsFormsApp_autósiskola
{
    public class fileMethods
    {
        public static void InsertLineInFile(string path, string line, int position)
        {

            string[] lines = File.ReadAllLines(path, Encoding.GetEncoding(path));

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < position; i++)
                {
                    writer.WriteLine(lines[i]);
                }
                string[] sorelemek = lines[position].Split(';');
                for (int i = 0; i < lines.Length -1; i++)
                {
                    writer.Write(sorelemek[i]);
                }
                writer.WriteLine(line);
                for (int i = position; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }
        public static bool IsFileLocked(string file)
        {
            try
            {
                using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Nem elérhető a fájl. Zárja be a szerkesztés miatt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public static void FajlOlvasas()
        {
            if (Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye) == ".xlsx")
            {
                Properties.Settings.Default.ExcelFajlMasolata = System.AppDomain.CurrentDomain.BaseDirectory + "\\ExcelMasolat.xlsx";

                using (var from = File.Open(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var to = File.OpenWrite(Properties.Settings.Default.ExcelFajlMasolata))
                {
                    from.CopyTo(to);
                    to.Dispose();
                    from.Dispose();
                }
            }
        }
        public static void DisposeExcelInstance(Excel.Application app, Excel.Workbooks workBooks, Excel._Worksheet workSheet)
        {
            app.DisplayAlerts = false;
            workBooks.Close();
            app.Quit();
            if (workSheet != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
            if (workBooks != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBooks);
            if (app != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            workSheet = null;
            workBooks = null;
            app = null;
            GC.Collect();
        }
        public static void DisposeExcelInstance(Excel.Application app, Excel.Workbooks workBooks)
        {
            app.DisplayAlerts = false;
            workBooks.Close();
            app.Quit();
            if (workBooks != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBooks);
            if (app != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            workBooks = null;
            app = null;
            GC.Collect();
        }
    }
}
