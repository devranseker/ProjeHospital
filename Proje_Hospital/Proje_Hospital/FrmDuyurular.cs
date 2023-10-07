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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        // Global alan and sql baglantısını alalım 
        sqlBaglantilari dyrbgln = new sqlBaglantilari();

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {   // Frm Duyurulara tablo olusturalım
            DataTable dtTable = new DataTable();
            SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * From Tbl_duyurular", dyrbgln.baglanti());
            dtAdapter.Fill(dtTable);
            dataGridView1.DataSource = dtTable;

        }

    }
}
