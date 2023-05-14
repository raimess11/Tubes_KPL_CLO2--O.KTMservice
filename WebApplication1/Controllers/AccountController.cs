using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DBServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        // GET: api/<DataBaseController>
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            List<Account> userAccounts = DataBase.getUserAccounts(); 
            return DataBase.getUserAccounts();
        }

        // GET api/<DataBaseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("login")]
        public Account Login(string name, string password)
        {
            foreach (Account account in DataBase.getUserAccounts())
            {
                if(account.name == name && account.password == password)
                {
                    return account;
                }
            };
            return null;
        }

        // POST api/<DataBaseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DataBaseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataBaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
