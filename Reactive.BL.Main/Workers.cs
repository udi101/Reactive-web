using System.Collections.Generic;
using System.Web.Hosting;
using Newtonsoft.Json;
using Common.Entities;
using Reactive.DAL.Main;
using System.Threading.Tasks;
using Reactive.BL.Interfaces;

namespace Reactive.BL.Main
{
    public class WorkerBL: IWorkerBL
    {
        public IEnumerable<Worker> GetWorkers()
        {
            var filepath = HostingEnvironment.MapPath(@"~/App_Data/workers.json");
            var json = System.IO.File.ReadAllText(filepath);
            var workers = JsonConvert.DeserializeObject<List<Worker>>(json);
            return workers;
        }

        public async Task<IEnumerable<Worker>> GetData()
        {
            WorkersDB w = new WorkersDB();
            return await w.GetData();
        }

    }
}
