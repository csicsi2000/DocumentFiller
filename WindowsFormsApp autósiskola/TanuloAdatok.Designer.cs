
namespace WindowsFormsApp_autósiskola
{
    partial class TanuloAdatok
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.torlesFolyamatban = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.mentesFolyamatban = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tanulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezaras = new System.Windows.Forms.Button();
            this.megjegyzesek = new System.Windows.Forms.TextBox();
            this.mentes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.torles = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.torlesFolyamatban.SuspendLayout();
            this.mentesFolyamatban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // torlesFolyamatban
            // 
            this.torlesFolyamatban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.torlesFolyamatban.Controls.Add(this.label12);
            this.torlesFolyamatban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torlesFolyamatban.Location = new System.Drawing.Point(729, 459);
            this.torlesFolyamatban.Margin = new System.Windows.Forms.Padding(4);
            this.torlesFolyamatban.Name = "torlesFolyamatban";
            this.torlesFolyamatban.Size = new System.Drawing.Size(122, 50);
            this.torlesFolyamatban.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(4, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Folyamatban...";
            // 
            // mentesFolyamatban
            // 
            this.mentesFolyamatban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mentesFolyamatban.Controls.Add(this.label10);
            this.mentesFolyamatban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesFolyamatban.Location = new System.Drawing.Point(537, 522);
            this.mentesFolyamatban.Margin = new System.Windows.Forms.Padding(4);
            this.mentesFolyamatban.Name = "mentesFolyamatban";
            this.mentesFolyamatban.Size = new System.Drawing.Size(122, 51);
            this.mentesFolyamatban.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(4, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Folyamatban...";
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
            this.dataGridView1.Location = new System.Drawing.Point(38, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 562);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
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
            // bezaras
            // 
            this.bezaras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bezaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bezaras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bezaras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bezaras.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bezaras.Location = new System.Drawing.Point(733, 523);
            this.bezaras.Margin = new System.Windows.Forms.Padding(4);
            this.bezaras.Name = "bezaras";
            this.bezaras.Size = new System.Drawing.Size(117, 49);
            this.bezaras.TabIndex = 3;
            this.bezaras.Text = "Bezárás";
            this.bezaras.UseVisualStyleBackColor = true;
            this.bezaras.Click += new System.EventHandler(this.bezaras_Click);
            // 
            // megjegyzesek
            // 
            this.megjegyzesek.BackColor = System.Drawing.Color.WhiteSmoke;
            this.megjegyzesek.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megjegyzesek.Location = new System.Drawing.Point(542, 31);
            this.megjegyzesek.Multiline = true;
            this.megjegyzesek.Name = "megjegyzesek";
            this.megjegyzesek.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.megjegyzesek.Size = new System.Drawing.Size(306, 412);
            this.megjegyzesek.TabIndex = 6;
            // 
            // mentes
            // 
            this.mentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mentes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mentes.Location = new System.Drawing.Point(544, 523);
            this.mentes.Margin = new System.Windows.Forms.Padding(4);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(109, 49);
            this.mentes.TabIndex = 5;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(176)))), ((int)(((byte)(24)))));
            this.label8.Location = new System.Drawing.Point(543, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Megjegyzések";
            // 
            // torles
            // 
            this.torles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.torles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.torles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.torles.Location = new System.Drawing.Point(733, 460);
            this.torles.Margin = new System.Windows.Forms.Padding(4);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(117, 49);
            this.torles.TabIndex = 26;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.torles);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.mentes);
            this.panel6.Controls.Add(this.megjegyzesek);
            this.panel6.Controls.Add(this.bezaras);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.mentesFolyamatban);
            this.panel6.Controls.Add(this.torlesFolyamatban);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(882, 602);
            this.panel6.TabIndex = 28;
            // 
            // TanuloAdatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Name = "TanuloAdatok";
            this.Size = new System.Drawing.Size(882, 602);
            this.torlesFolyamatban.ResumeLayout(false);
            this.torlesFolyamatban.PerformLayout();
            this.mentesFolyamatban.ResumeLayout(false);
            this.mentesFolyamatban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel torlesFolyamatban;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel mentesFolyamatban;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanulo;
        private System.Windows.Forms.Button bezaras;
        private System.Windows.Forms.TextBox megjegyzesek;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Panel panel6;
    }
}
