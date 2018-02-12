using System.Collections.Generic;
using System.Web.Http;
using Reactive.BL.Main;
using Newtonsoft.Json;
using Common.Entities;

namespace Reactive.Controllers
{
    [RoutePrefix("Workers")]
    public class WorkersController : ApiController
    {
        // GET: api/Workers
        public IEnumerable<Worker> Get()
        {
            Workers workers = new Workers(); //TODO!: Unity Container -> web.config / resolve
            return workers.GetData();
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
