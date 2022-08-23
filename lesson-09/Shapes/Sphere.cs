using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : AbstractShape
    {
        private double _radius;
        public Sphere(double radius)
        {
            _radius = radius;
        }

        public override string Name => "Sphere";

        public override double Area() 
        {
            return 4 * Math.PI * _radius * _radius;
        }
        public override void Scale(double factor)
        {
            _radius *= factor;
        }
        public override int Dimentions() => 3;
    }
}
