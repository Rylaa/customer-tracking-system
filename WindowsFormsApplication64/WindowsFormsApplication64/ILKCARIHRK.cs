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
using System.IO;

namespace WindowsFormsApplication64
{
    public partial class ILKCARIHRK : Form
    {
        public ILKCARIHRK()
        {
            InitializeComponent();
        }
        string yol = "Data Source=DESKTOP-KK7V7H8\\;Initial Catalog = MTAKIP; Integrated Security = True";
        SqlConnection baglanti;
        
        SqlCommand komut = new SqlCommand();
        DataTable tablo = new DataTable();
        public int musteriid = 0;
       
        private void SA_KAYDET_Click(object sender, EventArgs e)
        {
            INSERT();
            
        }
        void INSERT()
        {
            baglanti = new SqlConnection(yol);

            try
            {
                if (LBISLEMTURU.Text == "Borç Dekontu")
                {
                    baglanti.Open();
                    if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
                    komut = new SqlCommand("INSERT INTO CARIHRK(TARIH,ISLEMTURU,MUSTERIADI,ACIKLAMA,VERILEN,CARIID) VALUES (@TARIH,@ISLEMTURU,@MUSTERIADI,@ACIKLAMA,@VERILEN,@CARIID)", baglanti);
                    komut.Parameters.Add("@TARIH", SqlDbType.Date).Value = ED_TARIH.Text;
                    komut.Parameters.Add("@ISLEMTURU", SqlDbType.Char).Value = LBISLEMTURU.Text;
                    komut.Parameters.Add("@MUSTERIADI", SqlDbType.Char).Value = LBMUSTERIADI.Text;
                    komut.Parameters.Add("@ACIKLAMA", SqlDbType.Char).Value = ED_ACIKLAMA.Text;
                    komut.Parameters.Add("@VERILEN", SqlDbType.Char).Value = TXTTUTAR.Text;
                    komut.Parameters.Add("@CARIID", SqlDbType.Int).Value = musteriid;
                    komut.ExecuteNonQuery();
                    komut.Dispose();

                }
                else if (LBISLEMTURU.Text == "Alacak Dekontu")
                {
                    baglanti.Open();
                    if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
                    komut = new SqlCommand("INSERT INTO CARIHRK(TARIH,ISLEMTURU,MUSTERIADI,ACIKLAMA,VERILEN,CARIID) VALUES (@TARIH,@ISLEMTURU,@MUSTERIADI,@ACIKLAMA,@VERILEN,@CARIID)", baglanti);
                    komut.Parameters.Add("@TARIH", SqlDbType.Date).Value = ED_TARIH.Text;
                    komut.Parameters.Add("@ISLEMTURU", SqlDbType.Char).Value = LBISLEMTURU.Text;
                    komut.Parameters.Add("@MUSTERIADI", SqlDbType.Char).Value = LBMUSTERIADI.Text;
                    komut.Parameters.Add("@ACIKLAMA", SqlDbType.Char).Value = ED_ACIKLAMA.Text;
                    komut.Parameters.Add("@VERILEN", SqlDbType.Char).Value = TXTTUTAR.Text;
                    komut.Parameters.Add("@CARIID", SqlDbType.Int).Value = musteriid;
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                }
                else
                {
                    MessageBox.Show("Hatalı İşlem","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                }

                MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Edildi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              
                this.Close();
                double toplamverilen = 0;
                double toplamalinan = 0;

                komut = new SqlCommand("SELECT  SUM(VERILEN) AS VERILEN, SUM(ALINAN) AS ALINAN FROM CARIHRK  WHERE CARIID=@CARIID", baglanti);
                komut.Parameters.Add("@CARIID", SqlDbType.Int).Value = musteriid;
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        toplamverilen = Convert.ToDouble(dr["VERILEN"]);
                    }
                    catch (Exception)
                    {

                        toplamverilen = 0;
                    }
                    try
                    {
                        toplamalinan = Convert.ToDouble(dr["ALINAN"]);
                    }
                    catch (Exception)
                    {

                        toplamalinan = 0;
                    }
                    komut.Dispose();
                  
                }
                dr.Close();
                komut = new SqlCommand("UPDATE MUSTERILER SET TOPLAMVERILEN=@TOPLAMVERILEN,TOPLAMALINAN=@TOPLAMALINAN,BAKIYE=@BAKIYE WHERE ID=@ID", baglanti);
                komut.Parameters.Add("@TOPLAMVERILEN", SqlDbType.Float).Value = toplamverilen;
             
                komut.Parameters.Add("@TOPLAMALINAN", SqlDbType.Float).Value = toplamalinan;
                komut.Parameters.Add("@BAKIYE", SqlDbType.Float).Value = toplamverilen=-toplamverilen;
                komut.Parameters.Add("@ID", SqlDbType.Int).Value = musteriid;

                komut.ExecuteNonQuery();
                komut.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Hatası" + ex.Message);
                baglanti.Close();
                komut.Dispose();
            }
            baglanti.Close();
        }
        void DELETE()
        {

        }


        private void SA_İPTAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ILKCARIHRK_Load(object sender, EventArgs e)
        {

            
        }
    }
}
