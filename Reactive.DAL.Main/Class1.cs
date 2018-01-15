using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Reactive.BL.Main;

namespace Reactive.DAL.Main
{
    class WorkersDB
    {

        public void GetData()
        {
            using (SqlConnection Conn = new SqlConnection())
            {
                Conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["WorkersConnectionString"].ToString();
                Conn.Open();
                Conn.Close();
            }
        }
    }
}
