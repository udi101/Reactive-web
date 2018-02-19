using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Common.Entities;
using Dapper;
using System;
using System.Linq;

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

                Conn.Open();
                return Conn.Query<Worker>("select * from dbo.Workers").ToList();

                //using (SqlCommand Command = new SqlCommand("select * from dbo.Workers", Conn))
                //{
                //    Conn.Open();
                //    SqlDataReader Reader = Command.ExecuteReader();
                //    while (Reader.Read())
                //    {
                //        Result.Add(new Worker() {
                //            Name = Reader["name"].ToString(),
                //            Age = Convert.ToInt16(Reader["age"]),
                //            _MyProperty = Reader["lastName"].ToString()
                //        });
                //    }
                //    Reader.Close();
                //}
            }
            return Result;
        }


    }
}


