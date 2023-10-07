using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// sql sınıfını unutma 
using System.Data.SqlClient;


namespace Proje_Hospital
{
    internal class sqlBaglantilari
    {
        public SqlConnection baglanti()       // method()  tanımladık  
        {
            // sql baglantımızı alalım 
            SqlConnection sqlbagla = new SqlConnection("Data Source=DEVRAN-PC\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True");
            
            sqlbagla.Open();
            return sqlbagla;



           
            
            // sqlbagla.Close();   // burada yapmaiyacagım kullandıgım her ayrı classda yapacagım 
            


        }






    }
}
