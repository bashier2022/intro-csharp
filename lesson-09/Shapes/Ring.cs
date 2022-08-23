using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ring : AbstractShape
    {
        private double _innerRadius;
        private double _outerRadius;

        public Ring(double innerRadius, double outerRadius)
        {
            _innerRadius=innerRadius;
            _outerRadius=outerRadius;
        }

        public override string Name => "Ring";

        public override double Area()
        {
            return (new Circle(_outerRadius)).Area() - (new Circle(_innerRadius)).Area();
        }

        public override int Dimentions() => 2;
        
        public override void Scale(double factor)
        {
            _innerRadius *= factor;
            _outerRadius *= factor;
        }
    }
}
