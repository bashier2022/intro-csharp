using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineControlViewer.Shared
{
    public class PlattFormResponse
    {
        public string Name { set; get; }
        public int Id { set; get; }

        public PlattFormResponse(string name, int id)
        {
            Name = name;
            Id = id;
        }   
    }
    public class ModuleResponse
    {
        public string Name { set; get; }
        public int Id { set; get; }
        public ModuleResponse(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }

    public class MeasurementResponse
    {
        public int Id { set; get; }
        public DateTime Time { set; get; }
        public double Value { set; get; }

        public MeasurementResponse() { }
        public MeasurementResponse(int id, DateTime dt, double measurementValue)
        {
            Id = id;
            Time = dt;
            Value = measurementValue;
        }
    }

}

