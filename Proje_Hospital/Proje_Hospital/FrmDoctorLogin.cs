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


namespace Proje_Hospital
{
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }
        // Global alan ve Sql baglantısını al 
        sqlBaglantilari dktLgn = new sqlBaglantilari();


        // Login Giris Butonuna tıkladıgımız da 
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doctors where DoctorIdentity = @p1 And DoctorPassword = @p2", dktLgn.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader veriOku = komut.ExecuteReader();
            // Login yani if-else 
            if (veriOku.Read())
            {
                // Giris  verileri dogru ise Doktor Detay paneline gitsin 
                FrmDoktorBilgileri frdctDetay = new FrmDoktorBilgileri();
                // TC'yi Detay formundan doktor bilgilerine tasıyalım 
                frdctDetay.TC = MskTC.Text;

                frdctDetay.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre.");
            }
            dktLgn.baglanti().Close();

        }

        private void FrmDoctorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
