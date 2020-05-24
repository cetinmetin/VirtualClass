namespace SanalSinif
{
    partial class frmTest
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
            this.labelSoru = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnBos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSoru
            // 
            this.labelSoru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoru.Location = new System.Drawing.Point(0, 0);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(504, 311);
            this.labelSoru.TabIndex = 1;
            this.labelSoru.Text = "soru";
            this.labelSoru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 239);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 40);
            this.btn1.TabIndex = 2;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(109, 239);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 40);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(205, 239);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 40);
            this.btn3.TabIndex = 4;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(301, 239);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 40);
            this.btn4.TabIndex = 5;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btnBos
            // 
            this.btnBos.Location = new System.Drawing.Point(397, 239);
            this.btnBos.Name = "btnBos";
            this.btnBos.Size = new System.Drawing.Size(90, 40);
            this.btnBos.TabIndex = 6;
            this.btnBos.Text = "Boş Bırak";
            this.btnBos.UseVisualStyleBackColor = true;
            this.btnBos.Click += new System.EventHandler(this.BtnBos_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 311);
            this.Controls.Add(this.btnBos);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.labelSoru);
            this.MaximumSize = new System.Drawing.Size(520, 350);
            this.MinimumSize = new System.Drawing.Size(520, 350);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnBos;
    }
}