using MachineControlViewer.Server.Models;
using MachineControlViewer.Shared;
namespace MachineControlViewer.Server.Services
{
    public class PlatFormServices
    {
        public PlatFormServices()
        {

        }

        public List<PlattFormResponse> GetAllPlatForms()
        {
            //List<PlattFormResponse> lst = new List<PlattFormResponse>();
            var db = new DataPointsDbContext();
            var q = from p in db.Platforms
                    select new PlattFormResponse(p.Name, p.Id);

            return q.ToList();
        }
    }
}
