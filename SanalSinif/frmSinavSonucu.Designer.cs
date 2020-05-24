namespace SanalSinif
{
    partial class frmSinavSonucu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOID = new System.Windows.Forms.Label();
            this.labelDSayisi = new System.Windows.Forms.Label();
            this.labelYSayisi = new System.Windows.Forms.Label();
            this.labelBsrszKonu = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doğru Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yanlış Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Başarısız Olunan Konu:";
            // 
            // labelOID
            // 
            this.labelOID.AutoSize = true;
            this.labelOID.Location = new System.Drawing.Point(185, 85);
            this.labelOID.Name = "labelOID";
            this.labelOID.Size = new System.Drawing.Size(35, 13);
            this.labelOID.TabIndex = 4;
            this.labelOID.Text = "label5";
            // 
            // labelDSayisi
            // 
            this.labelDSayisi.AutoSize = true;
            this.labelDSayisi.Location = new System.Drawing.Point(185, 125);
            this.labelDSayisi.Name = "labelDSayisi";
            this.labelDSayisi.Size = new System.Drawing.Size(35, 13);
            this.labelDSayisi.TabIndex = 5;
            this.labelDSayisi.Text = "label6";
            // 
            // labelYSayisi
            // 
            this.labelYSayisi.AutoSize = true;
            this.labelYSayisi.Location = new System.Drawing.Point(185, 165);
            this.labelYSayisi.Name = "labelYSayisi";
            this.labelYSayisi.Size = new System.Drawing.Size(35, 13);
            this.labelYSayisi.TabIndex = 6;
            this.labelYSayisi.Text = "label7";
            // 
            // labelBsrszKonu
            // 
            this.labelBsrszKonu.AutoSize = true;
            this.labelBsrszKonu.Location = new System.Drawing.Point(185, 205);
            this.labelBsrszKonu.Name = "labelBsrszKonu";
            this.labelBsrszKonu.Size = new System.Drawing.Size(35, 13);
            this.labelBsrszKonu.TabIndex = 7;
            this.labelBsrszKonu.Text = "label8";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(109, 252);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(101, 37);
            this.btnTamam.TabIndex = 8;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.BtnTamam_Click);
            // 
            // frmSinavSonucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 341);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.labelBsrszKonu);
            this.Controls.Add(this.labelYSayisi);
            this.Controls.Add(this.labelDSayisi);
            this.Controls.Add(this.labelOID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(350, 380);
            this.MinimumSize = new System.Drawing.Size(350, 380);
            this.Name = "frmSinavSonucu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Sonucu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSinavSonucu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelOID;
        public System.Windows.Forms.Label labelDSayisi;
        public System.Windows.Forms.Label labelYSayisi;
        public System.Windows.Forms.Label labelBsrszKonu;
        private System.Windows.Forms.Button btnTamam;
    }
}