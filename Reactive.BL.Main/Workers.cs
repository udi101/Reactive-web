using System.Collections.Generic;
using System.Web.Hosting;
using System.IO;
using Newtonsoft.Json;
using Common.Entities;
using Reactive.DAL.Main;

namespace Reactive.BL.Main
{
    public class Workers //TODO! : IWorkers
    {
        public IEnumerable<Worker> GetWorkers()
        {
            var filepath = HostingEnvironment.MapPath(@"~/App_Data/workers.json");
            var json = System.IO.File.ReadAllText(filepath);
            var workers = JsonConvert.DeserializeObject<List<Worker>>(json);
            return workers;
        }

        public IEnumerable<Worker> GetData()
        {
            WorkersDB w = new WorkersDB();
            return w.GetData();
        }

    }
}
