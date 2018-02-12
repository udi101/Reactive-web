using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Common.Entities;
using System;

namespace Reactive.DAL.Main
{
    public class WorkersDB
    {

        public IEnumerable<Worker> GetData()
        {
            //TODO!: Infrastructure method that opens connection.
            //Infrastructure - BaseRepository/Dapper - Look in our project on CRUDRepository & DBExecuter

            List<Worker> Result = new List<Worker>();
            var connectionString = ConfigurationManager.ConnectionStrings["WorkersConnectionString"].ToString();
            using (SqlConnection Conn = new SqlConnection(connectionString))
            {
                //return await conn.GetAsync<Workers>();

                using (SqlCommand Command = new SqlCommand("select * from dbo.Workers", Conn))
                {
                    Conn.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        Result.Add(new Worker() {
                            Name = Reader["name"].ToString(),
                            Age = Convert.ToInt16(Reader["age"]),
                            _MyProperty = Reader["lastName"].ToString()
                        });
                    }
                    Reader.Close();
                }
            }
            return Result;
        }


    }
}


