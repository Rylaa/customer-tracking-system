using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication64
{
    public partial class MUSTERI : Form
    {
        public MUSTERI()
        {
            InitializeComponent();
        }

        string yol = "Data Source=DESKTOP-KK7V7H8\\;Initial Catalog = MTAKIP; Integrated Security = True";
        SqlConnection baglanti;
        SqlDataAdapter adpt;
        DataSet ds;
        SqlCommand komut = new SqlCommand();
        DataTable tablo = new DataTable();
        public Boolean onay = false;

        public void listele()
        {
            //FORMUN LOADINA TABLOLARI ATMA İŞLEMİ
            baglanti = new SqlConnection(yol);//SQL BAĞLANTI
            adpt = new SqlDataAdapter("SELECT * FROM MUSTERILER", baglanti);
            baglanti.Open();
            ds = new DataSet();
            adpt.Fill(ds, "MUSTERILER");
            adpt.Dispose();
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["MUSTERILER"];//gridviewde gösterme

        }

        private void MUSTERI_Load(object sender, EventArgs e)
        {
            listele();
            GRUPARADOLDUR();
          SEMTDOLDUR();
            kapanıskontrol();
            //            yazıtipleri();
        }
        public void MUSTERIUPDATE()
        {
            Müşteri_Ekle a = new Müşteri_Ekle();
            int dataid = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
            a.ID = dataid;//ıd burdan alınacak 
            a.musteribilgileri();//  ıd ye göre textboxları vs. dolduracak
            a.ShowDialog();
            listele();
        }

        private void MüşteriUpdate_Click(object sender, EventArgs e)
        {
           
                        MUSTERIUPDATE();
        }

        private void MüsteriSil_Click(object sender, EventArgs e)
        {
            Müşteri_Ekle x = new Müşteri_Ekle();


            if (MessageBox.Show("Müşteri Silinecek Eminmisiniz?", "Sil Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SIFREONAYI a = new SIFREONAYI();
                a.ShowDialog();
                if (a.DialogResult == DialogResult.OK)
                {



                    {

                        try
                        {

                            
                            string kmt = "DELETE FROM MUSTERILER WHERE ID=@satir";
                            komut = new SqlCommand(kmt, baglanti);
                            komut.Parameters.AddWithValue("@satir", dataGridView1.CurrentRow.Cells[0].Value);
                            baglanti.Open();
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            listele();

                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Kayıt Silinemedi!" + hata.Message);
                        }

                    }


                }
            }
        }

        private void MüşteriEkle_Click(object sender, EventArgs e)
        {
           
                        Müşteri_Ekle a = new Müşteri_Ekle();
                        a.ID = 0;
                        a.ShowDialog();

                        listele();
        }
        void GRUPARADOLDUR()//Veri tabanındaki Grup adlarını ekledik
        {
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            SqlDataReader dr = (null);
            komut = new SqlCommand("SELECT GRUPADI FROM MUSTERILER", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ED_GRUPADIARA.Items.Add(dr["GRUPADI"].ToString());
            }

            baglanti.Close();
            komut.Dispose();
            dr.Close();
          }
        void SEMTDOLDUR()
        {
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            komut = new SqlCommand("SELECT SEHIR FROM MUSTERILER",baglanti);
           SqlDataReader dr = (null);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ED_SEMTARA.Items.Add(dr["SEHIR"].ToString());
            }
            baglanti.Close();

        }
        
        private void MUSTERIHAREKETLERI_Click(object sender, EventArgs e)
        {
            MUSTERIHAREKETLERI a = new MUSTERIHAREKETLERI();
            int dataid = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

            a.musteriid = dataid;
            a.musteribilgileri();
            listele();
            a.ShowDialog();
       
        }

        private void ARA_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("SELECT * FROM MUSTERILER WHERE ADISOYADI='"+ED_MUSTERIADIARAR.Text+"'");
            komut.ExecuteNonQuery();
            SqlDataReader dr = (null);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
        }
        void kapanıskontrol()
        {
            MUSTERIHAREKETLERI a = new MUSTERIHAREKETLERI();
            
            if(DialogResult==DialogResult.Yes)
            {
               
                listele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAPIM AŞAMASINDA Müşteri Haraketlerinden Ulaşınız");
            ILKCARIHRK ac = new ILKCARIHRK();
            MUSTERIHAREKETLERI a = new WindowsFormsApplication64.MUSTERIHAREKETLERI();
           
            ac.musteriid = a.musteriid;
            ac.LBISLEMTURU.Text = a.ED_KODU.Text;
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAPIM AŞAMASINDA Müşteri Haraketlerinden Ulaşınız");
            ILKCARIHRK ac = new ILKCARIHRK();
            MUSTERIHAREKETLERI a = new WindowsFormsApplication64.MUSTERIHAREKETLERI();

            ac.musteriid = a.musteriid;
            ac.LBISLEMTURU.Text = a.ED_KODU.Text;
            ac.ShowDialog();
        }

        private void EXTRE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAPIM AŞAMASINDA");
        }

        private void ED_MUSTERIADIARAR_TextChanged(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(yol);
            adpt = new SqlDataAdapter("SELECT * FROM MUSTERILER WHERE ADISOYADI Like '"+ ED_MUSTERIADIARAR.Text+"%'",baglanti);
            DataTable ds = new DataTable();
            adpt.Fill(ds);
            dataGridView1.DataSource = ds;

        }

        private void ED_GRUPADIARA_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(yol);
            adpt = new SqlDataAdapter("SELECT * FROM MUSTERILER WHERE GRUPADI Like '" + ED_GRUPADIARA.Text + "%'", baglanti);
            DataTable ds = new DataTable();
            adpt.Fill(ds);
            dataGridView1.DataSource = ds;
        }

        private void ED_SEMTARA_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(yol);
            adpt = new SqlDataAdapter("SELECT * FROM MUSTERILER WHERE SEHIR Like '" + ED_SEMTARA.Text + "%'", baglanti);
            DataTable ds = new DataTable();
            adpt.Fill(ds);
            dataGridView1.DataSource = ds;
        }
    }
}
