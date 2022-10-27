using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project20221025.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataFillController : ControllerBase
    {
        // GET: api/<DataFillController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DataFillController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DataFillController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DataFillController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataFillController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
