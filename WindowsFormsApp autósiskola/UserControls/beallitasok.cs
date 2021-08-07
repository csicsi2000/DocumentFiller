using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_autósiskola.UserControls
{
    public partial class beallitasok : UserControl
    {
        public beallitasok()
        {
            InitializeComponent();

            honapBetu.Checked = Properties.Settings.Default.honapBetu;
            ujTanuloIdo.Checked = Properties.Settings.Default.ujTanuloIdo;
            kiallitasiHely.Text = Properties.Settings.Default.kiallitasiHely;
            comboBox1.SelectedIndex = Properties.Settings.Default.comboIndex;
            iskolaAzonosito.Text = Properties.Settings.Default.iskolaAzonosito;
            iskolaNev.Text = Properties.Settings.Default.iskolaNev;
            iskolaCim.Text = Properties.Settings.Default.iskolaCim;
            VersionDisplay.Text = System.Windows.Forms.Application.ProductVersion;

        }

        private void kiallitasiHely_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.kiallitasiHely = kiallitasiHely.Text;
            Properties.Settings.Default.Save();
        }

        private void honapBetu_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.honapBetu = honapBetu.Checked;
            Properties.Settings.Default.Save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.comboIndex = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void bezaras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ujTanuloIdo_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ujTanuloIdo = ujTanuloIdo.Checked;
            Properties.Settings.Default.Save();
        }

        private void iskolaAzonosito_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.iskolaAzonosito = iskolaAzonosito.Text;
            Properties.Settings.Default.Save();
        }

        private void iskolaNev_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.iskolaNev = iskolaNev.Text;
            Properties.Settings.Default.Save();
        }

        private void iskolaCim_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.iskolaCim = iskolaCim.Text;
            Properties.Settings.Default.Save();
        }
    }
}
