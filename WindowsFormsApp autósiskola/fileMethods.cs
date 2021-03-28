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
        
        public static bool isExcelComptaible(string fajlnev)
        {
            bool isIt = false;
            if (Path.GetExtension(fajlnev) == ".xlsx"  || Path.GetExtension(fajlnev) == ".xlsm")
            {
                isIt = true;
            }
            return isIt;
        }
        public static bool IsFileLocked(string file)
        {
            try
            {
                using (Stream stream = new FileStream(file, FileMode.Open))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true;
            }
            return false;
        }
        public static void FajlOlvasas()
        {
            if (isExcelComptaible(Properties.Settings.Default.ExcelFajlHelye))
            {
                File.Delete(Properties.Settings.Default.ExcelFajlMasolata);
                Properties.Settings.Default.ExcelFajlMasolata = System.AppDomain.CurrentDomain.BaseDirectory + "ExcelMasolat" + Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye);
                string hely = Properties.Settings.Default.ExcelFajlMasolata;
                Properties.Settings.Default.Save();

                using (var from = new FileStream(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var to = new FileStream(Properties.Settings.Default.ExcelFajlMasolata, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    from.CopyTo(to);
                }
            }
        }
        public static void DisposeExcelInstance(Excel.Workbook workBook)
        {
            try
            {
                workBook.Close();
            }
            catch { }
            if (workBook != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBook);
            workBook = null;
            GC.Collect();
        }
        public static void DisposeExcelInstance(Excel.Workbook workBook, Excel._Worksheet workSheet)
        {
            workBook.Close();
            if (workSheet != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
            if (workBook != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBook);
            workSheet = null;
            workBook = null;
            GC.Collect();
        }
        public static void DisposeExcelInstance(Excel._Workbook workBook, Excel._Worksheet workSheet)
        {
            workBook.Close();
            if (workSheet != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
            if (workBook != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBook);
            workSheet = null;
            workBook = null;
            GC.Collect();
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
            try
            {
                app.DisplayAlerts = false;
                workBooks.Close();
                app.Quit();
            }
            catch 
            {

            }
            
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
