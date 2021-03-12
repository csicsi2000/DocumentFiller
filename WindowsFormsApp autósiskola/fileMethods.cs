﻿using System;
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
                MessageBox.Show("Nem elérhető a fájl. Zárja be a szerkesztés miatt!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
