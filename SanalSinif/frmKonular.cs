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
    public partial class frmKonular : Form
    {
        public frmKonular()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TR4MTD3\\SQLEXPRESS;Initial Catalog=virtualClassDB;Integrated Security=True;Pooling=False");
        private void FrmKonular_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM konular";
            SqlDataAdapter adpr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "konular");
            dataGridView1.DataSource = ds.Tables["konular"];
            //dataGridView1.Columns[0].Visible = false;
            baglanti.Close();
        }
    }
}
