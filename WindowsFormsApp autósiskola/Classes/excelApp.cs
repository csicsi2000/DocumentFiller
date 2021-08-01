using System;
using Excel = Microsoft.Office.Interop.Excel;
using WindowsFormsApp_autósiskola.Classes;


namespace WindowsFormsApp_autósiskola
{
    class excelApp
    {
        public Excel.Application xlApp;
        public Excel.Workbooks xlWorkbooks;
        public excelApp()
        {
            xlApp = StartExcel();
            xlWorkbooks = xlApp.Workbooks;
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
            /*
            bool excelSiker = false;
            while (!excelSiker)
            {
                try
                {
                    instance.Visible = false;
                    excelSiker = true;
                }
                catch
                {

                }
            }
            */
            instance.Visible = false;

            return instance;
        }
        public static int GetMinimalUsedRangeAddress(Excel.Worksheet sheet)
        {
            int rowMax = 0;
            try
            {
                Excel.Range usedRange = sheet.UsedRange;
                Excel.Range lastCell = usedRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                int lastRow = lastCell.Row;
                int lastCol = lastCell.Column;

                int rr = usedRange.Rows.Count;
                int cc = usedRange.Columns.Count;
                for (int r = 1; r <= rr; r++)
                {
                    Excel.Range cell = usedRange.Cells[r, 1] as Excel.Range;
                    if (cell != null && cell.Value != null && !String.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        if (cell.Row > rowMax)
                            rowMax = cell.Row;
                    }
                    MRCO(cell);
                }

                MRCO(lastCell);
                MRCO(usedRange);
            }
            catch (Exception)
            {
                
            }
            return rowMax; // caller should test return for String.Empty
        }

        /*
        public static string Cells2Address(int row1, int col1, int row2, int col2)
        {
            return ColNum2Letter(col1) + row1.ToString() + ":" + ColNum2Letter(col2) + row2.ToString();
        }


        public static string ColNum2Letter(int colNum)
        {
            if (colNum <= 26)
                return ((char)(colNum + 64)).ToString();

            colNum--; //decrement to put value on zero based index
            return ColNum2Letter(colNum / 26) + ColNum2Letter((colNum % 26) + 1);
        }
        */

        public static void MRCO(object obj)
        {
            if (obj == null) { return; }
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch
            {

            }
            finally
            {
                obj = null;
            }
        }
    }
}
