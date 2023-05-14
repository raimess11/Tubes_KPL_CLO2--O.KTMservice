using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DBServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        
        
        // GET: api/<RequestController>
        [HttpGet]
        public IEnumerable<Request> Get()
        {
            return DataBase.requests;
        }

        // GET api/<RequestController>/5
        [HttpGet("{id}")]
        public Request Get(int id)
        {
            return DataBase.requests[id];
        }

        // POST api/<RequestController>
        [HttpPost]
        public void Post([FromBody] Request req)
        {
            DataBase.requests.Add(req);
        }

        // PUT api/<RequestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Request req)
        {
            DataBase.requests[id] = req;
        }

        // DELETE api/<RequestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataBase.requests.RemoveAt(id);
        }
    }
}
