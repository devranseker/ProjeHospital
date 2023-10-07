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
    public partial class FrmSekreterLogin : Form
    {
        public FrmSekreterLogin()
        {
            InitializeComponent();
        }
        // Global alan 
        sqlBaglantilari skrtrGrsBaglan = new sqlBaglantilari();

        //DBServer+ 
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Secretary where SecretaryIdentity = @p1 and SecretaryPassword= @p2", skrtrGrsBaglan.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtPassword.Text);

            SqlDataReader veriOku = komut.ExecuteReader();
            // sorgulama oldugu icin yani giris yapyor == if 
            if (veriOku.Read())
            { // dogru ise sekreter Detay formuna gitsin 
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCNumber = MskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC Veya Password ,Yanlış ");
            }
            // unutma .Close();
            skrtrGrsBaglan.baglanti().Close();


        }



    }
}
