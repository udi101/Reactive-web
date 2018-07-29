using System.Collections.Generic;
using System.Web.Http;
using Reactive.BL.Main;
using Common.Entities;
using System.Threading.Tasks;

namespace Reactive.Controllers
{
    [RoutePrefix("Workers")]
    public class WorkersController : ApiController
    {
        // GET: api/Workers
        public async Task<IEnumerable<Worker>> Get()
        {
            WorkerBL workers = new WorkerBL(); //TODO!: Unity Container -> web.config / resolve
            return await workers.GetData();
        }

        // GET: api/Workers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Workers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Workers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Workers/5
        public void Delete(int id)
        {
        }
    }
}
