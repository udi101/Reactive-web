using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

using Newtonsoft.Json;
using Reactive.Models; 

namespace Reactive.BL.Main
{
    class Workers
    {
        public IEnumerable<Worker> GetWorkers() {
            var filepath = HostingEnvironment.MapPath(@"~/App_Data/workers.json");
            var json = System.IO.File.ReadAllText(filepath);
            var workers = JsonConvert.DeserializeObject<List<Worker>>(json);
            return workers;
        }

    }
}
