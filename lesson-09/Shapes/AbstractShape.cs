using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class AbstractShape
    {
        public abstract string Name { get; }
        public abstract double Area();
        public abstract int Dimentions();
        public abstract void Scale(double factor);
        public double PaintVolume(double thickness)
        {
            var s = Area();
            return s * thickness;
        }
    }
}
