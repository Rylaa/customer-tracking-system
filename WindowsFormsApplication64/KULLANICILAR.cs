using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication64
{
    public partial class  KULLANICILAR : Form
    {
        public KULLANICILAR()
        {
            InitializeComponent();
        }

        SqlConnection baglantı;
        string yol = "Data Source=DESKTOP-KK7V7H8\\;Initial Catalog = MTAKIP; Integrated Security = True";
        private void GİRİŞ_Click(object sender, EventArgs e)
        {
            MUSTERI frKisiler = new MUSTERI();
            baglantı = new SqlConnection(yol);
            baglantı.Open();


            SqlCommand Komut = new SqlCommand("SELECT * FROM KULLANICILAR WHERE KULLANICIADI='" + kullanıcıadı.Text + "'AND SIFRE='" + sıfre.Text + "'", baglantı);
            SqlDataReader dr = Komut.ExecuteReader();

           

            if (dr.Read())
                {
           
                Komut.Dispose();
                baglantı.Close();
                this.Visible = false;
                frKisiler.Show();
               
            }

            else
            {
                MessageBox.Show("HATALI GİRİS YAPTINIZ!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }
        
 //BUTTONLARIN YAZI TİPLERİ     
        private void Giris_Load(object sender, EventArgs e)
        {
            GIR.Font = new Font(GIR.Font, FontStyle.Bold);
            kullanıcıadı.Focus();
         
                }
//İptal Buttonu
        private void İPTAL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
