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

namespace WindowsFormsApplication64
{
    public partial class SIFREONAYI : Form
    {
        public SIFREONAYI()
        {
            InitializeComponent();
        }
        void GİRİS()
        {

            MUSTERI a = new MUSTERI();
            sifre.Focus();
            string yol = "Data Source=DESKTOP-KK7V7H8\\;Initial Catalog = MTAKIP; Integrated Security = True";
            SqlConnection baglanti = new SqlConnection(yol);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM KULLANICILAR WHERE SIFRE='" + sifre.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            Müşteri_Ekle x = new Müşteri_Ekle();
            if (dr.Read())
            {



               DialogResult= DialogResult.OK;
                
                this.Visible = false;

            }

            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();

        }
        private void Giriş_Click(object sender, EventArgs e)
        {
            GİRİS();
        }

        private void SilmeOnayı_Load(object sender, EventArgs e)
        {
            Giriş.Font = new Font(Giriş.Font, FontStyle.Bold);
           label2.Font = new Font(label2.Font, FontStyle.Bold);
            İptal.Font = new Font(İptal.Font, FontStyle.Bold);

        }

        private void İptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
