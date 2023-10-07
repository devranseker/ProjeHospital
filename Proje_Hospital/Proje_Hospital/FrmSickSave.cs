using System;
// DB veri cekecegimiz icin ktphn unutma
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Proje_Hospital
{
    public partial class FrmSickSave : Form
    {
        public FrmSickSave()
        {
            InitializeComponent();
        }
        // Global (Genel) alan 
        // SQl Sınıfını (name == sqlBaglantilari) cagırmak lazım 
        sqlBaglantilari saveBaglanti = new sqlBaglantilari();    // saveBaglanti == sql Clasından nesne turettim 


        private void BtnKayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Sicks (SickName,SickSurname,SickIdentity,SickPhone,SickPassword,SickGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", saveBaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtName.Text);                                                                                                                      //saveBaglanti.baglanti() == nesnem.clasım  (baglanti clasımdan turettiigim saveBaglanti nesnem   
            komut.Parameters.AddWithValue("@p2", TxtSurname.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskPhone.Text);
            komut.Parameters.AddWithValue("@p5", TxtPassword.Text);
            komut.Parameters.AddWithValue("@p6", CmbGender.Text);
            komut.ExecuteNonQuery();  // sorguyu calıstırdık 

            // nesne turettgimiz icin nesne.class().Close();
            saveBaglanti.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleştirmiştir Şifreniz : " + TxtPassword.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Sql clasından open demistim ve her Close() icin ayrı ayrı claslarda yapmam gerek
            saveBaglanti.baglanti().Close();


        }
    }
}
