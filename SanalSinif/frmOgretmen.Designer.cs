namespace SanalSinif
{
    partial class frmOgretmen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soruButton = new System.Windows.Forms.Button();
            this.resimButton = new System.Windows.Forms.Button();
            this.cevapBox = new System.Windows.Forms.TextBox();
            this.kategoriBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soruBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.silButton = new System.Windows.Forms.Button();
            this.konuEkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // soruButton
            // 
            this.soruButton.Location = new System.Drawing.Point(317, 398);
            this.soruButton.Name = "soruButton";
            this.soruButton.Size = new System.Drawing.Size(83, 40);
            this.soruButton.TabIndex = 3;
            this.soruButton.Text = "Soruyu Ekle";
            this.soruButton.UseVisualStyleBackColor = true;
            this.soruButton.Click += new System.EventHandler(this.SoruButton_Click);
            // 
            // resimButton
            // 
            this.resimButton.Location = new System.Drawing.Point(228, 398);
            this.resimButton.Name = "resimButton";
            this.resimButton.Size = new System.Drawing.Size(83, 40);
            this.resimButton.TabIndex = 4;
            this.resimButton.Text = "Resim Ekle";
            this.resimButton.UseVisualStyleBackColor = true;
            this.resimButton.Click += new System.EventHandler(this.ResimButton_Click);
            // 
            // cevapBox
            // 
            this.cevapBox.Location = new System.Drawing.Point(183, 290);
            this.cevapBox.Multiline = true;
            this.cevapBox.Name = "cevapBox";
            this.cevapBox.Size = new System.Drawing.Size(447, 37);
            this.cevapBox.TabIndex = 5;
            // 
            // kategoriBox
            // 
            this.kategoriBox.Location = new System.Drawing.Point(183, 348);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(447, 20);
            this.kategoriBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(125, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cevap:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Konu ID:";
            // 
            // soruBox
            // 
            this.soruBox.Location = new System.Drawing.Point(183, 197);
            this.soruBox.Multiline = true;
            this.soruBox.Name = "soruBox";
            this.soruBox.Size = new System.Drawing.Size(447, 72);
            this.soruBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 230);
            this.dataGridView1.TabIndex = 10;
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(406, 398);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(83, 40);
            this.silButton.TabIndex = 11;
            this.silButton.Text = "Soruyu Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // konuEkleBtn
            // 
            this.konuEkleBtn.Location = new System.Drawing.Point(495, 398);
            this.konuEkleBtn.Name = "konuEkleBtn";
            this.konuEkleBtn.Size = new System.Drawing.Size(83, 40);
            this.konuEkleBtn.TabIndex = 13;
            this.konuEkleBtn.Text = "Konular";
            this.konuEkleBtn.UseVisualStyleBackColor = true;
            this.konuEkleBtn.Click += new System.EventHandler(this.KonuEkleBtn_Click);
            // 
            // frmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 686);
            this.Controls.Add(this.konuEkleBtn);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategoriBox);
            this.Controls.Add(this.cevapBox);
            this.Controls.Add(this.resimButton);
            this.Controls.Add(this.soruButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.soruBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 725);
            this.MinimumSize = new System.Drawing.Size(800, 725);
            this.Name = "frmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Paneli";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button soruButton;
        private System.Windows.Forms.Button resimButton;
        private System.Windows.Forms.TextBox cevapBox;
        private System.Windows.Forms.TextBox kategoriBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soruBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button konuEkleBtn;
    }
}