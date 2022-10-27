
using MachineControlViewer.Shared;
using MachineControlViewer.Server.Models;
namespace MachineControlViewer.Server.Services
{
    public class MeasurementService
    {

        public List<MeasurementResponse> AllMeasurments(int moduleId)
        {
            //List<PlattFormResponse> lst = new List<PlattFormResponse>();
            var db = new DataPointsDbContext();
            var q = from m in db.Measurements
                    where m.Module.Id == moduleId
                    select new MeasurementResponse(m.Id, m.Time, m.Value);
            int n = 0;

            List<MeasurementResponse> lst = new List<MeasurementResponse>();
            foreach (var m in db.Measurements)
            {
                if(n<10)
                {
                    n++;
                    lst.Add(new MeasurementResponse(m.Id, m.Time, m.Value));
                }
            }
            return lst;
        }
    }
}