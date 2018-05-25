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
    public partial class MUSTERIHAREKETLERI : Form
    {
        public MUSTERIHAREKETLERI()
        {
            InitializeComponent();
        }
        public int musteriid ;

        SqlConnection baglanti = new SqlConnection();
        SqlCommand komut = new SqlCommand();
        string yol = "Data Source=DESKTOP-KK7V7H8\\;Initial Catalog = MTAKIP; Integrated Security = True";
     public   void musteribilgileri()
        {
            SqlConnection baglanti = new SqlConnection(yol);
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            SqlDataReader dr = (null);
            komut = new SqlCommand("SELECT * FROM MUSTERILER WHERE ID=@ID", baglanti);
            komut.Parameters.Add("@ID", SqlDbType.Int).Value = musteriid;
            komut.ExecuteNonQuery();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                ED_KODU.Text = (dr["ID"].ToString());
                ED_MUSTERIADI.Text = (dr["ADISOYADI"].ToString());
                ED_GRUPADI.Text = (dr["GRUPADI"].ToString());
                ED_VERGİNO.Text = (dr["VERGIDAIRESI"].ToString() + "Vergi No:" + dr["VERGINO"]);
            }
            dr.Close();
            komut.Dispose();
            baglanti.Close();
        }
      public  void listele()
        {
            SqlConnection baglanti = new SqlConnection(yol);
            baglanti.Open();
           
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM CARIHRK WHERE CARIID='"+musteriid+"'", baglanti);
            DataSet ds = new DataSet();
            adpt.Fill(ds,"CARIHRK");
            baglanti.Close();
            adpt.Dispose();
            dataGridView1.DataSource = ds.Tables["CARIHRK"];
        }
        private void MUSTERIHAREKETLERI_Load(object sender, EventArgs e)
        {
            listele();
            MUSTERI a = new MUSTERI();
            a.listele();
        }
        private void BORCLANDIR_Click_1(object sender, EventArgs e)
        {
            borclandır();
        }
        public void borclandır()
        {
            ILKCARIHRK ac = new ILKCARIHRK();
            ac.musteriid = musteriid;
            ac.LBKODU.Text = ED_KODU.Text;
            ac.LBMUSTERIADI.Text = ED_MUSTERIADI.Text;
            ac.LBISLEMTURU.Text = "Borç Dekontu";
            ac.ED_TARIH.Text = DateTime.Now.ToShortDateString();
            ac.ShowDialog();
            listele();
        }
        private void ALACAKLANDIR_Click(object sender, EventArgs e)
        {
            ILKCARIHRK ac = new ILKCARIHRK();
            ac.musteriid = musteriid;
            ac.LBKODU.Text = ED_KODU.Text;
            ac.LBMUSTERIADI.Text = ED_MUSTERIADI.Text;
            ac.LBISLEMTURU.Text = "Alacak Dekontu";
            ac.ED_TARIH.Text = DateTime.Now.ToShortDateString();
            ac.ShowDialog();
            listele();
           
        }
        void DELETE()
        {

           
                        try
                        {
                            SqlConnection baglanti = new SqlConnection(yol);
                            baglanti.Open();
                            komut = new SqlCommand("DELETE FROM CARIHRK WHERE ID=@SATIR");
                            komut.Parameters.AddWithValue("@SATIR", dataGridView1.CurrentRow.Cells[0].Value);
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            listele();
                            komut.Dispose();
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show("Kayıt Silinemedi!" + hata.Message);
                        }

         

        }




    }
}
