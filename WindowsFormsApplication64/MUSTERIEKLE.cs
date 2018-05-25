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
using System.Configuration;
using System.IO;


namespace WindowsFormsApplication64
{
    public partial class Müşteri_Ekle : Form
    {
 public Müşteri_Ekle()
        {
            InitializeComponent();
        }

        string yol = "Data Source=DESKTOP-KK7V7H8\\;Initial Catalog = MTAKIP; Integrated Security = True";

        SqlConnection baglanti;
        DataSet ds = new DataSet();
        SqlCommand komut =new SqlCommand();
        DataTable tablo = new DataTable();
        SqlDataAdapter adpt = new SqlDataAdapter();
        public string DURUMU = " ";
        public string Ressimpath = " ";
        public int ID = 0;
public void musteribilgileri()
        {

            MUSTERI a = new MUSTERI();
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            if (baglanti.State== ConnectionState.Closed) {baglanti.Open();}

            SqlDataReader dt = (null);
            komut =new SqlCommand("SELECT * FROM MUSTERILER WHERE ID=@ID",baglanti);
            komut.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            komut.ExecuteNonQuery();
            dt =komut.ExecuteReader();
            while  (dt.Read())
            {


                TXTADISOYADI.Text=(dt["ADISOYADI"].ToString());
                TXTGRUPADI.Text=(dt["GRUPADI"].ToString());
                TXTVERGIDAIRE.Text = (dt["VERGIDAIRESI"].ToString());
                TXTVERGINO.Text = (dt["VERGINO"].ToString());
                TXTTELEFON1.Text= (dt["TELEFON1"].ToString());
                TXTTELEFON2.Text= (dt["TELEFON2"].ToString());
                TXTFAX.Text= (dt["FAX"].ToString());
                TXTCEP.Text= (dt["CEPTELEFONU"].ToString());
                COMBOSEHIR.Text= (dt["SEHIR"].ToString());
                RICHADRESS.Text= (dt["ADRES"].ToString());
                TXTEMAIL.Text= (dt["EMAIL"].ToString());
                if ((dt["CINSIYET"].ToString() =="Bay")){ RADIOBAY.Checked=true; }
                else if ((dt["CINSIYET"].ToString() =="Bayan")){ RADIOBAYAN.Checked =true; }
                COMBODURUMU.Text= (dt["DURUMU"].ToString());



            }


            baglanti.Close();
                     
            }
public void GRUPADI ()
        {
            baglanti = new SqlConnection(yol);
            baglanti.Open();
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            SqlDataReader dr = (null);
            komut = new SqlCommand("SELECT GRUPADI FROM MUSTERILER", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if(!TXTGRUPADI.Items.Contains(dr["GRUPADI"].ToString()))
                    { TXTGRUPADI.Items.Add(dr["GRUPADI"].ToString()); }
               
            }
          
            baglanti.Close();


        }
        //void INSERT()
        //           {                                        //VERİ EKLEME KODLARI

        //            baglanti = new SqlConnection(yol);

        //            string verıtabanı = "INSERT INTO MUSTERILER(GRUPADI,SEHIR,ADISOYADI,TELEFON1,CEPTELEFONU,VERGIDAIRESI,VERGINO,TELEFON2,FAX,ADRES,EMAIL,CINSIYET,DURUMU) VALUES (@GRUPADI,@SEHIR,@ADISOYADI,@TELEFON1,@CEPTELEFONU,@VERGIDAIRESI,@VERGINO,@TELEFON2,@FAX,@ADRES,@EMAIL,@CINSIYET,@DURUMU)";

        //            komut = new SqlCommand(verıtabanı, baglanti);

        //            baglanti.Open();
        //            try
        //            {
        //                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }


        //                komut.Parameters.Add("@GRUPADI", SqlDbType.Char, 50).Value = TXTGRUPADI.Text;
        //                komut.Parameters.Add("@SEHIR", SqlDbType.Char, 50).Value = COMBOSEHIR.SelectedItem.ToString();
        //                komut.Parameters.Add("@ADISOYADI", SqlDbType.Char, 50).Value = TXTADISOYADI.Text;

