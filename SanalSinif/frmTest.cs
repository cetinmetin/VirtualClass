using System;
using System.Collections;
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
    public unsafe partial class frmTest : Form
    {

        Random rnd = new Random();
        int[] secilenKonular = new int[4];
        List<string> soruListesi = new List<string>();
        List<string> cevapListesi = new List<string>();
        List<int> tumKonular = new List<int>();
        List<Button> siklar = new List<Button>();
        List<int> soruIDListesi = new List<int>();
        List<int> konuIDListesi = new List<int>();
        List<int> dogruSayisi = new List<int>();
        int yanlisSayisi;
        List<int> basarisizKonu = new List<int>();
        int girenID;
        int dogruSikNo;
        int dongu=0;
        DateTime localDate;
        int[] yasakliKonu = new int[4];
        int randomsayi=0;
        string format = "yyyy-MM-dd HH:mm:ss";
        public frmTest()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TR4MTD3\\SQLEXPRESS;Initial Catalog=virtualClassDB;Integrated Security=True;Pooling=False");
        private void FrmTest_Load(object sender, EventArgs e)
        {
            localDate = DateTime.Now;
            girenID = frmKullanici.ogrenciID;
            SqlCommand komut = new SqlCommand(("select * from sonuclar where userid=" + girenID), baglanti);
            baglanti.Open();
            SqlDataReader sdr = komut.ExecuteReader();
            var data = sdr.Read();
            baglanti.Close();
            if (data == true)
            {
                int basarisiz=0;
                SqlCommand komut3 = new SqlCommand("select basarisizKonu from girisBilgileri where Id="+girenID, baglanti);
                baglanti.Open();
                SqlDataReader sdr3 = komut3.ExecuteReader();
                while(sdr3.Read())
                    basarisiz=((int)sdr3["basarisizKonu"]);
                
                baglanti.Close();
                genelTest(basarisiz);
            }
            else
            {
                ilkTest();
            }

        }
        public void genelTest(int basarisizID)
        {
            SqlCommand komut = new SqlCommand("select id from konular", baglanti);
            baglanti.Open();
            SqlDataReader sdr = komut.ExecuteReader();
            while (sdr.Read())
            {
                tumKonular.Add((int)sdr["id"]);
            }
            baglanti.Close();
            for (int i = 0; i < 4; i++)
            {
                randomsayi = rnd.Next(1, tumKonular.Count + 1);
                for (int j = 0; j < 4; j++)
                {

                    while (randomsayi == yasakliKonu[j])
                    {
                        j = 0;
                        randomsayi = rnd.Next(1, tumKonular.Count + 1);
                    }
                }
                secilenKonular[i] = tumKonular[randomsayi - 1];
                yasakliKonu[i] = tumKonular[randomsayi - 1];

            }
            for (int i = 0; i < secilenKonular.Length; i++)
            {
                SqlCommand sorular = new SqlCommand("select top(4) * from sorular where konuid =" + secilenKonular[i] + "order by NEWID()", baglanti);
                baglanti.Open();
                SqlDataReader sonuc = sorular.ExecuteReader();
                while (sonuc.Read())
                {
                    //System.Diagnostics.Debug.WriteLine("Soru: " + sonuc["soru"].ToString());
                    soruListesi.Add(sonuc["soru"].ToString());
                    cevapListesi.Add(sonuc["dogru_cevap"].ToString());
                    soruIDListesi.Add((int)sonuc["id"]);
                    konuIDListesi.Add((int)sonuc["konuid"]);
                }
                sonuc.Close();
                sorular.CommandText = "select top(1) * from sorular where konuid =" + basarisizID;
                sorular.ExecuteNonQuery();
                SqlDataReader sonuc2 = sorular.ExecuteReader();
                while (sonuc2.Read())
                {
                    //System.Diagnostics.Debug.WriteLine("Soru: " + sonuc["soru"].ToString());
                    soruListesi.Add(sonuc2["soru"].ToString());
                    cevapListesi.Add(sonuc2["dogru_cevap"].ToString());
                    soruIDListesi.Add((int)sonuc2["id"]);
                    konuIDListesi.Add((int)sonuc2["konuid"]);
                }
                baglanti.Close();
            }
            siklar.Add(btn1);
            siklar.Add(btn2);
            siklar.Add(btn3);
            siklar.Add(btn4);

            Sinav(ref dongu);
            MessageBox.Show("" + soruListesi.Count);

        }
        
        public void ilkTest()
        {
                SqlCommand komut = new SqlCommand("select id from konular", baglanti);
                baglanti.Open();
                SqlDataReader sdr = komut.ExecuteReader();
                while (sdr.Read())
                {
                    tumKonular.Add((int)sdr["id"]);
                }
                baglanti.Close();

            
                for (int i = 0; i < 4; i++)
                {
                randomsayi = rnd.Next(1, tumKonular.Count+1);
                for (int j = 0; j <4; j++){

                    while (randomsayi == yasakliKonu[j])
                    {
                        j = 0;
                        randomsayi = rnd.Next(1, tumKonular.Count+1);
                    }
                }
                secilenKonular[i] = tumKonular[randomsayi-1];
                yasakliKonu[i] = tumKonular[randomsayi-1];

            }

            //System.Diagnostics.Debug.WriteLine(secilenKonular);
            for (int i = 0; i < secilenKonular.Length; i++)
                {
                    SqlCommand sorular = new SqlCommand("select top(5) * from sorular where konuid =" + secilenKonular[i] + "order by NEWID()", baglanti);
                    baglanti.Open();
                    SqlDataReader sonuc = sorular.ExecuteReader();
                    while (sonuc.Read())
                    {
                        //System.Diagnostics.Debug.WriteLine("Soru: " + sonuc["soru"].ToString());
                        soruListesi.Add(sonuc["soru"].ToString());
                        cevapListesi.Add(sonuc["dogru_cevap"].ToString());
                        soruIDListesi.Add((int)sonuc["id"]);
                        konuIDListesi.Add((int)sonuc["konuid"]);
                    }
                    baglanti.Close();
                }
                siklar.Add(btn1);
                siklar.Add(btn2);
                siklar.Add(btn3);
                siklar.Add(btn4);
                
                Sinav(ref dongu);
                MessageBox.Show(""+soruListesi.Count);
                //baglanti.Close();
        }
        public void Sinav(ref int deger)
        {
            if (deger < soruListesi.Count)
            {
                for (int i = dongu; i < soruListesi.Count; i++)
                {
                    labelSoru.Text = soruListesi[dongu];
                    var cevap = cevapListesi[dongu];
                    int dogrusik = rnd.Next(0, 4);
                    siklar[dogrusik].Text = cevap;


                    int count = 0;
                    int yanlisCevap = 0;
                    int[] atanacakYanlisCevaplar = new int[3] { 0, 0, 0 };
                    while (true)
                    {
                        yanlisCevap = Int32.Parse(cevapListesi[rnd.Next(0, (soruListesi.Count - 1))]);
                        if (atanacakYanlisCevaplar[0] != yanlisCevap &&
                            atanacakYanlisCevaplar[1] != yanlisCevap &&
                            atanacakYanlisCevaplar[2] != yanlisCevap &&
                            yanlisCevap != Int32.Parse(cevap))
                        {
                            atanacakYanlisCevaplar[count] = yanlisCevap;
                            count++;
                        }
                        if (count == 3)
                        {
                            break;
                        }
                    }
                    count = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        if (j == dogrusik) { continue; }
                        siklar[j].Text = atanacakYanlisCevaplar[count].ToString();
                        count++;
                    }
                    dogruSikNo = dogrusik;

                }
                deger = deger + 1;
            }
            else
            {
                SqlCommand komut = new SqlCommand(("select top(20) * from sonuclar where userid="+girenID + "order by id DESC"), baglanti);
                baglanti.Open();
                SqlDataReader sdr = komut.ExecuteReader();
                while (sdr.Read())
                {
                    if ((int)sdr["istrue"] == 1)
                        dogruSayisi.Add((int)sdr["istrue"]);
                    else if ((int)sdr["istrue"] == 2)
                        basarisizKonu.Add((int)sdr["konuid"]);
                }
                baglanti.Close();

                int basarisiz = (int)FindMode(basarisizKonu);
                string basarisizKonuAdi="";
                SqlCommand komut2 = new SqlCommand(("select konuadi from konular where id=" + basarisiz), baglanti);
                baglanti.Open();
                SqlDataReader sdr2 = komut2.ExecuteReader();
                while (sdr2.Read())
                {
                        basarisizKonuAdi=(sdr2["konuadi"].ToString());
                }
                baglanti.Close();
                this.Hide();
                yanlisSayisi = (20 - dogruSayisi.Count);
                frmSinavSonucu sinavSonucu = new frmSinavSonucu();
                MessageBox.Show("Sinav Tamamlandi");
                sinavSonucu.labelOID.Text = girenID.ToString();
                sinavSonucu.labelDSayisi.Text = (dogruSayisi.Count).ToString();
                sinavSonucu.labelYSayisi.Text = (yanlisSayisi).ToString();
                sinavSonucu.labelBsrszKonu.Text = basarisizKonuAdi.ToString();
                string guncel = ("UPDATE girisBilgileri SET basarisizKonu= '" + basarisiz + "'WHERE Id= " + girenID);
                SqlCommand guncelle = new SqlCommand(guncel, baglanti);
                baglanti.Open();
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                sinavSonucu.Show();
            }
        }
        public int? FindMode(List<int> sample)
        {
            if (sample == null || sample.Count == 0)
            {
                return null;
            }

            List<int> indices = new List<int>();
            sample.Sort();

            //Calculate the Discrete derivative of the sample and record the indices
            //where it is positive.
            for (int i = 0; i < sample.Count; i++)
            {
                int derivative;

                if (i == sample.Count - 1)
                {
                    //This ensures that there is a positive derivative for the
                    //last item in the sample. Without this, the mode could not
                    //also be the largest value in the sample.
                    derivative = int.MaxValue - sample[i];
                }
                else
                {
                    derivative = sample[i + 1] - sample[i];
                }

                if (derivative > 0)
                {
                    indices.Add(i + 1);
                }
            }

            int maxDerivative = 0, maxDerivativeIndex = -1;

            //Calculate the discrete derivative of the indices, recording its
            //maxima and index.
            for (int i = -1; i < indices.Count - 1; i++)
            {
                int derivative;

                if (i == -1)
                {
                    derivative = indices[0];
                }
                else
                {
                    derivative = indices[i + 1] - indices[i];
                }

                if (derivative > maxDerivative)
                {
                    maxDerivative = derivative;
                    maxDerivativeIndex = i + 1;
                }
            }

            //The mode is then the value of the sample indexed by the
            //index of the largest derivative.
            return sample[indices[maxDerivativeIndex] - 1];
        }

        private void VeritabaniSonucYaz(int istrue)
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = baglanti;
            cmd1.CommandText = "INSERT INTO sonuclar(userid,soruid,konuid,istrue,solve_date) VALUES('" + girenID + "','" + soruIDListesi[(dongu - 1)] + "','" + konuIDListesi[(dongu-1)] + "','" + istrue + "','" + localDate.ToString(format) + "')";
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            baglanti.Close();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
           
            if (dogruSikNo == 0)
            {
                VeritabaniSonucYaz(1);
                //MessageBox.Show("dogru " + dongu);
                Sinav(ref dongu);

            }
            else
            {
                VeritabaniSonucYaz(2);
                //MessageBox.Show("Yanlis " + dongu);
                
                Sinav(ref dongu);
            }
            
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (dogruSikNo == 1)
            {
                VeritabaniSonucYaz(1);
                //MessageBox.Show("dogru " + dongu);
                
                Sinav(ref dongu);
            }
            else
            {
                VeritabaniSonucYaz(2);
                //MessageBox.Show("Yanlis " + dongu);
                
                Sinav(ref dongu);
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (dogruSikNo == 2)
            {
                VeritabaniSonucYaz(1);
                //MessageBox.Show("dogru " + dongu);
                
                Sinav(ref dongu);
            }
            else
            {
                VeritabaniSonucYaz(2);
                //MessageBox.Show("Yanlis " + dongu);
                
                Sinav(ref dongu);
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (dogruSikNo == 3)
            {
                VeritabaniSonucYaz(1);
                //MessageBox.Show("dogru " + dongu);
                
                Sinav(ref dongu);
            }
            else
            {
                VeritabaniSonucYaz(2);
                //MessageBox.Show("Yanlis " + dongu);
                
                Sinav(ref dongu);
            }
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            VeritabaniSonucYaz(2);
            Sinav(ref dongu);
        }
    }
}
