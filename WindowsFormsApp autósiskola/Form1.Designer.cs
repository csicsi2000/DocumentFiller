
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.VersionDisplay = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.fileFormat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DocTipus = new System.Windows.Forms.ComboBox();
            this.SorSzam = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.valasztFolyamatban = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ujTanulo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.fooldal = new System.Windows.Forms.Button();
            this.statNyit = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.staticLoading = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tanuloAdatok1 = new WindowsFormsApp_autósiskola.TanuloAdatok();
            this.statisztika1 = new WindowsFormsApp_autósiskola.statisztika();
            this.loading1 = new WindowsFormsApp_autósiskola.loading();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.valasztFolyamatban.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.staticLoading.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(77, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiválasztott tanuló sorszáma vagy neve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(153, 50);
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
            this.kereses.Location = new System.Drawing.Point(212, 149);
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
            this.excelHelye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.excelHelye.ForeColor = System.Drawing.Color.White;
            this.excelHelye.Location = new System.Drawing.Point(95, 98);
            this.excelHelye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excelHelye.Name = "excelHelye";
            this.excelHelye.ReadOnly = true;
            this.excelHelye.Size = new System.Drawing.Size(437, 29);
            this.excelHelye.TabIndex = 6;
            this.excelHelye.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.excelHelye.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.excelHelye_MouseDoubleClick);
            // 
            // dokumentumKeszites
            // 
            this.dokumentumKeszites.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dokumentumKeszites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dokumentumKeszites.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dokumentumKeszites.ForeColor = System.Drawing.Color.Silver;
            this.dokumentumKeszites.Location = new System.Drawing.Point(780, 543);
            this.dokumentumKeszites.Margin = new System.Windows.Forms.Padding(5);
            this.dokumentumKeszites.Name = "dokumentumKeszites";
            this.dokumentumKeszites.Size = new System.Drawing.Size(212, 68);
            this.dokumentumKeszites.TabIndex = 7;
            this.dokumentumKeszites.Text = "Mehet";
            this.dokumentumKeszites.UseVisualStyleBackColor = true;
            this.dokumentumKeszites.Click += new System.EventHandler(this.button1_Click);
            // 
            // mentesHelye
            // 
            this.mentesHelye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentesHelye.BackColor = System.Drawing.Color.Black;
            this.mentesHelye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mentesHelye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesHelye.ForeColor = System.Drawing.Color.White;
            this.mentesHelye.Location = new System.Drawing.Point(664, 98);
            this.mentesHelye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mentesHelye.Name = "mentesHelye";
            this.mentesHelye.ReadOnly = true;
            this.mentesHelye.Size = new System.Drawing.Size(447, 29);
            this.mentesHelye.TabIndex = 7;
            this.mentesHelye.TextChanged += new System.EventHandler(this.mentesHelye_TextChanged);
            // 
            // mentesHelyeKereses
            // 
            this.mentesHelyeKereses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentesHelyeKereses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesHelyeKereses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.mentesHelyeKereses.ForeColor = System.Drawing.Color.Silver;
            this.mentesHelyeKereses.Location = new System.Drawing.Point(780, 149);
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
            this.mentettFajlNeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentettFajlNeve.ForeColor = System.Drawing.Color.White;
            this.mentettFajlNeve.Location = new System.Drawing.Point(731, 496);
            this.mentettFajlNeve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mentettFajlNeve.Name = "mentettFajlNeve";
            this.mentettFajlNeve.Size = new System.Drawing.Size(306, 29);
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
            this.label3.Location = new System.Drawing.Point(721, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Létrehozni kívánt fájlneve";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sorSzamValasztas
            // 
            this.sorSzamValasztas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sorSzamValasztas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sorSzamValasztas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.sorSzamValasztas.ForeColor = System.Drawing.Color.Silver;
            this.sorSzamValasztas.Location = new System.Drawing.Point(212, 546);
            this.sorSzamValasztas.Margin = new System.Windows.Forms.Padding(5);
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
            this.nyissaEMeg.Location = new System.Drawing.Point(731, 629);
            this.nyissaEMeg.Margin = new System.Windows.Forms.Padding(5);
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
            this.ExcelOldalNevek.Location = new System.Drawing.Point(163, 230);
            this.ExcelOldalNevek.Margin = new System.Windows.Forms.Padding(5);
            this.ExcelOldalNevek.Name = "ExcelOldalNevek";
            this.ExcelOldalNevek.Size = new System.Drawing.Size(307, 110);
            this.ExcelOldalNevek.TabIndex = 15;
            this.ExcelOldalNevek.SelectedIndexChanged += new System.EventHandler(this.ExcelOldal_SelectedIndexChanged);
            // 
            // ekezetek
            // 
            this.ekezetek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ekezetek.AutoSize = true;
            this.ekezetek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ekezetek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ekezetek.Location = new System.Drawing.Point(165, 629);
            this.ekezetek.Margin = new System.Windows.Forms.Padding(5);
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
            this.szokoz.Location = new System.Drawing.Point(165, 666);
            this.szokoz.Margin = new System.Windows.Forms.Padding(5);
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
            this.frissites.Location = new System.Drawing.Point(480, 288);
            this.frissites.Margin = new System.Windows.Forms.Padding(5);
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
            this.label4.Location = new System.Drawing.Point(796, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mentés helye";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VersionDisplay);
            this.panel1.Controls.Add(this.label12);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 473);
            this.panel1.TabIndex = 20;
            this.panel1.Visible = false;
            // 
            // VersionDisplay
            // 
            this.VersionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VersionDisplay.Location = new System.Drawing.Point(115, 431);
            this.VersionDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VersionDisplay.Name = "VersionDisplay";
            this.VersionDisplay.Size = new System.Drawing.Size(137, 21);
            this.VersionDisplay.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(35, 431);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Version:";
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
            this.iskolaCim.Margin = new System.Windows.Forms.Padding(5);
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
            this.iskolaNev.Margin = new System.Windows.Forms.Padding(5);
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
            this.iskolaAzonosito.Margin = new System.Windows.Forms.Padding(5);
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
            this.ujTanuloIdo.Margin = new System.Windows.Forms.Padding(5);
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
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.honapBetu.Margin = new System.Windows.Forms.Padding(5);
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
            // 
            // kiallitasiHely
            // 
            this.kiallitasiHely.BackColor = System.Drawing.Color.Black;
            this.kiallitasiHely.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kiallitasiHely.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.kiallitasiHely.ForeColor = System.Drawing.Color.White;
            this.kiallitasiHely.Location = new System.Drawing.Point(65, 84);
            this.kiallitasiHely.Margin = new System.Windows.Forms.Padding(5);
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
            this.beallitasok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beallitasok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beallitasok.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F);
            this.beallitasok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.beallitasok.Image = ((System.Drawing.Image)(resources.GetObject("beallitasok.Image")));
            this.beallitasok.Location = new System.Drawing.Point(0, 0);
            this.beallitasok.Margin = new System.Windows.Forms.Padding(0);
            this.beallitasok.Name = "beallitasok";
            this.beallitasok.Size = new System.Drawing.Size(40, 37);
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
            this.helyIdo.Location = new System.Drawing.Point(731, 666);
            this.helyIdo.Margin = new System.Windows.Forms.Padding(5);
            this.helyIdo.Name = "helyIdo";
            this.helyIdo.Size = new System.Drawing.Size(323, 27);
            this.helyIdo.TabIndex = 22;
            this.helyIdo.Text = "Hely és aktuális dátum kitöltése\r\n";
            this.helyIdo.UseVisualStyleBackColor = false;
            this.helyIdo.CheckedChanged += new System.EventHandler(this.helyIdo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 37);
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
            this.label6.Size = new System.Drawing.Size(195, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dokumentum Kitöltő";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(1089, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1129, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.fileFormat);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.DocTipus);
            this.panel3.Controls.Add(this.SorSzam);
            this.panel3.Controls.Add(this.frissites);
            this.panel3.Controls.Add(this.helyIdo);
            this.panel3.Controls.Add(this.ExcelOldalNevek);
            this.panel3.Controls.Add(this.label1);
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
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.valasztFolyamatban);
            this.panel3.Controls.Add(this.dokumentumKeszites);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 741);
            this.panel3.TabIndex = 24;
            // 
            // fileFormat
            // 
            this.fileFormat.BackColor = System.Drawing.Color.Black;
            this.fileFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileFormat.ForeColor = System.Drawing.Color.White;
            this.fileFormat.FormattingEnabled = true;
            this.fileFormat.Items.AddRange(new object[] {
            ".pdf",
            ".docx"});
            this.fileFormat.Location = new System.Drawing.Point(1045, 495);
            this.fileFormat.Margin = new System.Windows.Forms.Padding(4);
            this.fileFormat.Name = "fileFormat";
            this.fileFormat.Size = new System.Drawing.Size(84, 30);
            this.fileFormat.TabIndex = 32;
            this.fileFormat.SelectedIndexChanged += new System.EventHandler(this.fileFormat_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label10.Location = new System.Drawing.Point(748, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 28);
            this.label10.TabIndex = 31;
            this.label10.Text = "Dokumentum típusa";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocTipus
            // 
            this.DocTipus.BackColor = System.Drawing.Color.Black;
            this.DocTipus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocTipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DocTipus.ForeColor = System.Drawing.Color.White;
            this.DocTipus.FormattingEnabled = true;
            this.DocTipus.Items.AddRange(new object[] {
            "Képzési Igazolás",
            "Jelentkezési Lap"});
            this.DocTipus.Location = new System.Drawing.Point(757, 348);
            this.DocTipus.Margin = new System.Windows.Forms.Padding(4);
            this.DocTipus.Name = "DocTipus";
            this.DocTipus.Size = new System.Drawing.Size(239, 28);
            this.DocTipus.TabIndex = 30;
            this.DocTipus.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // SorSzam
            // 
            this.SorSzam.BackColor = System.Drawing.Color.Black;
            this.SorSzam.DropDownHeight = 100;
            this.SorSzam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SorSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SorSzam.ForeColor = System.Drawing.Color.White;
            this.SorSzam.FormattingEnabled = true;
            this.SorSzam.IntegralHeight = false;
            this.SorSzam.Location = new System.Drawing.Point(159, 495);
            this.SorSzam.Margin = new System.Windows.Forms.Padding(4);
            this.SorSzam.Name = "SorSzam";
            this.SorSzam.Size = new System.Drawing.Size(305, 32);
            this.SorSzam.TabIndex = 29;
            this.SorSzam.TextUpdate += new System.EventHandler(this.SorSzam_TextUpdate);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(452, 546);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 64);
            this.button3.TabIndex = 26;
            this.button3.Text = "Adat ellenőrzés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(475, 286);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
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
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(431, 535);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
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
            // valasztFolyamatban
            // 
            this.valasztFolyamatban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valasztFolyamatban.Controls.Add(this.label13);
            this.valasztFolyamatban.Location = new System.Drawing.Point(203, 539);
            this.valasztFolyamatban.Margin = new System.Windows.Forms.Padding(5);
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
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.button5.Location = new System.Drawing.Point(559, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 37);
            this.button5.TabIndex = 29;
            this.button5.Text = "Excel sablon fájl";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ujTanulo
            // 
            this.ujTanulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ujTanulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ujTanulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujTanulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ujTanulo.Location = new System.Drawing.Point(213, 0);
            this.ujTanulo.Margin = new System.Windows.Forms.Padding(0);
            this.ujTanulo.Name = "ujTanulo";
            this.ujTanulo.Size = new System.Drawing.Size(173, 37);
            this.ujTanulo.TabIndex = 28;
            this.ujTanulo.Text = "Új tanuló";
            this.ujTanulo.UseVisualStyleBackColor = true;
            this.ujTanulo.Click += new System.EventHandler(this.ujTanulo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1176, 815);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1176, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.fooldal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.beallitasok, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.statNyit, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ujTanulo, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1176, 37);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // fooldal
            // 
            this.fooldal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fooldal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fooldal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.fooldal.Location = new System.Drawing.Point(40, 0);
            this.fooldal.Margin = new System.Windows.Forms.Padding(0);
            this.fooldal.Name = "fooldal";
            this.fooldal.Size = new System.Drawing.Size(173, 37);
            this.fooldal.TabIndex = 31;
            this.fooldal.Text = "Főoldal";
            this.fooldal.UseVisualStyleBackColor = true;
            this.fooldal.Click += new System.EventHandler(this.fooldal_Click);
            // 
            // statNyit
            // 
            this.statNyit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statNyit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statNyit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statNyit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.statNyit.Location = new System.Drawing.Point(386, 0);
            this.statNyit.Margin = new System.Windows.Forms.Padding(0);
            this.statNyit.Name = "statNyit";
            this.statNyit.Size = new System.Drawing.Size(173, 37);
            this.statNyit.TabIndex = 30;
            this.statNyit.Text = "Statisztikák";
            this.statNyit.UseVisualStyleBackColor = true;
            this.statNyit.Click += new System.EventHandler(this.statNyit_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.staticLoading);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.tanuloAdatok1);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.statisztika1);
            this.MainPanel.Controls.Add(this.loading1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 74);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1176, 741);
            this.MainPanel.TabIndex = 2;
            // 
            // staticLoading
            // 
            this.staticLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.staticLoading.ColumnCount = 1;
            this.staticLoading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staticLoading.Controls.Add(this.panel6, 0, 0);
            this.staticLoading.Location = new System.Drawing.Point(431, 263);
            this.staticLoading.Margin = new System.Windows.Forms.Padding(4);
            this.staticLoading.Name = "staticLoading";
            this.staticLoading.RowCount = 1;
            this.staticLoading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staticLoading.Size = new System.Drawing.Size(319, 127);
            this.staticLoading.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(313, 123);
            this.panel6.TabIndex = 32;
            this.panel6.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(313, 123);
            this.label8.TabIndex = 0;
            this.label8.Text = "Folyamatban...";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseWaitCursor = true;
            // 
            // tanuloAdatok1
            // 
            this.tanuloAdatok1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanuloAdatok1.Location = new System.Drawing.Point(0, 0);
            this.tanuloAdatok1.Margin = new System.Windows.Forms.Padding(5);
            this.tanuloAdatok1.Name = "tanuloAdatok1";
            this.tanuloAdatok1.Size = new System.Drawing.Size(1176, 741);
            this.tanuloAdatok1.TabIndex = 30;
            // 
            // statisztika1
            // 
            this.statisztika1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisztika1.Location = new System.Drawing.Point(0, 0);
            this.statisztika1.Margin = new System.Windows.Forms.Padding(5);
            this.statisztika1.Name = "statisztika1";
            this.statisztika1.Size = new System.Drawing.Size(1176, 741);
            this.statisztika1.TabIndex = 30;
            // 
            // loading1
            // 
            this.loading1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.loading1.Location = new System.Drawing.Point(431, 260);
            this.loading1.Margin = new System.Windows.Forms.Padding(0);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(323, 134);
            this.loading1.TabIndex = 30;
            this.loading1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1176, 815);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Képzési igazolás kitöltő";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
            this.valasztFolyamatban.ResumeLayout(false);
            this.valasztFolyamatban.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.staticLoading.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ujTanulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox ujTanuloIdo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel valasztFolyamatban;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox iskolaCim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox iskolaNev;
        private System.Windows.Forms.TextBox iskolaAzonosito;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox SorSzam;
        private TanuloAdatok tanuloAdatok1;
        private System.Windows.Forms.Button statNyit;
        private System.Windows.Forms.Button fooldal;
        private statisztika statisztika1;
        private loading loading1;
        private System.Windows.Forms.TableLayoutPanel staticLoading;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DocTipus;
        private System.Windows.Forms.ComboBox fileFormat;
        private System.Windows.Forms.Label VersionDisplay;
        private System.Windows.Forms.Label label12;
    }
}

