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
                if (File.Exists(Properties.Settings.Default.ExcelFajlMasolata)) 
                { 
                    File.Delete(Properties.Settings.Default.ExcelFajlMasolata);
                }
                
                Properties.Settings.Default.ExcelFajlMasolata = System.AppDomain.CurrentDomain.BaseDirectory + "ExcelMasolat" + Path.GetExtension(Properties.Settings.Default.ExcelFajlHelye);
                string hely = Properties.Settings.Default.ExcelFajlMasolata;
                Properties.Settings.Default.Save();

                using (var from = new FileStream(Properties.Settings.Default.ExcelFajlHelye, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var to = new FileStream(Properties.Settings.Default.ExcelFajlMasolata, FileMode.OpenOrCreate))
                {
                    var buffer = new byte[0x10000];
                    int bytes;

                    while((bytes = from.Read(buffer,0,buffer.Length)) > 0)
                    {
                        to.Write(buffer, 0, bytes);
                    }
                    //from.CopyTo(to);
                    //to.Dispose();
                    //from.Dispose();
                }
                GC.Collect();
            }
        }
        public static void DisposeExcelInstance(Excel.Workbook workBooks)
        {
            try
            {
                workBooks.Close();
            }
            catch { }
            if (workBooks != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBooks);
            workBooks = null;
            GC.Collect();
        }
        public static void DisposeExcelInstance(Excel.Workbook workBook, Excel._Worksheet workSheet)
        {
            workBook.Close();
            if (workBook != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workBook);
            if (workSheet != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
            workBook = null;
            workSheet = null;
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
    }
}