        //                komut.Parameters.Add("@TELEFON1", SqlDbType.Char, 50).Value = TXTTELEFON1.Text;
        //                komut.Parameters.Add("@CEPTELEFONU", SqlDbType.Char, 50).Value = TXTCEP.Text;
        //                komut.Parameters.Add("@VERGIDAIRESI", SqlDbType.Char, 50).Value = TXTVERGIDAIRE.Text;
        //                komut.Parameters.Add("@VERGINO", SqlDbType.Char, 50).Value = TXTVERGINO.Text;

        //                komut.Parameters.Add("@TELEFON2", SqlDbType.Char, 50).Value = TXTTELEFON2.Text;
        //                komut.Parameters.Add("@FAX", SqlDbType.Char, 50).Value = TXTFAX.Text;

        //                komut.Parameters.Add("@ADRES", SqlDbType.Char, 50).Value = RICHADRESS.Text;
        //                komut.Parameters.Add("@EMAIL", SqlDbType.Char, 50).Value = TXTEMAIL.Text;
        //                if (RADIOBAY.Checked == true) { komut.Parameters.Add("@CINSIYET", SqlDbType.Char, 50).Value = "Bay"; }
        //                else if (RADIOBAYAN.Checked == true) { komut.Parameters.Add("@CINSIYET", SqlDbType.Char, 50).Value = "Bayan"; }
        //                komut.Parameters.Add("@DURUMU", SqlDbType.Char, 50).Value = COMBODURUMU.Text;
        //                komut.ExecuteNonQuery();
        //                MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Edildi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                komut.Dispose();
        //                baglanti.Close();
        //                temizle();
        //                MUSTERI a = new MUSTERI();
        //                a.listele();
        //                this.Close();

        //            }
        //            catch (Exception Hata)
        //            {
        //                                                    MessageBox.Show("Kayıt Hatası" + Hata.Message);
        //                                                    baglanti.Close();
        //                                                    komut.Dispose();

        //            }
        //            baglanti.Close();
        //            }
        void INSERT()
        {                                        //VERİ EKLEME KODLARI
            baglanti = new SqlConnection(yol);
            string verıtabanı = "INSERT INTO MUSTERILER(ADISOYADI,GRUPADI,SEHIR,VERGIDAIRESI,VERGINO,TELEFON1,TELEFON2,FAX,CEPTELEFONU,ADRES,EMAIL,CINSIYET,DURUMU) VALUES (@ADISOYADI,@GRUPADI,@SEHIR,@VERGIDAIRESI,@VERGINO,@TELEFON1,@TELEFON2,@FAX,@CEPTELEFONU,@ADRES,@EMAIL,@CINSIYET,@DURUMU)";
            komut = new SqlCommand(verıtabanı, baglanti);
            baglanti.Open();
            try
            {
                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }


                komut.Parameters.Add("@ADISOYADI", SqlDbType.Char, 50).Value = TXTADISOYADI.Text;
                komut.Parameters.Add("@GRUPADI", SqlDbType.Char, 50).Value = TXTGRUPADI.Text;
                komut.Parameters.Add("@SEHIR", SqlDbType.Char, 50).Value = COMBOSEHIR.SelectedText;
                komut.Parameters.Add("@VERGIDAIRESI", SqlDbType.Char, 50).Value = TXTVERGIDAIRE.Text;
                komut.Parameters.Add("@VERGINO", SqlDbType.Char, 50).Value = TXTVERGINO.Text;
                komut.Parameters.Add("@TELEFON1", SqlDbType.Char, 50).Value = TXTTELEFON1.Text;
                komut.Parameters.Add("@TELEFON2", SqlDbType.Char, 50).Value = TXTTELEFON2.Text;
                komut.Parameters.Add("@FAX", SqlDbType.Char, 50).Value = TXTFAX.Text;
                komut.Parameters.Add("@CEPTELEFONU", SqlDbType.Char, 50).Value = TXTCEP.Text;
                komut.Parameters.Add("@ADRES", SqlDbType.Char, 50).Value = RICHADRESS.Text;
                komut.Parameters.Add("@EMAIL", SqlDbType.Char, 50).Value = TXTEMAIL.Text;
                if (RADIOBAY.Checked == true) { komut.Parameters.Add("@CINSIYET", SqlDbType.Char, 50).Value = "Bay"; }
                else if (RADIOBAYAN.Checked == true) { komut.Parameters.Add("@CINSIYET", SqlDbType.Char, 50).Value = "Bayan"; }
                komut.Parameters.Add("@DURUMU", SqlDbType.Char, 50).Value = COMBODURUMU.Text;

                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Edildi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                komut.Dispose();
                baglanti.Close();
                temizle();
                MUSTERI a = new MUSTERI();
                a.listele();
                this.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show("Kayıt Hatası" + Hata.Message);
                baglanti.Close();
                komut.Dispose();

            }
            baglanti.Close();
        }

