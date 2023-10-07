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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        // Global alan

        // Identity number ayırt edici ozellik oldugdu icin bununla diger verilere gecis yapacagız 
        public string TCNo;


        // Sql Clasına baglanıp dolaylı yolla sql'e baglanalım 
        sqlBaglantilari baglanblgedit = new sqlBaglantilari();


        //DBServer+
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCNo;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sicks where SickIdentity = @p1", baglanblgedit.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader veriOku = komut.ExecuteReader();

            // Sicks tablosunda p1 Identity'ne sahip kisinin bilgilerini getir (Veri okundugu müddetce)
            while (veriOku.Read())
            {
                TxtName.Text = veriOku[1].ToString();
                TxtSurname.Text = veriOku[2].ToString();
                MskPhone.Text = veriOku[4].ToString();
                TxtPassword.Text = veriOku[5].ToString();
                CmbGender.Text = veriOku[6].ToString();
            }
        }

        //DBServer+
        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Sicks set SickName=@p1, SickSurname=@p2, SickPhone=@p3, SickPassword=@p4, SickGender=@p5 where SickIdentity=@p6", baglanblgedit.baglanti());
            // where unutma!!!!!!!!!!!!!!
            komut2.Parameters.AddWithValue("@p1", TxtName.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            komut2.Parameters.AddWithValue("@p3", MskPhone.Text);
            komut2.Parameters.AddWithValue("@p4", TxtPassword.Text);
            komut2.Parameters.AddWithValue("@p5", CmbGender.Text);
            komut2.Parameters.AddWithValue("@p6", MskTC.Text);
            // sımdı sorguyu (Update) calıstıralım  ExecuteNonQuery();== Insort,Update and delete yaptigimiz islemleri calıstıriri
            komut2.ExecuteNonQuery();
            //baglanti.Close();   unutma(Don't Forget)
            baglanblgedit.baglanti().Close();

            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
