using MachineControlViewer.Shared;
using MachineControlViewer.Server.Models;
namespace MachineControlViewer.Server.Services
{
    public class ModuleService
    {

        public List<ModuleResponse> GetModules(int platformId)
        {
            //List<PlattFormResponse> lst = new List<PlattFormResponse>();
            var db = new DataPointsDbContext();
            var q = from m in db.Modules
                    where m.PlatformId == platformId
                    select new ModuleResponse(m.Name, m.Id);

            return q.ToList();
        }
    }
}
