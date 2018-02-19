using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Common.Entities;
using Dapper;
using System.Threading.Tasks;
using Reactive.DAL.Interfaces.Workers;
namespace Reactive.DAL.Main
{
    public class WorkersDB : IWorkerRepository
    {
        public async Task<IEnumerable<Worker>> GetData()
        {
            //TODO!: Infrastructure method that opens connection.
            //Infrastructure - BaseRepository/Dapper - Look in our project on CRUDRepository & DBExecuter

            List<Worker> Result = new List<Worker>();
            var connectionString = ConfigurationManager.ConnectionStrings["WorkersConnectionString"].ToString();
            using (SqlConnection Conn = new SqlConnection(connectionString))
            {
                //return await conn.GetAsync<Workers>();
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
                return await Conn.QueryAsync<Worker>("select * from dbo.Workers");
            }
        }

        public async Task<Worker> GetWorker()
        {
            Worker w1 = new Worker();
            var t1 = Task.Run(() =>
            {
                return new Worker() { Name = "udi", LastName = "Mazor", Age = 43, Salary = 25000 };
            });
            return await t1;
        }
    }
}


