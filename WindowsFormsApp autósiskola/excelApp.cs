using Excel = Microsoft.Office.Interop.Excel;

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
            instance.Visible = false;
            return instance;
        }
    }
}
