using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculating
{
    public static class CalculateArea
    {
        public static double GetArea(IFigure figure)
        {
            return figure.Area();
        }
    }
}
