using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//DB kullacagım icin  Data.SqlClient;  unutmamam lazim 
using System.Data.SqlClient;
using Proje_Hospital;


namespace Proje_Hospital
{
    public partial class FrmSickLogin : Form
    {
        public FrmSickLogin()
        {
            InitializeComponent();
        }
        // Global alan 
        //Sql Clasına baglanıp dolaylı yolla DB'ye baglandım 
        sqlBaglantilari loginBaglan = new sqlBaglantilari();

        
        // Hasta Üye Oluyor 
        private void LinkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSickSave frmHastaKayit = new FrmSickSave();
            frmHastaKayit.Show();
            // Hide()  demedim cunku Arka planda kalsın 
        }

        //daha once uye olmus bir kisi simdi giris yapsın
        //DB'ten veri alarak giris yapama islemi name and  surname true ise giris yapsın 
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sicks Where SickIdentity = @p1 and SickPassword = @p2", loginBaglan.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtPassword.Text);
            // simdi veriOkuma(SqlDataReader) zamani bunlar true ise giris yapsin false ise yapmasın yani if-else var 
            SqlDataReader logindr = komut.ExecuteReader();

            //veri okudugu müddetce 
            if (logindr.Read())    
            {
                // eger Sick hasta verilerini dogru girdiyse Hasta Bilgileri Sayfasına gitsin 
                FrmSickBilgileri frmhastaBilg = new FrmSickBilgileri();
                // Login butonuna bastıgımızda SickBilgilerindeki tc'yide Göster 
                frmhastaBilg.tc = MskTC.Text;
                frmhastaBilg.Show();
                // artık login sayfası gozukmesin yani Hide()
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC && Password ");
            }
            // SqlDataReader kullanımından sonra bağlantıyı kapatmayı unutmayın
            loginBaglan.baglanti().Close();

        }

       
    }
}

