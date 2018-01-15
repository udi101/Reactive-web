using System.Collections.Generic;
using System.Web.Hosting;
using System.IO;
using Newtonsoft.Json;
using Common.Entities;
namespace Reactive.BL.Main
{
    public class Workers
    {
        public IEnumerable<Worker> GetWorkers() {
            var filepath = HostingEnvironment.MapPath(@"~/App_Data/workers.json");
            var json = System.IO.File.ReadAllText(filepath);
            var workers = JsonConvert.DeserializeObject<List<Worker>>(json);
            return workers;
        }

    }
}
