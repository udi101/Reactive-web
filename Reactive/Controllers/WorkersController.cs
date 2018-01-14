using Reactive.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace Reactive.Controllers
{
    [RoutePrefix("Workers")]
    public class WorkersController : ApiController
    {
        // GET: api/Workers
        public void Get()
        {
            return;
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
