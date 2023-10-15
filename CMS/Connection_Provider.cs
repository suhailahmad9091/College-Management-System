using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CMS
{
    internal class Connection_Provider
    {
        public SqlConnection conn;
        public void openConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-960O8IH;Initial Catalog=cms;Integrated Security=True"); 
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }
    }
}
