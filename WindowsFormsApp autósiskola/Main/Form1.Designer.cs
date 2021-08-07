
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
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.filepath = new System.Windows.Forms.FolderBrowserDialog();
            this.beallitasok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ExcelSablon = new System.Windows.Forms.Button();
            this.ujTanulo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.isGoogleSheet = new System.Windows.Forms.CheckBox();
            this.frissites = new System.Windows.Forms.Button();
            this.ExcelOldalNevek = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.localExcel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.kereses = new System.Windows.Forms.Button();
            this.excelHelye = new System.Windows.Forms.TextBox();
            this.fileFormat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DocTipus = new System.Windows.Forms.ComboBox();
            this.SorSzam = new System.Windows.Forms.ComboBox();
            this.helyIdo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mentesHelye = new System.Windows.Forms.TextBox();
            this.mentesHelyeKereses = new System.Windows.Forms.Button();
            this.szokoz = new System.Windows.Forms.CheckBox();
            this.mentettFajlNeve = new System.Windows.Forms.TextBox();
            this.ekezetek = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sorSzamValasztas = new System.Windows.Forms.Button();
            this.nyissaEMeg = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.valasztFolyamatban = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dokumentumKeszites = new System.Windows.Forms.Button();
            this.staticLoading = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.fooldal = new System.Windows.Forms.Button();
            this.statNyit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tanuloAdatok1 = new WindowsFormsApp_autósiskola.TanuloAdatok();
            this.statisztika1 = new WindowsFormsApp_autósiskola.statisztika();
            this.googleSheet1 = new WindowsFormsApp_autósiskola.UserControls.GoogleSheet();
            this.loading1 = new WindowsFormsApp_autósiskola.loading();
            this.beallitasok1 = new WindowsFormsApp_autósiskola.UserControls.beallitasok();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.localExcel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.valasztFolyamatban.SuspendLayout();
            this.staticLoading.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            this.openFD.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // filepath
            // 
            this.filepath.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // beallitasok
            // 
            this.beallitasok.BackColor = System.Drawing.Color.Black;
            this.beallitasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beallitasok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beallitasok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beallitasok.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beallitasok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.beallitasok.Location = new System.Drawing.Point(0, 350);
            this.beallitasok.Margin = new System.Windows.Forms.Padding(0);
            this.beallitasok.Name = "beallitasok";
            this.beallitasok.Size = new System.Drawing.Size(250, 70);
            this.beallitasok.TabIndex = 21;
            this.beallitasok.Text = "Beállítások";
            this.beallitasok.UseVisualStyleBackColor = false;
            this.beallitasok.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 30);
            this.panel2.TabIndex = 23;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label6_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dokumentum Kitöltő";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(881, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 30);
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
            this.button1.Location = new System.Drawing.Point(913, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // ExcelSablon
            // 
            this.ExcelSablon.BackColor = System.Drawing.Color.Black;
            this.ExcelSablon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExcelSablon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelSablon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExcelSablon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ExcelSablon.Location = new System.Drawing.Point(0, 280);
            this.ExcelSablon.Margin = new System.Windows.Forms.Padding(0);
            this.ExcelSablon.Name = "ExcelSablon";
            this.ExcelSablon.Size = new System.Drawing.Size(250, 70);
            this.ExcelSablon.TabIndex = 29;
            this.ExcelSablon.Text = "Excel sablon fájl";
            this.ExcelSablon.UseVisualStyleBackColor = false;
            this.ExcelSablon.Click += new System.EventHandler(this.button5_Click);
            // 
            // ujTanulo
            // 
            this.ujTanulo.BackColor = System.Drawing.Color.Black;
            this.ujTanulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ujTanulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ujTanulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujTanulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ujTanulo.Location = new System.Drawing.Point(0, 140);
            this.ujTanulo.Margin = new System.Windows.Forms.Padding(0);
            this.ujTanulo.Name = "ujTanulo";
            this.ujTanulo.Size = new System.Drawing.Size(250, 70);
            this.ujTanulo.TabIndex = 28;
            this.ujTanulo.Text = "Új tanuló";
            this.ujTanulo.UseVisualStyleBackColor = false;
            this.ujTanulo.Click += new System.EventHandler(this.ujTanulo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1201, 735);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(250, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(951, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.tanuloAdatok1);
            this.MainPanel.Controls.Add(this.statisztika1);
            this.MainPanel.Controls.Add(this.googleSheet1);
            this.MainPanel.Controls.Add(this.staticLoading);
            this.MainPanel.Controls.Add(this.loading1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(250, 30);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(951, 705);
            this.MainPanel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.beallitasok1);
            this.panel3.Controls.Add(this.isGoogleSheet);
            this.panel3.Controls.Add(this.frissites);
            this.panel3.Controls.Add(this.ExcelOldalNevek);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.localExcel);
            this.panel3.Controls.Add(this.fileFormat);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.DocTipus);
            this.panel3.Controls.Add(this.SorSzam);
            this.panel3.Controls.Add(this.helyIdo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.mentesHelye);
            this.panel3.Controls.Add(this.mentesHelyeKereses);
            this.panel3.Controls.Add(this.szokoz);
            this.panel3.Controls.Add(this.mentettFajlNeve);
            this.panel3.Controls.Add(this.ekezetek);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sorSzamValasztas);
            this.panel3.Controls.Add(this.nyissaEMeg);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.valasztFolyamatban);
            this.panel3.Controls.Add(this.dokumentumKeszites);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(951, 705);
            this.panel3.TabIndex = 24;
            // 
            // isGoogleSheet
            // 
            this.isGoogleSheet.AutoSize = true;
            this.isGoogleSheet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isGoogleSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.isGoogleSheet.Location = new System.Drawing.Point(167, 36);
            this.isGoogleSheet.Name = "isGoogleSheet";
            this.isGoogleSheet.Size = new System.Drawing.Size(227, 25);
            this.isGoogleSheet.TabIndex = 37;
            this.isGoogleSheet.Text = "Google Sheet használata";
            this.isGoogleSheet.UseVisualStyleBackColor = true;
            this.isGoogleSheet.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_2);
            // 
            // frissites
            // 
            this.frissites.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.frissites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frissites.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.frissites.ForeColor = System.Drawing.Color.Silver;
            this.frissites.Location = new System.Drawing.Point(427, 292);
            this.frissites.Margin = new System.Windows.Forms.Padding(4);
            this.frissites.Name = "frissites";
            this.frissites.Size = new System.Drawing.Size(77, 42);
            this.frissites.TabIndex = 35;
            this.frissites.Text = "lista frissítés";
            this.frissites.UseVisualStyleBackColor = true;
            this.frissites.Click += new System.EventHandler(this.frissites_Click);
            // 
            // ExcelOldalNevek
            // 
            this.ExcelOldalNevek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExcelOldalNevek.BackColor = System.Drawing.Color.Silver;
            this.ExcelOldalNevek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExcelOldalNevek.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ExcelOldalNevek.FormattingEnabled = true;
            this.ExcelOldalNevek.ItemHeight = 20;
            this.ExcelOldalNevek.Location = new System.Drawing.Point(171, 263);
            this.ExcelOldalNevek.Margin = new System.Windows.Forms.Padding(4);
            this.ExcelOldalNevek.Name = "ExcelOldalNevek";
            this.ExcelOldalNevek.Size = new System.Drawing.Size(246, 100);
            this.ExcelOldalNevek.TabIndex = 34;
            this.ExcelOldalNevek.SelectedIndexChanged += new System.EventHandler(this.ExcelOldal_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(423, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 51);
            this.panel5.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Folyamatban...";
            // 
            // localExcel
            // 
            this.localExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.localExcel.Controls.Add(this.label2);
            this.localExcel.Controls.Add(this.kereses);
            this.localExcel.Controls.Add(this.excelHelye);
            this.localExcel.Location = new System.Drawing.Point(45, 84);
            this.localExcel.Name = "localExcel";
            this.localExcel.Size = new System.Drawing.Size(479, 159);
            this.localExcel.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label2.Location = new System.Drawing.Point(117, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 23);
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
            this.kereses.Location = new System.Drawing.Point(165, 91);
            this.kereses.Margin = new System.Windows.Forms.Padding(2);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(166, 54);
            this.kereses.TabIndex = 5;
            this.kereses.Text = "Keresés";
            this.kereses.UseVisualStyleBackColor = false;
            this.kereses.Click += new System.EventHandler(this.excelKereses_Click);
            // 
            // excelHelye
            // 
            this.excelHelye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.excelHelye.BackColor = System.Drawing.Color.Black;
            this.excelHelye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.excelHelye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.excelHelye.ForeColor = System.Drawing.Color.White;
            this.excelHelye.Location = new System.Drawing.Point(71, 50);
            this.excelHelye.Margin = new System.Windows.Forms.Padding(2);
            this.excelHelye.Name = "excelHelye";
            this.excelHelye.ReadOnly = true;
            this.excelHelye.Size = new System.Drawing.Size(350, 24);
            this.excelHelye.TabIndex = 6;
            this.excelHelye.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.excelHelye_MouseDoubleClick);
            // 
            // fileFormat
            // 
            this.fileFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileFormat.BackColor = System.Drawing.Color.Black;
            this.fileFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileFormat.ForeColor = System.Drawing.Color.White;
            this.fileFormat.FormattingEnabled = true;
            this.fileFormat.Items.AddRange(new object[] {
            ".pdf",
            ".docx"});
            this.fileFormat.Location = new System.Drawing.Point(840, 452);
            this.fileFormat.Name = "fileFormat";
            this.fileFormat.Size = new System.Drawing.Size(68, 25);
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
            this.label10.Location = new System.Drawing.Point(603, 299);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 23);
            this.label10.TabIndex = 31;
            this.label10.Text = "Dokumentum típusa";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocTipus
            // 
            this.DocTipus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DocTipus.BackColor = System.Drawing.Color.Black;
            this.DocTipus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocTipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DocTipus.ForeColor = System.Drawing.Color.White;
            this.DocTipus.FormattingEnabled = true;
            this.DocTipus.Items.AddRange(new object[] {
            "Képzési Igazolás",
            "Jelentkezési Lap",
            "Beiratkozási Adatlap",
            "Felnőttk. Szerződés"});
            this.DocTipus.Location = new System.Drawing.Point(607, 326);
            this.DocTipus.Name = "DocTipus";
            this.DocTipus.Size = new System.Drawing.Size(192, 24);
            this.DocTipus.TabIndex = 30;
            this.DocTipus.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // SorSzam
            // 
            this.SorSzam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SorSzam.BackColor = System.Drawing.Color.Black;
            this.SorSzam.DropDownHeight = 100;
            this.SorSzam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SorSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SorSzam.ForeColor = System.Drawing.Color.White;
            this.SorSzam.FormattingEnabled = true;
            this.SorSzam.IntegralHeight = false;
            this.SorSzam.Location = new System.Drawing.Point(127, 451);
            this.SorSzam.Name = "SorSzam";
            this.SorSzam.Size = new System.Drawing.Size(245, 26);
            this.SorSzam.TabIndex = 29;
            this.SorSzam.SelectedIndexChanged += new System.EventHandler(this.SorSzam_SelectedIndexChanged);
            this.SorSzam.TextUpdate += new System.EventHandler(this.SorSzam_TextUpdate);
            // 
            // helyIdo
            // 
            this.helyIdo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helyIdo.AutoSize = true;
            this.helyIdo.BackColor = System.Drawing.Color.Black;
            this.helyIdo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.helyIdo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.helyIdo.Location = new System.Drawing.Point(590, 589);
            this.helyIdo.Margin = new System.Windows.Forms.Padding(4);
            this.helyIdo.Name = "helyIdo";
            this.helyIdo.Size = new System.Drawing.Size(256, 22);
            this.helyIdo.TabIndex = 22;
            this.helyIdo.Text = "Hely és aktuális dátum kitöltése\r\n";
            this.helyIdo.UseVisualStyleBackColor = false;
            this.helyIdo.CheckedChanged += new System.EventHandler(this.helyIdo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label1.Location = new System.Drawing.Point(67, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiválasztott tanuló sorszáma vagy neve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label4.Location = new System.Drawing.Point(642, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mentés helye";
            // 
            // mentesHelye
            // 
            this.mentesHelye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentesHelye.BackColor = System.Drawing.Color.Black;
            this.mentesHelye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mentesHelye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesHelye.ForeColor = System.Drawing.Color.White;
            this.mentesHelye.Location = new System.Drawing.Point(536, 134);
            this.mentesHelye.Margin = new System.Windows.Forms.Padding(2);
            this.mentesHelye.Name = "mentesHelye";
            this.mentesHelye.ReadOnly = true;
            this.mentesHelye.Size = new System.Drawing.Size(358, 24);
            this.mentesHelye.TabIndex = 7;
            this.mentesHelye.DoubleClick += new System.EventHandler(this.mentesHelye_MouseDoubleClick);
            // 
            // mentesHelyeKereses
            // 
            this.mentesHelyeKereses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentesHelyeKereses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentesHelyeKereses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.mentesHelyeKereses.ForeColor = System.Drawing.Color.Silver;
            this.mentesHelyeKereses.Location = new System.Drawing.Point(629, 175);
            this.mentesHelyeKereses.Margin = new System.Windows.Forms.Padding(2);
            this.mentesHelyeKereses.Name = "mentesHelyeKereses";
            this.mentesHelyeKereses.Size = new System.Drawing.Size(170, 54);
            this.mentesHelyeKereses.TabIndex = 4;
            this.mentesHelyeKereses.Text = "Keresés";
            this.mentesHelyeKereses.UseVisualStyleBackColor = true;
            this.mentesHelyeKereses.Click += new System.EventHandler(this.mentesHelyeKereses_Click);
            // 
            // szokoz
            // 
            this.szokoz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szokoz.AutoSize = true;
            this.szokoz.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.szokoz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.szokoz.Location = new System.Drawing.Point(137, 589);
            this.szokoz.Margin = new System.Windows.Forms.Padding(4);
            this.szokoz.Name = "szokoz";
            this.szokoz.Size = new System.Drawing.Size(241, 22);
            this.szokoz.TabIndex = 17;
            this.szokoz.Text = "Számítson-e a szóköz, kötőjel";
            this.szokoz.UseVisualStyleBackColor = true;
            this.szokoz.CheckedChanged += new System.EventHandler(this.szokoz_CheckedChanged);
            // 
            // mentettFajlNeve
            // 
            this.mentettFajlNeve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentettFajlNeve.BackColor = System.Drawing.Color.Black;
            this.mentettFajlNeve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mentettFajlNeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentettFajlNeve.ForeColor = System.Drawing.Color.White;
            this.mentettFajlNeve.Location = new System.Drawing.Point(590, 453);
            this.mentettFajlNeve.Margin = new System.Windows.Forms.Padding(2);
            this.mentettFajlNeve.Name = "mentettFajlNeve";
            this.mentettFajlNeve.Size = new System.Drawing.Size(245, 24);
            this.mentettFajlNeve.TabIndex = 9;
            this.mentettFajlNeve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ekezetek
            // 
            this.ekezetek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ekezetek.AutoSize = true;
            this.ekezetek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ekezetek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.ekezetek.Location = new System.Drawing.Point(137, 559);
            this.ekezetek.Margin = new System.Windows.Forms.Padding(4);
            this.ekezetek.Name = "ekezetek";
            this.ekezetek.Size = new System.Drawing.Size(228, 22);
            this.ekezetek.TabIndex = 16;
            this.ekezetek.Text = "Számítsanak-e az ékezetek";
            this.ekezetek.UseVisualStyleBackColor = true;
            this.ekezetek.CheckedChanged += new System.EventHandler(this.ekezetek_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(582, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 23);
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
            this.sorSzamValasztas.Location = new System.Drawing.Point(175, 493);
            this.sorSzamValasztas.Margin = new System.Windows.Forms.Padding(4);
            this.sorSzamValasztas.Name = "sorSzamValasztas";
            this.sorSzamValasztas.Size = new System.Drawing.Size(166, 51);
            this.sorSzamValasztas.TabIndex = 11;
            this.sorSzamValasztas.Text = "Ellenőrzés";
            this.sorSzamValasztas.UseVisualStyleBackColor = true;
            this.sorSzamValasztas.Click += new System.EventHandler(this.valaszt_Click_1);
            // 
            // nyissaEMeg
            // 
            this.nyissaEMeg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nyissaEMeg.AutoSize = true;
            this.nyissaEMeg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.nyissaEMeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.nyissaEMeg.Location = new System.Drawing.Point(590, 559);
            this.nyissaEMeg.Margin = new System.Windows.Forms.Padding(4);
            this.nyissaEMeg.Name = "nyissaEMeg";
            this.nyissaEMeg.Size = new System.Drawing.Size(236, 22);
            this.nyissaEMeg.TabIndex = 14;
            this.nyissaEMeg.Text = "Nyissa meg a létrehozott fájlt";
            this.nyissaEMeg.UseVisualStyleBackColor = true;
            this.nyissaEMeg.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(367, 493);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 51);
            this.button3.TabIndex = 26;
            this.button3.Text = "Adat ellenőrzés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(350, 484);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(145, 70);
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
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Folyamatban...";
            // 
            // valasztFolyamatban
            // 
            this.valasztFolyamatban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valasztFolyamatban.Controls.Add(this.label13);
            this.valasztFolyamatban.Location = new System.Drawing.Point(167, 487);
            this.valasztFolyamatban.Margin = new System.Windows.Forms.Padding(4);
            this.valasztFolyamatban.Name = "valasztFolyamatban";
            this.valasztFolyamatban.Size = new System.Drawing.Size(176, 62);
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
            this.label13.Location = new System.Drawing.Point(26, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Folyamatban...";
            // 
            // dokumentumKeszites
            // 
            this.dokumentumKeszites.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dokumentumKeszites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dokumentumKeszites.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dokumentumKeszites.ForeColor = System.Drawing.Color.Silver;
            this.dokumentumKeszites.Location = new System.Drawing.Point(629, 490);
            this.dokumentumKeszites.Margin = new System.Windows.Forms.Padding(4);
            this.dokumentumKeszites.Name = "dokumentumKeszites";
            this.dokumentumKeszites.Size = new System.Drawing.Size(170, 54);
            this.dokumentumKeszites.TabIndex = 7;
            this.dokumentumKeszites.Text = "Mehet";
            this.dokumentumKeszites.UseVisualStyleBackColor = true;
            this.dokumentumKeszites.Click += new System.EventHandler(this.button1_Click);
            // 
            // staticLoading
            // 
            this.staticLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staticLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.staticLoading.ColumnCount = 1;
            this.staticLoading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staticLoading.Controls.Add(this.panel6, 0, 0);
            this.staticLoading.Location = new System.Drawing.Point(364, 242);
            this.staticLoading.Name = "staticLoading";
            this.staticLoading.RowCount = 1;
            this.staticLoading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.staticLoading.Size = new System.Drawing.Size(255, 102);
            this.staticLoading.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 98);
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
            this.label8.Margin = new System.Windows.Forms.Padding(2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(4);
            this.label8.Size = new System.Drawing.Size(251, 98);
            this.label8.TabIndex = 0;
            this.label8.Text = "Folyamatban...";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseWaitCursor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel4.Controls.Add(this.beallitasok, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.fooldal, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ExcelSablon, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.ujTanulo, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.statNyit, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 705);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // fooldal
            // 
            this.fooldal.BackColor = System.Drawing.Color.Black;
            this.fooldal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fooldal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fooldal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fooldal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.fooldal.Location = new System.Drawing.Point(0, 0);
            this.fooldal.Margin = new System.Windows.Forms.Padding(0);
            this.fooldal.Name = "fooldal";
            this.fooldal.Size = new System.Drawing.Size(250, 70);
            this.fooldal.TabIndex = 31;
            this.fooldal.Text = "Főoldal";
            this.fooldal.UseVisualStyleBackColor = false;
            this.fooldal.Click += new System.EventHandler(this.fooldal_Click);
            // 
            // statNyit
            // 
            this.statNyit.BackColor = System.Drawing.Color.Black;
            this.statNyit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statNyit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statNyit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statNyit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.statNyit.Location = new System.Drawing.Point(0, 210);
            this.statNyit.Margin = new System.Windows.Forms.Padding(0);
            this.statNyit.Name = "statNyit";
            this.statNyit.Size = new System.Drawing.Size(250, 70);
            this.statNyit.TabIndex = 30;
            this.statNyit.Text = "Statisztikák";
            this.statNyit.UseVisualStyleBackColor = false;
            this.statNyit.Click += new System.EventHandler(this.statNyit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 420);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 285);
            this.panel4.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.button4.Location = new System.Drawing.Point(0, 70);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 70);
            this.button4.TabIndex = 33;
            this.button4.Text = "Google Sheet URL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 30);
            this.panel8.TabIndex = 5;
            // 
            // tanuloAdatok1
            // 
            this.tanuloAdatok1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanuloAdatok1.Location = new System.Drawing.Point(0, 0);
            this.tanuloAdatok1.Margin = new System.Windows.Forms.Padding(4);
            this.tanuloAdatok1.Name = "tanuloAdatok1";
            this.tanuloAdatok1.Size = new System.Drawing.Size(951, 705);
            this.tanuloAdatok1.TabIndex = 30;
            // 
            // statisztika1
            // 
            this.statisztika1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisztika1.Location = new System.Drawing.Point(0, 0);
            this.statisztika1.Margin = new System.Windows.Forms.Padding(4);
            this.statisztika1.Name = "statisztika1";
            this.statisztika1.Size = new System.Drawing.Size(951, 705);
            this.statisztika1.TabIndex = 30;
            // 
            // googleSheet1
            // 
            this.googleSheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.googleSheet1.Location = new System.Drawing.Point(0, 0);
            this.googleSheet1.Name = "googleSheet1";
            this.googleSheet1.Size = new System.Drawing.Size(951, 705);
            this.googleSheet1.TabIndex = 33;
            // 
            // loading1
            // 
            this.loading1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.loading1.Location = new System.Drawing.Point(364, 247);
            this.loading1.Margin = new System.Windows.Forms.Padding(0);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(258, 107);
            this.loading1.TabIndex = 30;
            this.loading1.UseWaitCursor = true;
            // 
            // beallitasok1
            // 
            this.beallitasok1.Location = new System.Drawing.Point(0, 0);
            this.beallitasok1.Name = "beallitasok1";
            this.beallitasok1.Size = new System.Drawing.Size(551, 382);
            this.beallitasok1.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1201, 735);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Képzési igazolás kitöltő";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.localExcel.ResumeLayout(false);
            this.localExcel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.valasztFolyamatban.ResumeLayout(false);
            this.valasztFolyamatban.PerformLayout();
            this.staticLoading.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.FolderBrowserDialog filepath;
        private System.Windows.Forms.Button beallitasok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ujTanulo;
        private System.Windows.Forms.Button ExcelSablon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button statNyit;
        private System.Windows.Forms.Button fooldal;
        private System.Windows.Forms.Panel MainPanel;
        private loading loading1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel staticLoading;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fileFormat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DocTipus;
        private System.Windows.Forms.ComboBox SorSzam;
        private System.Windows.Forms.CheckBox helyIdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox mentesHelye;
        private System.Windows.Forms.Button kereses;
        public System.Windows.Forms.TextBox excelHelye;
        private System.Windows.Forms.Button mentesHelyeKereses;
        public System.Windows.Forms.CheckBox szokoz;
        public System.Windows.Forms.TextBox mentettFajlNeve;
        public System.Windows.Forms.CheckBox ekezetek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sorSzamValasztas;
        public System.Windows.Forms.CheckBox nyissaEMeg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel valasztFolyamatban;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button dokumentumKeszites;
        private TanuloAdatok tanuloAdatok1;
        private statisztika statisztika1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button4;
        private UserControls.GoogleSheet googleSheet1;
        private System.Windows.Forms.CheckBox isGoogleSheet;
        private System.Windows.Forms.Button frissites;
        public System.Windows.Forms.ListBox ExcelOldalNevek;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel localExcel;
        private UserControls.beallitasok beallitasok1;
    }
}

