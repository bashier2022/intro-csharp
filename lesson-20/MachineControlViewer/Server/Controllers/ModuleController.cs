using Microsoft.AspNetCore.Mvc;
using MachineControlViewer.Shared;
using MachineControlViewer.Server.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MachineControlViewer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        // GET: api/<ModulesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ModulesController>/5
        [HttpGet("{platformId}")]
        public List<ModuleResponse> Get(int platformId)
        {
            ModuleService s = new ModuleService();
            return s.GetModules(platformId);
        }

        // POST api/<ModulesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ModulesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ModulesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
