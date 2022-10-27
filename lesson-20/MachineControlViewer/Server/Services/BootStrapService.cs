using MachineControlViewer.Server.Models;

namespace MachineControlViewer.Server.Services
{
    public class BootStrapService
    {
        public BootStrapService()
        {

        }

        public void initialize()
        {
            var db = new DataPointsDbContext();
            db.Add(new Platform()
            {
                Name = "CubeSat-40"
            });



            db.Add(new Platform()
            {
                Name = "Tractor-far"
            });

            var type1 = new MeasurementType() { Name = "Voltage" };
            var type2 = new MeasurementType() { Name = "Current" };
            var type3 = new MeasurementType() { Name = "Temprature" };
            var type4 = new MeasurementType() { Name = "Cycle" };

            db.MeasurementTypes.Add(type1);
            db.MeasurementTypes.Add(type2);
            db.MeasurementTypes.Add(type3);
            db.MeasurementTypes.Add(type4);
            var q = from p in db.Platforms
                    where p.Id == 1
                    select p;

            var platform = q.Single();
            var m1 = new Module() { Name = "Solar-3", Platform = platform };
            var m2 = new Module() { Name = "Solar-4", Platform = platform };
            db.Modules.Add(m1);
            db.Modules.Add(m2);

            var rng = new Random();
            for (int i = 0; i < 100; i++)
            {
                var dp1 = new Measurement()
                {
                    Module = m1,
                    Time = DateTime.Now.AddSeconds(i),
                    MeasurementType = type4,
                    Value = rng.Next(0, 200)
                };
                db.Measurements.Add(dp1);
                //var dp2 = new Measurement()
                //{
                //    Module = m2,
                //    Time = DateTime.Now.AddSeconds(i),
                //    MeasurementType = type2,
                //    Value = (double)rng.Next(0, 50) / 10
                //};
                //db.Measurements.Add(dp2);
            }
            db.SaveChanges();

        }
    }
}
