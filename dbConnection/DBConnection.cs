using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_system.dbConnection
{
    public class DBConnection
    {
        public SqlConnection createConnection ()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
               // conn.Open();
                return conn;
            }
            catch(Exception e)
            {
               MessageBox.Show(e.Message);
                throw e;
            }
           
        }
    }
}
