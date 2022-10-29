
using Project20221025.Server.Models;

namespace Project20221025.Server.Services
{
    public class FillFirstDataServices
    {
        public void initialize()
        {
            var db = new ProjectDataDbContext();
            var p1 = new Platform()
            {

                Name = "CubeSat-40"
            };
            db.Add(p1);


            var p2 = new Platform()
            {

                Name = "Tractor-far"
            };
            db.Add(p2);

          

            var type1 = new MeasurementType() { Name = "Voltage" };
            var type2 = new MeasurementType() { Name = "Current" };
            var type3 = new MeasurementType() { Name = "Temprature" };
            var type4 = new MeasurementType() { Name = "Cycle" };

            db.MeasurementTypes.Add(type1);
            db.MeasurementTypes.Add(type2);
            db.MeasurementTypes.Add(type3);
            db.MeasurementTypes.Add(type4);
            //var q = from p in db.Platforms
            //        where p.Id == 1
            //        select p;

            //Platform platform = new Platform() { Name = "Test" };

            db.SaveChanges();

            var m1 = new Module() { Name = "Solar-1", Platform = p1 };
            var m2 = new Module() { Name = "Solar-2", Platform = p1 };
            db.Modules.Add(m1);
            db.Modules.Add(m2);

            db.SaveChanges();

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

                var dp2 = new Measurement()
                {
                    Module = m2,
                    Time = DateTime.Now.AddSeconds(i),
                    MeasurementType = type2,
                    Value = (double)rng.Next(0, 50) / 10
                };
                db.Measurements.Add(dp2);
            }


            db.SaveChanges();

        }
    }
}
