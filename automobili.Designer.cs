namespace progetto
{
    partial class automobili
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
            this.btn_IndietroAuto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAuto = new System.Windows.Forms.DataGridView();
            this.btn_ModAuto = new System.Windows.Forms.Button();
            this.btn_SalvaAuto = new System.Windows.Forms.Button();
            this.btn_CancAuto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelloTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MarchioTb = new System.Windows.Forms.TextBox();
            this.Prezzo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrezzoTb = new System.Windows.Forms.TextBox();
            this.RegNumTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_DisponAuto = new ReaLTaiizor.Controls.PoisonComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IndietroAuto
            // 
            this.btn_IndietroAuto.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_IndietroAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IndietroAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_IndietroAuto.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IndietroAuto.ForeColor = System.Drawing.Color.White;
            this.btn_IndietroAuto.Location = new System.Drawing.Point(1166, 626);
            this.btn_IndietroAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IndietroAuto.Name = "btn_IndietroAuto";
            this.btn_IndietroAuto.Size = new System.Drawing.Size(135, 34);
            this.btn_IndietroAuto.TabIndex = 43;
            this.btn_IndietroAuto.Text = "INDIETRO";
            this.btn_IndietroAuto.UseVisualStyleBackColor = false;
            this.btn_IndietroAuto.Click += new System.EventHandler(this.btn_IndietroAuto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(710, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "LISTA AUTOMOBILI DISPONIBILI";
            // 
            // dgvAuto
            // 
            this.dgvAuto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.Location = new System.Drawing.Point(551, 224);
            this.dgvAuto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.RowHeadersWidth = 51;
            this.dgvAuto.Size = new System.Drawing.Size(715, 364);
            this.dgvAuto.TabIndex = 41;
            this.dgvAuto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuto_CellContentClick);
            // 
            // btn_ModAuto
            // 
            this.btn_ModAuto.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ModAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModAuto.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModAuto.ForeColor = System.Drawing.Color.White;
            this.btn_ModAuto.Location = new System.Drawing.Point(177, 554);
            this.btn_ModAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ModAuto.Name = "btn_ModAuto";
            this.btn_ModAuto.Size = new System.Drawing.Size(135, 34);
            this.btn_ModAuto.TabIndex = 40;
            this.btn_ModAuto.Text = "MODIFICA";
            this.btn_ModAuto.UseVisualStyleBackColor = false;
            this.btn_ModAuto.Click += new System.EventHandler(this.btn_ModAuto_Click);
            // 
            // btn_SalvaAuto
            // 
            this.btn_SalvaAuto.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_SalvaAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SalvaAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SalvaAuto.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvaAuto.ForeColor = System.Drawing.Color.White;
            this.btn_SalvaAuto.Location = new System.Drawing.Point(43, 554);
            this.btn_SalvaAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SalvaAuto.Name = "btn_SalvaAuto";
            this.btn_SalvaAuto.Size = new System.Drawing.Size(103, 34);
            this.btn_SalvaAuto.TabIndex = 39;
            this.btn_SalvaAuto.Text = "SALVA";
            this.btn_SalvaAuto.UseVisualStyleBackColor = false;
            this.btn_SalvaAuto.Click += new System.EventHandler(this.btn_SalvaAuto_Click);
            // 
            // btn_CancAuto
            // 
            this.btn_CancAuto.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_CancAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancAuto.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancAuto.ForeColor = System.Drawing.Color.White;
            this.btn_CancAuto.Location = new System.Drawing.Point(345, 554);
            this.btn_CancAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CancAuto.Name = "btn_CancAuto";
            this.btn_CancAuto.Size = new System.Drawing.Size(128, 34);
            this.btn_CancAuto.TabIndex = 38;
            this.btn_CancAuto.Text = "CANCELLA";
            this.btn_CancAuto.UseVisualStyleBackColor = false;
            this.btn_CancAuto.Click += new System.EventHandler(this.btn_CancAuto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(109, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Modello";
            // 
            // ModelloTb
            // 
            this.ModelloTb.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelloTb.Location = new System.Drawing.Point(113, 342);
            this.ModelloTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModelloTb.Name = "ModelloTb";
            this.ModelloTb.Size = new System.Drawing.Size(263, 30);
            this.ModelloTb.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(108, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Marchio";
            // 
            // MarchioTb
            // 
            this.MarchioTb.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarchioTb.Location = new System.Drawing.Point(113, 258);
            this.MarchioTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarchioTb.Name = "MarchioTb";
            this.MarchioTb.Size = new System.Drawing.Size(263, 30);
            this.MarchioTb.TabIndex = 34;
            // 
            // Prezzo
            // 
            this.Prezzo.AutoSize = true;
            this.Prezzo.BackColor = System.Drawing.Color.Transparent;
            this.Prezzo.Font = new System.Drawing.Font("MS PGothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prezzo.ForeColor = System.Drawing.Color.OrangeRed;
            this.Prezzo.Location = new System.Drawing.Point(108, 401);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(90, 25);
            this.Prezzo.TabIndex = 33;
            this.Prezzo.Text = "Prezzo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(109, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "RegNum";
            // 
            // PrezzoTb
            // 
            this.PrezzoTb.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrezzoTb.Location = new System.Drawing.Point(113, 428);
            this.PrezzoTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrezzoTb.Name = "PrezzoTb";
            this.PrezzoTb.Size = new System.Drawing.Size(263, 30);
            this.PrezzoTb.TabIndex = 31;
            // 
            // RegNumTb
            // 
            this.RegNumTb.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNumTb.Location = new System.Drawing.Point(113, 176);
            this.RegNumTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegNumTb.Name = "RegNumTb";
            this.RegNumTb.Size = new System.Drawing.Size(263, 30);
            this.RegNumTb.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(489, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 37);
            this.label3.TabIndex = 44;
            this.label3.Text = "CAR RENTAL SYSTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(468, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Noleggia la tua auto con pochi click";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1313, 101);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 47;
            this.panel1.Text = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::progetto.Properties.Resources._3854342577bd0975745f7a0592dd4f42_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(403, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // cb_DisponAuto
            // 
            this.cb_DisponAuto.FormattingEnabled = true;
            this.cb_DisponAuto.ItemHeight = 24;
            this.cb_DisponAuto.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cb_DisponAuto.Location = new System.Drawing.Point(285, 493);
            this.cb_DisponAuto.Name = "cb_DisponAuto";
            this.cb_DisponAuto.Size = new System.Drawing.Size(91, 30);
            this.cb_DisponAuto.TabIndex = 52;
            this.cb_DisponAuto.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS PGothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(108, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Disponibile";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 673);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1313, 29);
            this.panel2.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(532, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Choose your perfect car";
            // 
            // automobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_DisponAuto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_IndietroAuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAuto);
            this.Controls.Add(this.btn_ModAuto);
            this.Controls.Add(this.btn_SalvaAuto);
            this.Controls.Add(this.btn_CancAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModelloTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarchioTb);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrezzoTb);
            this.Controls.Add(this.RegNumTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "automobili";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "automobili";
            this.Load += new System.EventHandler(this.automobili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IndietroAuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAuto;
        private System.Windows.Forms.Button btn_ModAuto;
        private System.Windows.Forms.Button btn_SalvaAuto;
        private System.Windows.Forms.Button btn_CancAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelloTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MarchioTb;
        private System.Windows.Forms.Label Prezzo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrezzoTb;
        private System.Windows.Forms.TextBox RegNumTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.PoisonComboBox cb_DisponAuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}