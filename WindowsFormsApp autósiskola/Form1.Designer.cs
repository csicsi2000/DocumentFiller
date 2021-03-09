
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mehet = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Adatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SorSzam
            // 
            resources.ApplyResources(this.SorSzam, "SorSzam");
            this.SorSzam.BackColor = System.Drawing.Color.Black;
            this.SorSzam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SorSzam.ForeColor = System.Drawing.Color.White;
            this.SorSzam.Name = "SorSzam";
            this.SorSzam.TextChanged += new System.EventHandler(this.SorSzam_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label2.Name = "label2";
            // 
            // kereses
            // 
            resources.ApplyResources(this.kereses, "kereses");
            this.kereses.BackColor = System.Drawing.Color.Black;
            this.kereses.ForeColor = System.Drawing.Color.Silver;
            this.kereses.Name = "kereses";
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
            resources.ApplyResources(this.excelHelye, "excelHelye");
            this.excelHelye.BackColor = System.Drawing.Color.Black;
            this.excelHelye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.excelHelye.ForeColor = System.Drawing.Color.White;
            this.excelHelye.Name = "excelHelye";
            this.excelHelye.ReadOnly = true;
            this.excelHelye.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dokumentumKeszites
            // 
            resources.ApplyResources(this.dokumentumKeszites, "dokumentumKeszites");
            this.dokumentumKeszites.ForeColor = System.Drawing.Color.Silver;
            this.dokumentumKeszites.Name = "dokumentumKeszites";
            this.dokumentumKeszites.UseVisualStyleBackColor = true;
            this.dokumentumKeszites.EnabledChanged += new System.EventHandler(this.dokumentumKeszites_EnabledChanged);
            this.dokumentumKeszites.Click += new System.EventHandler(this.button1_Click);
            // 
            // mentesHelye
            // 
            resources.ApplyResources(this.mentesHelye, "mentesHelye");
            this.mentesHelye.BackColor = System.Drawing.Color.Black;
            this.mentesHelye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mentesHelye.ForeColor = System.Drawing.Color.White;
            this.mentesHelye.Name = "mentesHelye";
            this.mentesHelye.ReadOnly = true;
            this.mentesHelye.TextChanged += new System.EventHandler(this.mentesHelye_TextChanged);
            // 
            // mentesHelyeKereses
            // 
            resources.ApplyResources(this.mentesHelyeKereses, "mentesHelyeKereses");
            this.mentesHelyeKereses.ForeColor = System.Drawing.Color.Silver;
            this.mentesHelyeKereses.Name = "mentesHelyeKereses";
            this.mentesHelyeKereses.UseVisualStyleBackColor = true;
            this.mentesHelyeKereses.Click += new System.EventHandler(this.mentesHelyeKereses_Click);
            // 
            // filepath
            // 
            this.filepath.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // mentettFajlNeve
            // 
            resources.ApplyResources(this.mentettFajlNeve, "mentettFajlNeve");
            this.mentettFajlNeve.BackColor = System.Drawing.Color.Black;
            this.mentettFajlNeve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mentettFajlNeve.ForeColor = System.Drawing.Color.White;
            this.mentettFajlNeve.Name = "mentettFajlNeve";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sorSzamValasztas
            // 
            resources.ApplyResources(this.sorSzamValasztas, "sorSzamValasztas");
            this.sorSzamValasztas.ForeColor = System.Drawing.Color.Silver;
            this.sorSzamValasztas.Name = "sorSzamValasztas";
            this.sorSzamValasztas.UseVisualStyleBackColor = true;
            this.sorSzamValasztas.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // nyissaEMeg
            // 
            resources.ApplyResources(this.nyissaEMeg, "nyissaEMeg");
            this.nyissaEMeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.nyissaEMeg.Name = "nyissaEMeg";
            this.nyissaEMeg.UseVisualStyleBackColor = true;
            this.nyissaEMeg.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ExcelOldalNevek
            // 
            resources.ApplyResources(this.ExcelOldalNevek, "ExcelOldalNevek");
            this.ExcelOldalNevek.BackColor = System.Drawing.Color.Silver;
            this.ExcelOldalNevek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExcelOldalNevek.FormattingEnabled = true;
            this.ExcelOldalNevek.Name = "ExcelOldalNevek";
            this.ExcelOldalNevek.SelectedIndexChanged += new System.EventHandler(this.ExcelOldal_SelectedIndexChanged);
            // 
            // ekezetek
            // 
            resources.ApplyResources(this.ekezetek, "ekezetek");
            this.ekezetek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ekezetek.Name = "ekezetek";
            this.ekezetek.UseVisualStyleBackColor = true;
            this.ekezetek.CheckedChanged += new System.EventHandler(this.ekezetek_CheckedChanged);
            // 
            // szokoz
            // 
            resources.ApplyResources(this.szokoz, "szokoz");
            this.szokoz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.szokoz.Name = "szokoz";
            this.szokoz.UseVisualStyleBackColor = true;
            this.szokoz.CheckedChanged += new System.EventHandler(this.szokoz_CheckedChanged);
            // 
            // frissites
            // 
            resources.ApplyResources(this.frissites, "frissites");
            this.frissites.ForeColor = System.Drawing.Color.Silver;
            this.frissites.Name = "frissites";
            this.frissites.UseVisualStyleBackColor = true;
            this.frissites.Click += new System.EventHandler(this.frissites_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.honapBetu);
            this.panel1.Controls.Add(this.bezaras);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.kiallitasiHely);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label8.Name = "label8";
            // 
            // honapBetu
            // 
            resources.ApplyResources(this.honapBetu, "honapBetu");
            this.honapBetu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.honapBetu.Name = "honapBetu";
            this.honapBetu.UseVisualStyleBackColor = true;
            this.honapBetu.CheckedChanged += new System.EventHandler(this.honapBetu_CheckedChanged);
            // 
            // bezaras
            // 
            resources.ApplyResources(this.bezaras, "bezaras");
            this.bezaras.Name = "bezaras";
            this.bezaras.UseVisualStyleBackColor = true;
            this.bezaras.Click += new System.EventHandler(this.bezaras_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // kiallitasiHely
            // 
            this.kiallitasiHely.BackColor = System.Drawing.Color.Black;
            this.kiallitasiHely.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.kiallitasiHely, "kiallitasiHely");
            this.kiallitasiHely.ForeColor = System.Drawing.Color.White;
            this.kiallitasiHely.Name = "kiallitasiHely";
            this.kiallitasiHely.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // beallitasok
            // 
            this.beallitasok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            resources.ApplyResources(this.beallitasok, "beallitasok");
            this.beallitasok.ForeColor = System.Drawing.Color.White;
            this.beallitasok.Name = "beallitasok";
            this.beallitasok.UseVisualStyleBackColor = false;
            this.beallitasok.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // helyIdo
            // 
            resources.ApplyResources(this.helyIdo, "helyIdo");
            this.helyIdo.BackColor = System.Drawing.Color.Black;
            this.helyIdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.helyIdo.Name = "helyIdo";
            this.helyIdo.UseVisualStyleBackColor = false;
            this.helyIdo.CheckedChanged += new System.EventHandler(this.helyIdo_CheckedChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label6_MouseUp);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.frissites);
            this.panel3.Controls.Add(this.beallitasok);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.helyIdo);
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
            this.panel3.Controls.Add(this.ExcelOldalNevek);
            this.panel3.Controls.Add(this.sorSzamValasztas);
            this.panel3.Controls.Add(this.nyissaEMeg);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dokumentumKeszites);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel7
            // 
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Controls.Add(this.label9);
            this.panel7.Name = "panel7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Name = "label9";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Name = "button4";
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
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.mehet);
            this.panel4.Name = "panel4";
            // 
            // mehet
            // 
            resources.ApplyResources(this.mehet, "mehet");
            this.mehet.ForeColor = System.Drawing.Color.Silver;
            this.mehet.Name = "mehet";
            this.mehet.Click += new System.EventHandler(this.mehet_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Adatok
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Adatok.DefaultCellStyle = dataGridViewCellStyle2;
            this.Adatok.FillWeight = 121.8274F;
            resources.ApplyResources(this.Adatok, "Adatok");
            this.Adatok.Name = "Adatok";
            this.Adatok.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tanulo
            // 
            this.Tanulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tanulo.FillWeight = 78.1726F;
            resources.ApplyResources(this.Tanulo, "Tanulo");
            this.Tanulo.Name = "Tanulo";
            this.Tanulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanulo;
    }
}

