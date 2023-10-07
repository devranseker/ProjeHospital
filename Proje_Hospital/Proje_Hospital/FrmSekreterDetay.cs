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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        // Global alan
        public string TCNumber;

        // Sql'e baglanalım 
        sqlBaglantilari skrtrDtybgl = new sqlBaglantilari();


        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblSekreterTc.Text = TCNumber;
           
            //DBServer+
            // First_Name Last_Name
            SqlCommand komut1 = new SqlCommand("Select SecretaryNameSurname From  Tbl_Secretary where SecretaryIdentity = @p1", skrtrDtybgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblSekreterTc.Text);
            // artık verileri okusun 
            SqlDataReader veriOku1 = komut1.ExecuteReader();
            while (veriOku1.Read())
            {
                LblNameSurname.Text = veriOku1[0].ToString();
            }
            skrtrDtybgl.baglanti().Close();



            //Brans cekelim (dataGridView1 'e)
            DataTable dtTable1 = new DataTable();
            SqlDataAdapter dtAdapter1 = new SqlDataAdapter("Select * From Tbl_Branchs", skrtrDtybgl.baglanti());
            dtAdapter1.Fill(dtTable1);
            dataGridView1.DataSource = dtTable1;





            // Doktorları Listeye aktarma (dataGridView2 'e)
            DataTable dtTable2 = new DataTable();
            SqlDataAdapter dtAdapter2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as 'Doktorlar' ,DoctorBranch From Tbl_Doctors", skrtrDtybgl.baglanti());
            dtAdapter2.Fill(dtTable2);
            //dtTable2  tablosunu  dataGridView2'e atadım 
            dataGridView2.DataSource = dtTable2;

            //DBServer+
            // Brasnı Cmb'ye Aktarma 
            SqlCommand komut2 = new SqlCommand("Select BranchName From Tbl_Branchs", skrtrDtybgl.baglanti());
            SqlDataReader veriOku2 = komut2.ExecuteReader();
            // veri okudugu müddetce 
            while (veriOku2.Read())
            {
                CmbBrans.Items.Add(veriOku2[0]);
            }
            skrtrDtybgl.baglanti().Close();



        }

        //Kaydet butonu 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand komutSave = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", skrtrDtybgl.baglanti());
            komutSave.Parameters.AddWithValue("@r1", MskDate.Text);
            komutSave.Parameters.AddWithValue("@r2", MskClock.Text);
            komutSave.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutSave.Parameters.AddWithValue("@r4", CmbDoctor.Text);
            komutSave.ExecuteNonQuery();
            skrtrDtybgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");


        }

        //DBServer+
        //Doktorları Cmb'ye aktarma 
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {   // Cmb'ye  tıkladıgında daha onceki dokrorlar Combox'ını temizlesin 
            CmbDoctor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors Where DoctorBranch = @p1", skrtrDtybgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                CmbDoctor.Items.Add(veriOku[0] + " " + veriOku[1]);
            }
            skrtrDtybgl.baglanti().Close();


        }

        // Duyuru olustur 
        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_duyurular (duyuru) values (@d1)", skrtrDtybgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();

            skrtrDtybgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        // Hızlı erisimdeki Doktor doktor panelşne tıkladıgımda Form olarak doktor paneli gelsin  
        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frmdktrPnl = new FrmDoktorPaneli();
            frmdktrPnl.Show();      // paneli gosterdik 

        }

        // Hızlı erisimdeki Doktor Brans paneline tıkladıgımda Form olarak doktor paneli gelsin  
        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmrndv = new FrmRandevuListesi();
            frmrndv.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmdyr = new FrmDuyurular();
            frmdyr.Show();
        }

    }
}
