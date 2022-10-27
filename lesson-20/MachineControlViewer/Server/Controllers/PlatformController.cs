using MachineControlViewer.Server.Models;
using MachineControlViewer.Shared;
using Microsoft.AspNetCore.Mvc;
using MachineControlViewer.Server.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MachineControlViewer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        
        [HttpGet]
        public List<PlattFormResponse> Get()
        {
            PlatFormServices s = new Services.PlatFormServices();
            return s.GetAllPlatForms();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlatformController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlatformController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlatformController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
