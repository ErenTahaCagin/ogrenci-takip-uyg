namespace OdevTakipApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCinsiyet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDetay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(69, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖDEV KONTROL LİSTESİ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 32);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colAd,
            this.colSoyad,
            this.colCinsiyet,
            this.colDetay,
            this.colSil});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 361);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(25, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.Width = 60;
            // 
            // colAd
            // 
            this.colAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAd.DataPropertyName = "Ad";
            this.colAd.HeaderText = "Ad";
            this.colAd.Name = "colAd";
            // 
            // colSoyad
            // 
            this.colSoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoyad.DataPropertyName = "Soyad";
            this.colSoyad.HeaderText = "Soyad";
            this.colSoyad.Name = "colSoyad";
            // 
            // colCinsiyet
            // 
            this.colCinsiyet.DataPropertyName = "Cinsiyet";
            this.colCinsiyet.HeaderText = "Cinsiyet";
            this.colCinsiyet.Name = "colCinsiyet";
            // 
            // colDetay
            // 
            this.colDetay.HeaderText = "Detay";
            this.colDetay.Name = "colDetay";
            this.colDetay.Text = "Detay";
            this.colDetay.UseColumnTextForButtonValue = true;
            // 
            // colSil
            // 
            this.colSil.HeaderText = "Sil";
            this.colSil.Name = "colSil";
            this.colSil.Text = "Sil";
            this.colSil.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoyad;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCinsiyet;
        private System.Windows.Forms.DataGridViewButtonColumn colDetay;
        private System.Windows.Forms.DataGridViewButtonColumn colSil;
    }
}

