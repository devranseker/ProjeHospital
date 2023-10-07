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
    public partial class FrmDoktorBilgileri : Form
    {
        public FrmDoktorBilgileri()
        {
            InitializeComponent();
        }
        // Global alan ve sql baglantısın alalım 
        sqlBaglantilari dktrDty = new sqlBaglantilari();
        public string TC;


        private void FrmDoktorBilgileri_Load(object sender, EventArgs e)
        {
            LblDoctorTc.Text = TC;
            // simdi Tc'yi Doktor Giris Panelinden alalım ve tcsini aldıgımız kisinin FirsName ve LastName alalım 

            // Doktor FirstName And LastName
            SqlCommand komut = new SqlCommand("Select DoctorName, DoctorSurname From Tbl_Doctors where DoctorIdentity = @p1", dktrDty.baglanti());
            komut.Parameters.AddWithValue("@p1", LblDoctorTc.Text);
            SqlDataReader veriOku = komut.ExecuteReader();
            // while kullanacagım if sadece girislerde kullanılır 
            while (veriOku.Read())
            {
                LblNameSurname.Text = veriOku[0] + " " + veriOku[1];
            }
            dktrDty.baglanti().Close();

            // Randevular Randevu Listesini dolduralım 
            DataTable dtTable = new DataTable();   // Tablo olustu 
            // simdi Sql'deki alacagımız  verileri ayırıp Adapter ile baglantı kuralım 
            SqlDataAdapter veriBagla = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor = '" + LblNameSurname.Text + "'  ", dktrDty.baglanti());
            // RandevuDoktor = '" + LblNameSurname.Text + "'  == Doktor bilgilerinden name Surname ile aynı olan Doktor'un Randevuları gelsin 
            veriBagla.Fill(dtTable);   // simdi Fiil ile o verileri olusturdugumuz tabloya aktaralım(dolduralım)
            dataGridView1.DataSource = dtTable;
        }

        // Bilgi Duzenle Butonuna tıkladıgında Doktor Bilgi Düzenleye gitsin 
        private void BtnDktrBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frdrEdit = new FrmDoktorBilgiDuzenle();
            frdrEdit.TCNo = LblDoctorTc.Text;  // diger formda aldık 

            frdrEdit.Show();
           }

        // Doktor  buradan Duyurular Formuna gitsin 
        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyuru = new FrmDuyurular();
            frmDuyuru.Show();

        }

        // Doktor Cikis Butonuna bastıgında Programdan tam anlamıyla ciksin 
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Doktor burada CellClick  methodu sayesinde randevular kısmında bir hucreye bir kere tıkladıgında randevu alan
        // kisinin sikayetini gorsun 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            // Cells[7]  sikayet 7. Satırda Sql tablosunda 
        }
    }
}
