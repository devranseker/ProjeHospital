using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// DB'den Name and Surname alacagız o zaman DB Library
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace Proje_Hospital
{
    public partial class FrmSickBilgileri : Form
    {
        public FrmSickBilgileri()
        {
            InitializeComponent();
        }
        // Global alan 
        // hasta giris panelindeki Tc'yi hastaBilgilerine tasımam gerekiyor  o zaman Formlar arası gecis yapmam lazım 
        public string tc;

        //DB'e Connecleyelim 
        sqlBaglantilari bgl = new sqlBaglantilari();


        // Hasta Detay Formu DBServer+
        private void FrmSickBilgileri_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;  // form ilk geldiği zamanda Formda tc gozuksun 


            // Name Surname DB'den Çekme 
            // Hasta Verilerini alalım DB'den yani Sql komutlarını calıstıralim 
            SqlCommand komut = new SqlCommand("Select SickName,SickSurname From Tbl_Sicks where SickIdentity = @p1", bgl.baglanti());
            // burada LblTc'de olan kisinin name and surname yazdırsın 
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader veriOku = komut.ExecuteReader();

            while (veriOku.Read())
            {
                // LblNameSurname.Text = veriOku[0] + veriOku[1].ToString();
                // özellik bir komut satırında bir String varsa digerlerini cevirmeye gerek yok 
                LblNameSurname.Text = veriOku[0] + " " +  veriOku[1];

            }
            bgl.baglanti().Close();

            //-- Randevu Geçmişi--  DBServer- 
            // bana Rabdevu tablosudnan verileri getirirken tablo olustursun DB'te calıstıgım tablo == Tbl_Randevular  
            // tablo olusturduk 
            DataTable dtTbl = new DataTable();
            SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            // dataAdapter veri cek doldur nereyi doldur dataTable'yi 
            dtAdapter.Fill(dtTbl);
            dataGridView1.DataSource = dtTbl;   // veri kaynagi dataTable'den gelen deger 

            // dataGridView1'den baglantı acıp kapatmaya gerek kalmıyor 




            // --Branchs cekme DBServer+  
            SqlCommand komut2 = new SqlCommand("Select BranchName From Tbl_Branchs", bgl.baglanti());
            SqlDataReader veriOku2 = komut2.ExecuteReader();

            while (veriOku2.Read())
            {
                CmbBrans.Items.Add(veriOku2[0]);   // tek sutun oldugu iicn index == 0

            }
            // Sql baglantısını kapatmayı unutmayalım 
            bgl.baglanti().Close();

        }

        //DBServer+
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //biz combobox'tan birsey sectiğimizde daha omcekileri sıfırlasın 
            CmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorBranch = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader veriOku = komut.ExecuteReader();

            while (veriOku.Read())
            {
                CmbDoktor.Items.Add(veriOku[0] + " " + veriOku[1]);

            }
            //Close()  unutma 
            bgl.baglanti().Close();


        }

        // DBServer-   DBTable+
        // Branları Cmb'ye aktarma 
        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtTable = new DataTable();
            SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans = '" + CmbBrans.Text + "'" + " And RandevuDoktor = '" + CmbDoktor.Text + "' And RandevuDurum = 0 ", bgl.baglanti());
            // Sql'de kelime bazlı arama yaptıgında ' aranacak kelime '   bu sekil olması gerekiyor 
            dtAdapter.Fill(dtTable);
            dataGridView2.DataSource = dtTable;

        }

        private void LnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle frmblgEdit = new FrmBilgiDuzenle();
            // TCNo'ya deger gonderme ıslemi gerceklestirelim 
            frmblgEdit.TCNo = LblTc.Text;
            
            frmblgEdit.Show();
           
        }

        // Id 
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;   // .SelectedCells[0] == bastaki degeri sıfır 
            TxtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            

        }

        // Hasta Randevu alıyor 
        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum = 0, HastaTC= @p1, HastaSikayet = @p2 Where RandevuId = @p3", bgl.baglanti());
            // parametre atamaları yapalım 
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", TxtId.Text);
            // Komutları calıstıralım   Update == .ExecuteNonQuery();
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}



/*
  SqlDataAdapter .NET platformlarında kullanılan bir sınıftır ve veritabanı işlemleri için bir köprü görevi görür. Genellikle veritabanı ile bağlantı kurarak veri alışverişi yapmak için kullanılır. SqlDataAdapter, veritabanından veri çekme, veritabanına veri gönderme ve veritabanı işlemlerini daha kolay ve etkili bir şekilde yönetme işlemlerini sağlar.
  ExecuteNonQuery metodu, veritabanı üzerinde veri değişikliği yapacak olan SQL sorgularını çalıştırmak için kullanılır ve geriye dönüş değeri etkilenen satır sayısını verir. Bu, sorgu başarılı bir şekilde çalıştırıldığında değiştirilen veya eklenen kayıt sayısını döndürür. Eğer sorgu başarısız olursa, hata alabilirsiniz.
 */
