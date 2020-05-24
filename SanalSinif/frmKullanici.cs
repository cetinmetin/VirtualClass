using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalSinif
{
    public partial class frmKullanici : Form
    {
        public static int ogrenciID;
        public frmKullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TR4MTD3\\SQLEXPRESS;Initial Catalog=virtualClassDB;Integrated Security=True;Pooling=False");
        private void GirisButton_Click(object sender, EventArgs e)
        {
            
            string ad = kullaniciBox.Text;
            string pass = sifreBox.Text;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT yetki,Id FROM girisBilgileri WHERE kullaniciAdi = '" + ad + "' AND sifre='" + pass + "'";
            SqlDataReader rdr = cmd.ExecuteReader();
            
            if (rdr.Read())
             {
                MessageBox.Show("Giris Basarili");

                if (rdr["yetki"].ToString() == "1")
                { 
                    frmOgretmen ogretmen = new frmOgretmen();
                    ReActivator(ogretmen);
                }
                else if (rdr["yetki"].ToString() == "2")
                {   
                    frmOgrenci ogrenci = new frmOgrenci();
                    ogrenciID=(Int32.Parse(rdr["Id"].ToString()));
                    
                    ReActivator(ogrenci);
                }
             }
             else
             {
                MessageBox.Show("Bilgileriniz Hatalı !");
                kullaniciBox.Text = "";
                sifreBox.Text = "";
             }
            baglanti.Close();
        }
        public void ReActivator(Form panelName)
        {
            this.Hide();
            if(panelName.ShowDialog() != DialogResult.OK)
            {
                kullaniciBox.Text = "";
                sifreBox.Text = "";
                this.Show();
            }
        }

       

        private void FrmKullanici_Load(object sender, EventArgs e)
        {

        }
    }
}
