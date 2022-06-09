namespace OdevTakipApp
{
    partial class frmDetay
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
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.chkTeslim = new System.Windows.Forms.CheckBox();
            this.dtpTeslim = new System.Windows.Forms.DateTimePicker();
            this.btnTamam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 154);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(103, 32);
            this.txtNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(148, 26);
            this.txtNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(103, 68);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(275, 26);
            this.txtAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(103, 104);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(275, 26);
            this.txtSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödev Konusu";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(13, 204);
            this.txtKonu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKonu.Multiline = true;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(365, 72);
            this.txtKonu.TabIndex = 1;
            // 
            // chkTeslim
            // 
            this.chkTeslim.AutoSize = true;
            this.chkTeslim.Location = new System.Drawing.Point(30, 286);
            this.chkTeslim.Name = "chkTeslim";
            this.chkTeslim.Size = new System.Drawing.Size(142, 24);
            this.chkTeslim.TabIndex = 2;
            this.chkTeslim.Text = "Teslim edildi Mi?";
            this.chkTeslim.UseVisualStyleBackColor = true;
            this.chkTeslim.CheckedChanged += new System.EventHandler(this.chkTeslim_CheckedChanged);
            // 
            // dtpTeslim
            // 
            this.dtpTeslim.Location = new System.Drawing.Point(178, 284);
            this.dtpTeslim.Name = "dtpTeslim";
            this.dtpTeslim.Size = new System.Drawing.Size(200, 26);
            this.dtpTeslim.TabIndex = 3;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(131, 352);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(131, 42);
            this.btnTamam.TabIndex = 4;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // frmDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 421);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.dtpTeslim);
            this.Controls.Add(this.chkTeslim);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetay";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.CheckBox chkTeslim;
        private System.Windows.Forms.DateTimePicker dtpTeslim;
        private System.Windows.Forms.Button btnTamam;
    }
}