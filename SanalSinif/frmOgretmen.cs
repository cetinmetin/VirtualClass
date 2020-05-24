using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalSinif
{
    public partial class frmOgretmen : Form
    {
        string imgPath;
        public frmOgretmen()
        {
            InitializeComponent();
            Listele();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TR4MTD3\\SQLEXPRESS;Initial Catalog=virtualClassDB;Integrated Security=True;Pooling=False");
        private void SoruButton_Click(object sender, EventArgs e)
        {
            string soru = soruBox.Text.Trim();
            string cevap = cevapBox.Text.Trim();
            string konu = kategoriBox.Text.Trim();
            if (soru != "" && cevap != "" && konu != "")
            {
                //veritabanı işlemleri
                baglanti.Open();
                SqlCommand cmd1 = new SqlCommand();
                SqlCommand cmd2 = new SqlCommand();
                cmd1.Connection = baglanti;
                cmd2.Connection = baglanti;

                if (pictureBox1.Image != null)
                {
                    cmd1.CommandText = "INSERT INTO sorular(soru,dogru_cevap,soru_resim,konuid) VALUES('" + soru + "','" + cevap + "','" + imgPath + "','" + konu + "')";
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    /*cmd2.CommandText = "INSERT INTO konular(id) VALUES('" + konu + "')";
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();*/

                }
                else
                {
                    cmd1.CommandText = "INSERT INTO sorular(soru,dogru_cevap,konuid) VALUES('" + soru + "','" + cevap + "','" + konu + "')";
                   /* cmd2.CommandText = "INSERT INTO konular(id) VALUES('" + konu + "')";
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();*/
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                }
                baglanti.Close();
                Listele();
                MessageBox.Show("Soru Başarıyla Eklendi");
                soruBox.Text = "";
                cevapBox.Text = "";
                kategoriBox.Text = "";
                pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Değerler Girin");
                soruBox.Text = "";
                cevapBox.Text = "";
                kategoriBox.Text = "";
                pictureBox1.Image = null;
            }
        }

        private void ResimButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                imgPath = open.FileName;
            }
        }
        public void Listele()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM sorular";
            SqlDataAdapter adpr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "sorular");
            dataGridView1.DataSource = ds.Tables["sorular"];
           // dataGridView1.Columns[0].Visible = false;
            baglanti.Close();
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd1.Connection = baglanti;
            cmd2.Connection = baglanti;
            if (dataGridView1.CurrentRow != null)
            {
                cmd2.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd2.CommandText = "DELETE FROM sonuclar WHERE soruid=@numara";
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                cmd1.CommandText = "DELETE FROM sorular WHERE id=@numara";
                cmd1.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                MessageBox.Show("Soru Silindi");
            }
            else
            {
                MessageBox.Show("Soru Bulunamadı");
            }
            baglanti.Close();
            Listele();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

        }
        private void KonuEkleBtn_Click(object sender, EventArgs e)
        {
            frmKonular konular = new frmKonular();
            konular.Show();
        }
    }
}
