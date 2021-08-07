using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_autósiskola.GoogleSheet;

namespace WindowsFormsApp_autósiskola.UserControls
{
    public partial class GoogleSheet : UserControl
    {
        private SheetAccess sheetAccess;
        public GoogleSheet()
        {
            InitializeComponent();
        }
        public void GiveAccess(SheetAccess access)
        {
            sheetAccess = access;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(serviceEmail.Text);
        }

        private void kereses_Click(object sender, EventArgs e)
        {
            if (!sheetAccess.SaveSpreadsheetID(sheetLink.Text))
            {
                MessageBox.Show("Nem sikerült kinyerni az ID-t!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
