using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculating
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if(radius < 0)
                throw new ArgumentException("Отрицательный радиус.");
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
