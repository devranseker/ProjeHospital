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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        // Global alan 
        sqlBaglantilari rndvlist = new sqlBaglantilari();


        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dtTable = new DataTable();
            SqlDataAdapter dtAdapter = new SqlDataAdapter("Select * From Tbl_Randevular", rndvlist.baglanti());
            dtAdapter.Fill(dtTable);
            dataGridView1.DataSource = dtTable;

        }

        // hucreye iki defa tıkladıgında verileri diger panele tasisin diger panelde kullanacagım icin public olsun 
        public int secilen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           secilen = dataGridView1.SelectedCells[0].RowIndex;


        }

    }
}
