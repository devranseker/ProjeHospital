using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hospital
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }


        // bu buton hasta giris formunu cagırır 
        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            FrmSickLogin frmHastaGiris = new FrmSickLogin();
            frmHastaGiris.Show();
            this.Hide();  // Girisler formu gizler ama hafızada tutar 

        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin frmDoktorGiris = new FrmDoctorLogin();
            frmDoktorGiris.Show();
            // sonra bunu gizle (girisler)
            this.Hide();  
        }

        // bu buton sekreter giris formunu cagırır 
        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterLogin frmSekreterGiris = new FrmSekreterLogin();
            frmSekreterGiris.Show();
            this.Hide();


        }
    }
}
