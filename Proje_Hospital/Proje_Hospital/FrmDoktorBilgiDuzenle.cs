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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        // Global alan and Sql baglantisini getirelim 
        sqlBaglantilari dktrEdit = new sqlBaglantilari();
        // simdi TC'yi getirelim sqlCommand'ta where'de kullanacagızya yani Tc ozerinden hareket edecegiz 
        public string TCNo;    


        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCNo;
            // simdi diger verileri getirelim 
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doctors where DoctorIdentity = @p1", dktrEdit.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                TxtName.Text = veriOku[1].ToString();  // veriOku[0]'da Id var 
                TxtSurname.Text = veriOku[2].ToString();
                CmbBrans.Text = veriOku[3].ToString();
                TxtPassword.Text = veriOku[5].ToString();
            }
            dktrEdit.baglanti().Close();
        }

        // Doktor Bilgileri Guncelle Update == .ExecuteNonQuery();  where'siz Update olmazzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz
        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doctors Set  DoctorName = @p1, DoctorSurname = @p2, DoctorBranch = @p3, DoctorPassword = @p4 where DoctorIdentity = @p5 ", dktrEdit.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtName.Text);
            komut.Parameters.AddWithValue("@p2", TxtSurname.Text);
            komut.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", TxtPassword.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.ExecuteNonQuery();
            dktrEdit.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");

        }
    }
}
//  SqlDataReader oldugu zaman while olur 
// .ExecuteNonQuery(); oldugu zaman while olmaz 
