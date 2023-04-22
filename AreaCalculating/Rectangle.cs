using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculating
{
    public class Rectangle : IFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height) 
        {
            if (width < 0 || height < 0)
                throw new ArgumentException("Отрицательные значения сторон");
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}
