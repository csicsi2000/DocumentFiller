
namespace WindowsFormsApp_autósiskola
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.SorSzam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kereses = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.excelHelye = new System.Windows.Forms.TextBox();
            this.dokumentumKeszites = new System.Windows.Forms.Button();
            this.mentesHelye = new System.Windows.Forms.TextBox();
            this.mentesHelyeKereses = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.FolderBrowserDialog();
            this.mentettFajlNeve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sorSzamValasztas = new System.Windows.Forms.Button();
            this.nyissaEMeg = new System.Windows.Forms.CheckBox();
            this.ExcelOldalNevek = new System.Windows.Forms.ListBox();
            this.ekezetek = new System.Windows.Forms.CheckBox();
            this.szokoz = new System.Windows.Forms.CheckBox();
            this.frissites = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.iskolaCim = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.iskolaNev = new System.Windows.Forms.TextBox();
            this.iskolaAzonosito = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ujTanuloIdo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.honapBetu = new System.Windows.Forms.CheckBox();
            this.bezaras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kiallitasiHely = new System.Windows.Forms.TextBox();
            this.beallitasok = new System.Windows.Forms.Button();
            this.helyIdo = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.ujTanulo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mehet = new System.Windows.Forms.Label();
            this.valasztFolyamatban = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.torles = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mentes = new System.Windows.Forms.Button();
            this.megjegyzesek = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentesFolyamatban = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.torlesFolyamatban = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.valasztFolyamatban.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mentesFolyamatban.SuspendLayout();
            this.torlesFolyamatban.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(77, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiválasztott tanuló sorszáma vagy neve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SorSzam
            // 
            this.SorSzam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SorSzam.BackColor = System.Drawing.Color.Black;
            this.SorSzam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SorSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SorSzam.ForeColor = System.Drawing.Color.White;
            this.SorSzam.Location = new System.Drawing.Point(159, 558);
            this.SorSzam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SorSzam.Name = "SorSzam";
            this.SorSzam.Size = new System.Drawing.Size(307, 26);
            this.SorSzam.TabIndex = 1;
            this.SorSzam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SorSzam.TextChanged += new System.EventHandler(this.SorSzam_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(153, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Excel fájl elérési útvonala";
            // 
            // kereses
            // 
            this.kereses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kereses.BackColor = System.Drawing.Color.Black;
            this.kereses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kereses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.kereses.ForeColor = System.Drawing.Color.Silver;
            this.kereses.Location = new System.Drawing.Point(212, 206);
            this.kereses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(208, 68);
            this.kereses.TabIndex = 5;
            this.kereses.Text = "Keresés";
            this.kereses.UseVisualStyleBackColor = false;
            this.kereses.Click += new System.EventHandler(this.excelKereses_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            this.openFD.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // excelHelye
            // 
            this.excelHelye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.excelHelye.BackColor = System.Drawing.Color.Black;
            this.excelHelye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.excelHelye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.excelHelye.ForeColor = System.Drawing.Color.White;
            this.excelHelye.Location = new System.Drawing.Point(95, 160);
            this.excelHelye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excelHelye.Name = "excelHelye";
            this.excelHelye.ReadOnly = true;
            this.excelHelye.Size = new System.Drawing.Size(437, 26);
            this.excelHelye.TabIndex = 6;
            this.excelHelye.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dokumentumKeszites
            // 
            this.dokumentumKeszites.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dokumentumKeszites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dokumentumKeszites.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dokumentumKeszites.ForeColor = System.Drawing.Color.Silver;
            this.dokumentumKeszites.Location = new System.Drawing.Point(780, 603);
            this.dokumentumKeszites.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dokumentumKeszites.Name = "dokumentumKeszites";
            this.dokumentumKeszites.Size = new System.Drawing.Size(212, 68);
            this.dokumentumKeszites.TabIndex = 7;
            this.dokumentumKeszites.Text = "Mehet";
            this.dokumentumKeszites.UseVisualStyleBackColor = true;
            this.dokumentumKeszites.EnabledChanged += new System.EventHandler(this.dokumentumKeszites_EnabledChanged);
            this.dokumentumKeszites.Click += new System.EventHandler(this.button1_Click);
            // 
            // mentesHelye
            // 
            this.mentesHelye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentesHelye.BackColor = System.Drawing.Color.Black;
            this.mentesHelye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mentesHelye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mentesHelye.ForeColor = System.Drawing.Color.White;
            this.mentesHelye.Location = new System.Drawing.Point(664, 160);
            this.mentesHelye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mentesHelye.Name = "mentesHelye";
            this.mentesHelye.ReadOnly = true;
            this.mentesHelye.Size = new System.Drawing.Size(447, 26);
            this.mentesHelye.TabIndex = 7;
            this.mentesHelye.TextChanged += new System.EventHandler(this.mentesHelye_TextChanged);
            // 
            // mentesHelyeKereses
            // 
            this.mentesHelyeKereses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentesHelyeKereses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesHelyeKereses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.mentesHelyeKereses.ForeColor = System.Drawing.Color.Silver;
            this.mentesHelyeKereses.Location = new System.Drawing.Point(780, 206);
            this.mentesHelyeKereses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mentesHelyeKereses.Name = "mentesHelyeKereses";
            this.mentesHelyeKereses.Size = new System.Drawing.Size(212, 68);
            this.mentesHelyeKereses.TabIndex = 4;
            this.mentesHelyeKereses.Text = "Keresés";
            this.mentesHelyeKereses.UseVisualStyleBackColor = true;
            this.mentesHelyeKereses.Click += new System.EventHandler(this.mentesHelyeKereses_Click);
            // 
            // filepath
            // 
            this.filepath.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // mentettFajlNeve
            // 
            this.mentettFajlNeve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentettFajlNeve.BackColor = System.Drawing.Color.Black;
            this.mentettFajlNeve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mentettFajlNeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mentettFajlNeve.ForeColor = System.Drawing.Color.White;
            this.mentettFajlNeve.Location = new System.Drawing.Point(731, 558);
            this.mentettFajlNeve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mentettFajlNeve.Name = "mentettFajlNeve";
            this.mentettFajlNeve.Size = new System.Drawing.Size(306, 26);
            this.mentettFajlNeve.TabIndex = 9;
            this.mentettFajlNeve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(721, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Létrehozni kívánt fájlneve";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sorSzamValasztas
            // 
            this.sorSzamValasztas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sorSzamValasztas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sorSzamValasztas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.sorSzamValasztas.ForeColor = System.Drawing.Color.Silver;
            this.sorSzamValasztas.Location = new System.Drawing.Point(212, 603);
            this.sorSzamValasztas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sorSzamValasztas.Name = "sorSzamValasztas";
            this.sorSzamValasztas.Size = new System.Drawing.Size(208, 64);
            this.sorSzamValasztas.TabIndex = 11;
            this.sorSzamValasztas.Text = "Választ";
            this.sorSzamValasztas.UseVisualStyleBackColor = true;
            this.sorSzamValasztas.Click += new System.EventHandler(this.valaszt_Click_1);
            // 
            // nyissaEMeg
            // 
            this.nyissaEMeg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nyissaEMeg.AutoSize = true;
            this.nyissaEMeg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.nyissaEMeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.nyissaEMeg.Location = new System.Drawing.Point(731, 686);
            this.nyissaEMeg.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nyissaEMeg.Name = "nyissaEMeg";
            this.nyissaEMeg.Size = new System.Drawing.Size(298, 27);
            this.nyissaEMeg.TabIndex = 14;
            this.nyissaEMeg.Text = "Nyissa meg a létrehozott fájlt";
            this.nyissaEMeg.UseVisualStyleBackColor = true;
            this.nyissaEMeg.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ExcelOldalNevek
            // 
            this.ExcelOldalNevek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExcelOldalNevek.BackColor = System.Drawing.Color.Silver;
            this.ExcelOldalNevek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExcelOldalNevek.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ExcelOldalNevek.FormattingEnabled = true;
            this.ExcelOldalNevek.ItemHeight = 22;
            this.ExcelOldalNevek.Location = new System.Drawing.Point(163, 287);
            this.ExcelOldalNevek.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ExcelOldalNevek.Name = "ExcelOldalNevek";
            this.ExcelOldalNevek.Size = new System.Drawing.Size(300, 154);
            this.ExcelOldalNevek.TabIndex = 15;
            this.ExcelOldalNevek.Visible = false;
            this.ExcelOldalNevek.SelectedIndexChanged += new System.EventHandler(this.ExcelOldal_SelectedIndexChanged);
            // 
            // ekezetek
            // 
            this.ekezetek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ekezetek.AutoSize = true;
            this.ekezetek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ekezetek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ekezetek.Location = new System.Drawing.Point(165, 686);
            this.ekezetek.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ekezetek.Name = "ekezetek";
            this.ekezetek.Size = new System.Drawing.Size(286, 27);
            this.ekezetek.TabIndex = 16;
            this.ekezetek.Text = "Számítsanak-e az ékezetek";
            this.ekezetek.UseVisualStyleBackColor = true;
            this.ekezetek.CheckedChanged += new System.EventHandler(this.ekezetek_CheckedChanged);
            // 
            // szokoz
            // 
            this.szokoz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szokoz.AutoSize = true;
            this.szokoz.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.szokoz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.szokoz.Location = new System.Drawing.Point(165, 722);
            this.szokoz.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.szokoz.Name = "szokoz";
            this.szokoz.Size = new System.Drawing.Size(301, 27);
            this.szokoz.TabIndex = 17;
            this.szokoz.Text = "Számítson-e a szóköz, kötőjel";
            this.szokoz.UseVisualStyleBackColor = true;
            this.szokoz.CheckedChanged += new System.EventHandler(this.szokoz_CheckedChanged);
            // 
            // frissites
            // 
            this.frissites.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frissites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frissites.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.frissites.ForeColor = System.Drawing.Color.Silver;
            this.frissites.Location = new System.Drawing.Point(480, 345);
            this.frissites.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.frissites.Name = "frissites";
            this.frissites.Size = new System.Drawing.Size(96, 52);
            this.frissites.TabIndex = 18;
            this.frissites.Text = "lista frissítés";
            this.frissites.UseVisualStyleBackColor = true;
            this.frissites.Click += new System.EventHandler(this.frissites_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label4.Location = new System.Drawing.Point(796, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mentés helye";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.iskolaCim);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.iskolaNev);
            this.panel1.Controls.Add(this.iskolaAzonosito);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.ujTanuloIdo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.honapBetu);
            this.panel1.Controls.Add(this.bezaras);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.kiallitasiHely);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 473);
            this.panel1.TabIndex = 20;
            this.panel1.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label17.Location = new System.Drawing.Point(556, 33);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 28);
            this.label17.TabIndex = 14;
            this.label17.Text = "Iskola adatai";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iskolaCim
            // 
            this.iskolaCim.BackColor = System.Drawing.Color.Black;
            this.iskolaCim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iskolaCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.iskolaCim.ForeColor = System.Drawing.Color.White;
            this.iskolaCim.Location = new System.Drawing.Point(489, 347);
            this.iskolaCim.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.iskolaCim.Name = "iskolaCim";
            this.iskolaCim.Size = new System.Drawing.Size(321, 26);
            this.iskolaCim.TabIndex = 13;
            this.iskolaCim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iskolaCim.TextChanged += new System.EventHandler(this.iskolaCim_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label16.Location = new System.Drawing.Point(621, 303);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 23);
            this.label16.TabIndex = 12;
            this.label16.Text = "Cím";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iskolaNev
            // 
            this.iskolaNev.BackColor = System.Drawing.Color.Black;
            this.iskolaNev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iskolaNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.iskolaNev.ForeColor = System.Drawing.Color.White;
            this.iskolaNev.Location = new System.Drawing.Point(489, 235);
            this.iskolaNev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.iskolaNev.Name = "iskolaNev";
            this.iskolaNev.Size = new System.Drawing.Size(321, 26);
            this.iskolaNev.TabIndex = 11;
            this.iskolaNev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iskolaNev.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // iskolaAzonosito
            // 
            this.iskolaAzonosito.BackColor = System.Drawing.Color.Black;
            this.iskolaAzonosito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iskolaAzonosito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.iskolaAzonosito.ForeColor = System.Drawing.Color.White;
            this.iskolaAzonosito.Location = new System.Drawing.Point(489, 129);
            this.iskolaAzonosito.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.iskolaAzonosito.Name = "iskolaAzonosito";
            this.iskolaAzonosito.Size = new System.Drawing.Size(321, 26);
            this.iskolaAzonosito.TabIndex = 10;
            this.iskolaAzonosito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iskolaAzonosito.TextChanged += new System.EventHandler(this.iskolaAzonosito_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label15.Location = new System.Drawing.Point(623, 194);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 23);
            this.label15.TabIndex = 8;
            this.label15.Text = "Név\r\n";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label14.Location = new System.Drawing.Point(595, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Azonosító";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ujTanuloIdo
            // 
            this.ujTanuloIdo.AutoSize = true;
            this.ujTanuloIdo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ujTanuloIdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ujTanuloIdo.Location = new System.Drawing.Point(108, 324);
            this.ujTanuloIdo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ujTanuloIdo.Name = "ujTanuloIdo";
            this.ujTanuloIdo.Size = new System.Drawing.Size(236, 23);
            this.ujTanuloIdo.TabIndex = 6;
            this.ujTanuloIdo.Text = "Új tanuló bekerülési ideje";
            this.ujTanuloIdo.UseVisualStyleBackColor = true;
            this.ujTanuloIdo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label11.Location = new System.Drawing.Point(131, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Excel sablon típusa\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Főút Autósiskola",
            "ABC Autósiskola"});
            this.comboBox1.Location = new System.Drawing.Point(119, 271);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 29);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // honapBetu
            // 
            this.honapBetu.AutoSize = true;
            this.honapBetu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.honapBetu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.honapBetu.Location = new System.Drawing.Point(129, 139);
            this.honapBetu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.honapBetu.Name = "honapBetu";
            this.honapBetu.Size = new System.Drawing.Size(203, 23);
            this.honapBetu.TabIndex = 3;
            this.honapBetu.Text = "Dátum hónap névvel";
            this.honapBetu.UseVisualStyleBackColor = true;
            this.honapBetu.CheckedChanged += new System.EventHandler(this.honapBetu_CheckedChanged);
            // 
            // bezaras
            // 
            this.bezaras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bezaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bezaras.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bezaras.Location = new System.Drawing.Point(725, 405);
            this.bezaras.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.bezaras.Name = "bezaras";
            this.bezaras.Size = new System.Drawing.Size(131, 48);
            this.bezaras.TabIndex = 2;
            this.bezaras.Text = "Bezárás";
            this.bezaras.UseVisualStyleBackColor = true;
            this.bezaras.Click += new System.EventHandler(this.bezaras_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label5.Location = new System.Drawing.Point(64, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dokumentum kiállításának helye";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // kiallitasiHely
            // 
            this.kiallitasiHely.BackColor = System.Drawing.Color.Black;
            this.kiallitasiHely.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kiallitasiHely.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kiallitasiHely.ForeColor = System.Drawing.Color.White;
            this.kiallitasiHely.Location = new System.Drawing.Point(65, 84);
            this.kiallitasiHely.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.kiallitasiHely.Name = "kiallitasiHely";
            this.kiallitasiHely.Size = new System.Drawing.Size(321, 26);
            this.kiallitasiHely.TabIndex = 0;
            this.kiallitasiHely.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kiallitasiHely.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // beallitasok
            // 
            this.beallitasok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.beallitasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beallitasok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beallitasok.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.beallitasok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.beallitasok.Image = ((System.Drawing.Image)(resources.GetObject("beallitasok.Image")));
            this.beallitasok.Location = new System.Drawing.Point(-1, 38);
            this.beallitasok.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.beallitasok.Name = "beallitasok";
            this.beallitasok.Size = new System.Drawing.Size(32, 36);
            this.beallitasok.TabIndex = 21;
            this.beallitasok.UseVisualStyleBackColor = false;
            this.beallitasok.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // helyIdo
            // 
            this.helyIdo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helyIdo.AutoSize = true;
            this.helyIdo.BackColor = System.Drawing.Color.Black;
            this.helyIdo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.helyIdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.helyIdo.Location = new System.Drawing.Point(731, 722);
            this.helyIdo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.helyIdo.Name = "helyIdo";
            this.helyIdo.Size = new System.Drawing.Size(323, 27);
            this.helyIdo.TabIndex = 22;
            this.helyIdo.Text = "Hely és aktuális dátum kitöltése\r\n";
            this.helyIdo.UseVisualStyleBackColor = false;
            this.helyIdo.CheckedChanged += new System.EventHandler(this.helyIdo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 39);
            this.panel2.TabIndex = 23;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label6_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Képzési igazolás kitöltő";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(1081, -7);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.Location = new System.Drawing.Point(1128, -7);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.ujTanulo);
            this.panel3.Controls.Add(this.frissites);
            this.panel3.Controls.Add(this.beallitasok);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.helyIdo);
            this.panel3.Controls.Add(this.ExcelOldalNevek);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.SorSzam);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.mentesHelye);
            this.panel3.Controls.Add(this.kereses);
            this.panel3.Controls.Add(this.excelHelye);
            this.panel3.Controls.Add(this.mentesHelyeKereses);
            this.panel3.Controls.Add(this.szokoz);
            this.panel3.Controls.Add(this.mentettFajlNeve);
            this.panel3.Controls.Add(this.ekezetek);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sorSzamValasztas);
            this.panel3.Controls.Add(this.nyissaEMeg);
            this.panel3.Controls.Add(this.dokumentumKeszites);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.valasztFolyamatban);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 815);
            this.panel3.TabIndex = 24;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.button5.Location = new System.Drawing.Point(228, 38);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 36);
            this.button5.TabIndex = 29;
            this.button5.Text = "Excel sablon fájl";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ujTanulo
            // 
            this.ujTanulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ujTanulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujTanulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ujTanulo.Location = new System.Drawing.Point(29, 38);
            this.ujTanulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ujTanulo.Name = "ujTanulo";
            this.ujTanulo.Size = new System.Drawing.Size(200, 36);
            this.ujTanulo.TabIndex = 28;
            this.ujTanulo.Text = "Új tanuló felvétele";
            this.ujTanulo.UseVisualStyleBackColor = true;
            this.ujTanulo.Click += new System.EventHandler(this.ujTanulo_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(452, 603);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 64);
            this.button3.TabIndex = 26;
            this.button3.Text = "Adat ellenőrzés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(468, 340);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 64);
            this.panel5.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(4, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Folyamatban...";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(431, 592);
            this.panel7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(181, 87);
            this.panel7.TabIndex = 25;
            this.panel7.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(13, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Folyamatban...";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.mehet);
            this.panel4.Location = new System.Drawing.Point(780, 603);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 69);
            this.panel4.TabIndex = 24;
            // 
            // mehet
            // 
            this.mehet.AutoSize = true;
            this.mehet.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.mehet.ForeColor = System.Drawing.Color.Silver;
            this.mehet.Location = new System.Drawing.Point(31, 21);
            this.mehet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mehet.Name = "mehet";
            this.mehet.Size = new System.Drawing.Size(148, 22);
            this.mehet.TabIndex = 23;
            this.mehet.Text = "Folyamatban...";
            this.mehet.Click += new System.EventHandler(this.mehet_Click);
            // 
            // valasztFolyamatban
            // 
            this.valasztFolyamatban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valasztFolyamatban.Controls.Add(this.label13);
            this.valasztFolyamatban.Location = new System.Drawing.Point(203, 596);
            this.valasztFolyamatban.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.valasztFolyamatban.Name = "valasztFolyamatban";
            this.valasztFolyamatban.Size = new System.Drawing.Size(220, 78);
            this.valasztFolyamatban.TabIndex = 28;
            this.valasztFolyamatban.Visible = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(32, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = "Folyamatban...";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.torles);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.mentes);
            this.panel6.Controls.Add(this.megjegyzesek);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.mentesFolyamatban);
            this.panel6.Controls.Add(this.torlesFolyamatban);
            this.panel6.Location = new System.Drawing.Point(0, 75);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1173, 737);
            this.panel6.TabIndex = 27;
            // 
            // torles
            // 
            this.torles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.torles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torles.ForeColor = System.Drawing.Color.White;
            this.torles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.torles.Location = new System.Drawing.Point(975, 562);
            this.torles.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(156, 60);
            this.torles.TabIndex = 26;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label8.Location = new System.Drawing.Point(724, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Megjegyzések";
            // 
            // mentes
            // 
            this.mentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentes.ForeColor = System.Drawing.Color.White;
            this.mentes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mentes.Location = new System.Drawing.Point(723, 640);
            this.mentes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(145, 60);
            this.mentes.TabIndex = 5;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.szerkesztes_Click);
            // 
            // megjegyzesek
            // 
            this.megjegyzesek.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megjegyzesek.Location = new System.Drawing.Point(723, 38);
            this.megjegyzesek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.megjegyzesek.Multiline = true;
            this.megjegyzesek.Name = "megjegyzesek";
            this.megjegyzesek.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.megjegyzesek.Size = new System.Drawing.Size(407, 506);
            this.megjegyzesek.TabIndex = 6;
            this.megjegyzesek.TextChanged += new System.EventHandler(this.megjegyzesek_TextChanged);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(975, 640);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bezárás";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adatok,
            this.Tanulo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(51, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 692);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // Adatok
            // 
            this.Adatok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Adatok.DefaultCellStyle = dataGridViewCellStyle2;
            this.Adatok.FillWeight = 120F;
            this.Adatok.HeaderText = "Adatok";
            this.Adatok.MinimumWidth = 6;
            this.Adatok.Name = "Adatok";
            this.Adatok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Adatok.Width = 160;
            // 
            // Tanulo
            // 
            this.Tanulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tanulo.FillWeight = 80F;
            this.Tanulo.HeaderText = "Tanuló";
            this.Tanulo.MinimumWidth = 6;
            this.Tanulo.Name = "Tanulo";
            this.Tanulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mentesFolyamatban
            // 
            this.mentesFolyamatban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentesFolyamatban.Controls.Add(this.label10);
            this.mentesFolyamatban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesFolyamatban.Location = new System.Drawing.Point(715, 640);
            this.mentesFolyamatban.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mentesFolyamatban.Name = "mentesFolyamatban";
            this.mentesFolyamatban.Size = new System.Drawing.Size(163, 60);
            this.mentesFolyamatban.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(5, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Folyamatban...";
            // 
            // torlesFolyamatban
            // 
            this.torlesFolyamatban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.torlesFolyamatban.Controls.Add(this.label12);
            this.torlesFolyamatban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torlesFolyamatban.Location = new System.Drawing.Point(971, 562);
            this.torlesFolyamatban.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.torlesFolyamatban.Name = "torlesFolyamatban";
            this.torlesFolyamatban.Size = new System.Drawing.Size(163, 60);
            this.torlesFolyamatban.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(5, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Folyamatban...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1176, 815);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Képzési igazolás kitöltő";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.valasztFolyamatban.ResumeLayout(false);
            this.valasztFolyamatban.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mentesFolyamatban.ResumeLayout(false);
            this.mentesFolyamatban.PerformLayout();
            this.torlesFolyamatban.ResumeLayout(false);
            this.torlesFolyamatban.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kereses;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button dokumentumKeszites;
        private System.Windows.Forms.Button mentesHelyeKereses;
        private System.Windows.Forms.FolderBrowserDialog filepath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sorSzamValasztas;
        private System.Windows.Forms.Button frissites;
        public System.Windows.Forms.TextBox SorSzam;
        public System.Windows.Forms.TextBox excelHelye;
        public System.Windows.Forms.TextBox mentesHelye;
        public System.Windows.Forms.TextBox mentettFajlNeve;
        public System.Windows.Forms.CheckBox nyissaEMeg;
        public System.Windows.Forms.ListBox ExcelOldalNevek;
        public System.Windows.Forms.CheckBox ekezetek;
        public System.Windows.Forms.CheckBox szokoz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button beallitasok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kiallitasiHely;
        private System.Windows.Forms.Button bezaras;
        private System.Windows.Forms.CheckBox helyIdo;
        private System.Windows.Forms.CheckBox honapBetu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label mehet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox megjegyzesek;
        private System.Windows.Forms.Button ujTanulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel mentesFolyamatban;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox ujTanuloIdo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel torlesFolyamatban;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel valasztFolyamatban;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox iskolaCim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox iskolaNev;
        private System.Windows.Forms.TextBox iskolaAzonosito;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanulo;
    }
}

