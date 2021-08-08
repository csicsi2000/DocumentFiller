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
            sheetLink.Text = Properties.Settings.Default.SheetURL;
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
            if(sheetLink.Text == "" || sheetLink.Text == null)
            {
                MessageBox.Show("Illessze be a Google Sheet URL-jét.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!sheetAccess.SaveSpreadsheetID(sheetLink.Text))
            {
                MessageBox.Show("Nem sikerült kinyerni az ID-t! Ellenőrizze a Google Sheet URL-jét.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
