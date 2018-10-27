using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class Connectionclass
    {
        public static SqlConnection con = null;

        public void dbcon()
        {
            con = new SqlConnection(@"Data Source = MAPUTIFAMS-PC\SQLEXPRESS; Initial Catalog = SALESANDINVENTORY; Integrated Security = SSPI;");
           con.Open(); 
        }
            

        public void Closecon()
        {
            con.Close();
        }

        
    }
}
