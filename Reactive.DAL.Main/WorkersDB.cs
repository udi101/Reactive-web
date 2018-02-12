using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Common.Entities;

namespace Reactive.DAL.Main
{
    public class WorkersDB
    {

        public IEnumerable<Worker> GetData()
        {
            //TODO!: Infrastructure method that opens connection.
            //Infrastructure - BaseRepository/Dapper - Look in our project on CRUDRepository & DBExecuter

            var connectionString = ConfigurationManager.ConnectionStrings["WorkersConnectionString"].ToString();

            using (SqlConnection Conn = new SqlConnection(connectionString))
            {
                // Conn.Open();

                //return await conn.GetAsync<Workers>();

                using (SqlCommand Command  = new SqlCommand("select * from dbo.Workers", Conn))
                {
                    Conn.Open();

                    var x = Command.ExecuteReader();
                }

              //  Conn.Close();
            }

            return null;
        }
    }
}


