using MachineControlViewer.Shared;
using Microsoft.AspNetCore.Mvc;
using MachineControlViewer.Server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MachineControlViewer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        // GET: api/<MeasurementController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<MeasurementController>/5
        [HttpGet("{moduleId}")]
        public ActionResult<IEnumerable<MeasurementResponse>> Get(int moduleId)
        {
            //MeasurementService s = new MeasurementService();
            //List<MeasurementResponse> mm = s.AllMeasurments(moduleId);
            var db = new DataPointsDbContext();
            var q = from m in db.Measurements
                    where m.Module.Id == moduleId
                    select new MeasurementResponse(m.Id, m.Time, m.Value);
           if (q.Any())
            {
                return Ok(q.ToList<MeasurementResponse>());
            }
            return NotFound();
            
                
            //int n = 0;

            //List<MeasurementResponse> lst = new List<MeasurementResponse>();
            //foreach (var m in q)
            //{
            //    if (n < 10)
            //    {
            //        n++;
            //        //lst.Add(new MeasurementResponse(m.Id, m.Time, m.MeasurementValue));
            //        lst.Add(m);
            //    }
            //}
           //return lst;
            //return mm;
        }

        // POST api/<MeasurementController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MeasurementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MeasurementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
