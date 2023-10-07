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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        // Global alan 
        // Sql baglantımızı alalım 
        sqlBaglantilari dktPnlbgl = new sqlBaglantilari();


        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            // Doktorları Listeye aktarma (dataGridView1 'e)
            DataTable dtTable1 = new DataTable();
            SqlDataAdapter dtAdapter1 = new SqlDataAdapter("Select * From Tbl_Doctors", dktPnlbgl.baglanti());
            dtAdapter1.Fill(dtTable1);
            //dtTable1  tablosunu  dataGridView1'e atadım 
            dataGridView1.DataSource = dtTable1;


            // Brasnı Cmb'ye Aktarma 
            SqlCommand komut2 = new SqlCommand("Select BranchName From Tbl_Branchs", dktPnlbgl.baglanti());
            SqlDataReader veriOku2 = komut2.ExecuteReader();
            // veri okudugu müddetce 
            while (veriOku2.Read())
            {
                CmbBrans.Items.Add(veriOku2[0]);
            }
            dktPnlbgl.baglanti().Close();

        } 

        // Ekleme == insert into (o zaman ExecuteNonQuery()  yani veriOkuma yok  )
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorBranch,DoctorIdentity,DoctorPassword) values (@d1,@d2,@d3,@d4,@d5)",dktPnlbgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtName.Text);
            komut.Parameters.AddWithValue("@d2", TxtSurname.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", MskTCNo.Text);
            komut.Parameters.AddWithValue("@d5", TxtPassword.Text);
            komut.ExecuteNonQuery();
            dktPnlbgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        // CellContentClick (Hucre-icerik-tıkla) ozelligi yani dataGridView1'in icindeki hucrelerden herhangi birine tek tıkladıgımızda 
        // Doktor'un verilerini gostersin 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            // simdi aktarma islemini yapalım 
            TxtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();  // Cells[1] == 1 cunku 0'da Id var
            TxtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTCNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();



            /*
             * int secilen = dataGridView1.SelectedCells[0].RowIndex;: Bu satırda, DataGridView (dataGridView1) içinde seçilen
             * hücrelerden birinin bulunduğu satırın indeksini secilen adlı bir tamsayı değişkenine atar. Kullanıcı bu DataGridView içinde bir hücreyi seçtiğinde,
             * bu kod seçilen hücrenin bulunduğu satırın indeksini belirler.
             */

        }

        // simdi doktor panelindeki sil butonunu etkinlesitirelim Delete yani Lütfen Where'siz olmasın!!!!!!!!!!
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Doctors where DoctorIdentity = @p1", dktPnlbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTCNo.Text);
            komut.ExecuteNonQuery();
            // baglantıyı kapatmayi unutmayalım 
            dktPnlbgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


        }

        // simdi doktor panelindeki ,guncelleme butonunu etkinlesitirelim Update ütfen Where'siz olmasın!!!!!!!!!!
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doctors set DoctorName = @d1,DoctorSurname = @d2,DoctorBranch = @d3,DoctorPassword = @d4 Where DoctorIdentity = @d5", dktPnlbgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtName.Text);
            komut.Parameters.AddWithValue("@d2", TxtSurname.Text);
            komut.Parameters.AddWithValue("@d3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", TxtPassword.Text);
            komut.Parameters.AddWithValue("@d5", MskTCNo.Text);
            komut.ExecuteNonQuery();
            dktPnlbgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);     
       } 

       
    }
}
