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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        // Global alan ve Sql baglatısını al
        sqlBaglantilari brnsbgl = new sqlBaglantilari();


        //
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dtTable = new DataTable();
            SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * From Tbl_Branchs", brnsbgl.baglanti());
            dtAdapter.Fill(dtTable);
            dataGridView1.DataSource = dtTable;


        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Branchs (BranchName) values (@b1) ", brnsbgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtBransName.Text);
            komut.ExecuteNonQuery();
            // baglantıyı kapatalım
            brnsbgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", " Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // CellClick (Hucre-tıkla) ozelligi yani dataGridView1'in icindeki hucrelerden herhangi birine tek tıkladıgımızda 
        // Brans verilerini gostersin 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;  // == int secilen = 0;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        // Delete Where olmasın lütfen 
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branchs where BranchId = @b1", brnsbgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtId.Text);
            komut.ExecuteNonQuery();
            brnsbgl.baglanti().Close();
            MessageBox.Show("Branş Silindi.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Branchs set BranchName = @p1 where BranchId = @p2", brnsbgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBransName.Text);
            komut.Parameters.AddWithValue("@p2",TxtId.Text);
            komut.ExecuteNonQuery();
            brnsbgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi.");
        }

    }
}