        void UPDATE()
            {

             SqlCommand updateyap = new SqlCommand("SELECT COUNT(*) FROM MUSTERILER where ID=@ID", baglanti);
            baglanti = new SqlConnection(yol);
            //---------------------------------------------------------------------------------------------------------------------------
            string verıtabanı = "UPDATE MUSTERILER SET ADISOYADI=@ADISOYADI,GRUPADI=@GRUPADI,VERGIDAIRESI=@VERGIDAIRESI,VERGINO=@VERGINO,TELEFON1=@TELEFON1,TELEFON2=@TELEFON2,FAX=@FAX,CEPTELEFONU=@CEPTELEFONU,SEHIR=@SEHIR,ADRES=@ADRES,EMAIL=@EMAIL,CINSIYET=@CINSIYET,DURUMU=@DURUMU WHERE ID=@ID";
             komut = new SqlCommand(verıtabanı, baglanti);
            baglanti.Open();
            try
            {
                if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }


                komut.Parameters.Add("@ADISOYADI", SqlDbType.Char, 50).Value = TXTADISOYADI.Text;
                komut.Parameters.Add("@GRUPADI", SqlDbType.Char, 50).Value = TXTGRUPADI.Text;
                komut.Parameters.Add("@VERGIDAIRESI", SqlDbType.Char, 50).Value = TXTVERGIDAIRE.Text;
                komut.Parameters.Add("@VERGINO", SqlDbType.Char, 50).Value = TXTVERGINO.Text;
                komut.Parameters.Add("@TELEFON1", SqlDbType.Char, 50).Value = TXTTELEFON1.Text;
                komut.Parameters.Add("@TELEFON2", SqlDbType.Char, 50).Value = TXTTELEFON2.Text;
                komut.Parameters.Add("@FAX", SqlDbType.Char, 50).Value = TXTFAX.Text;
                komut.Parameters.Add("@CEPTELEFONU", SqlDbType.Char, 50).Value = TXTCEP.Text;
                komut.Parameters.Add("@SEHIR", SqlDbType.Char, 50).Value = COMBOSEHIR.SelectedText;
                komut.Parameters.Add("@ADRES", SqlDbType.Char, 50).Value = RICHADRESS.Text;
                komut.Parameters.Add("@EMAIL", SqlDbType.Char, 50).Value = TXTEMAIL.Text;
                komut.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                if (RADIOBAY.Checked == true) { komut.Parameters.Add("@CINSIYET", SqlDbType.Char, 50).Value = "Bay"; }
                else if (RADIOBAYAN.Checked == true) { komut.Parameters.Add("@CINSIYET", SqlDbType.Char, 50).Value = "Bayan"; }
                komut.Parameters.Add("@DURUMU", SqlDbType.Char, 50).Value = COMBODURUMU.Text;
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Edildi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                komut.Dispose();
                baglanti.Close();
                temizle();
                MUSTERI a = new MUSTERI();
                a.listele();
                this.Close();
               
            }
            catch (Exception Hata)
            {

                MessageBox.Show("Kayıt Hatası" + Hata.Message);
                baglanti.Close();
                komut.Dispose();

            }
            }
        //-------------------------------------------------------------------------------------------------------------
 private void Müsteriekle_Click(object sender, EventArgs e)
            {
          
            if (TXTADISOYADI.Text == "")
            {
                MessageBox.Show("Lütfen Müşteri Adını Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // bu döngü kırılması gerek 
            }
            else
            {
                if (ID == 0) { INSERT(); }
                else if (ID > 0) { UPDATE(); }
            }
         
            }
 private void temizle()
            {
                                                    TXTADISOYADI.Text = "";
                                                    TXTVERGIDAIRE.Text = "";
                                                    TXTVERGINO.Text = "";
                                                    TXTTELEFON1.Text = "";
                                                    TXTCEP.Text = "";
                                                    TXTFAX.Text = "";
                                                    TXTEMAIL.Text = "";
                                                    RICHADRESS.Text = "";
                                                    COMBOSEHIR.SelectedIndex = -1;
                                                    RADIOBAY.Checked = false;
                                                    RADIOBAYAN.Checked = false;
                                                    COMBODURUMU.SelectedIndex = -1;
         
           }

 private void FotoEkle_Click(object sender, EventArgs e)
           {
            
                                                    OpenFileDialog dosya = new OpenFileDialog();
                                                    dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
           
                                                    if (dosya.ShowDialog() == DialogResult.OK)
                                                    {
                                                        PICTURFOTO1.Image = Image.FromFile(dosya.FileName);
                                                        Ressimpath = dosya.FileName.ToString();
                                                    }
                                                    FileStream fs = new FileStream(Ressimpath, FileMode.Open, FileAccess.Read);
                                                    BinaryReader br = new BinaryReader(fs);
                                                    byte[] resim = br.ReadBytes((int)fs.Length);
                                                    br.Close();
                                                    fs.Close();
                                                    SqlCommand kmt = new SqlCommand("INSERT INTO MUSTERILER(RESIM) VALUES (@image) ", baglanti);
                                                    kmt.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
                                                    try
                                                    {
                                                        baglanti.Open();
                                                        kmt.ExecuteNonQuery();
                                                        MessageBox.Show(" Veritabanına kayıt yapıldı.");

                                                    }

                                                    catch (Exception ex)

                                                    {

                                                        MessageBox.Show(ex.Message.ToString());

                                                    }
            



        }

 private void Müşteri_Ekle_Load(object sender, EventArgs e)
        {
                                                    //Durumu aktif seçili yapsın
                                                     COMBODURUMU.SelectedIndex = 0;
                                                     GRUPADI();
            yazitipleri();
        }

 private void KAPAT_Click(object sender, EventArgs e)
        {
                                                      this.Close();
        }
       
        void yazitipleri()
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label3.Font = new Font(label3.Font, FontStyle.Bold);
            label4.Font = new Font(label4.Font, FontStyle.Bold);
            label5.Font = new Font(label5.Font, FontStyle.Bold);
            label6.Font = new Font(label6.Font, FontStyle.Bold);
            label7.Font = new Font(label7.Font, FontStyle.Bold);
            label8.Font = new Font(label8.Font, FontStyle.Bold);
            label9.Font = new Font(label9.Font, FontStyle.Bold);
            label10.Font = new Font(label10.Font, FontStyle.Bold);
            label11.Font = new Font(label11.Font, FontStyle.Bold);
            label12.Font = new Font(label12.Font, FontStyle.Bold);
            label13.Font = new Font(label13.Font, FontStyle.Bold);




        }

    }
}
