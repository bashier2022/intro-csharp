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
        public ActionResult<bool> Get()        
        {
            try
            {
                var s = new Services.FillFirstDataServices();
                s.initialize();
                return Ok(true);
            }
            catch (Exception x){
                return BadRequest(false);
            }
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
