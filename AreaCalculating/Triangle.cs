using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculating
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentException("Отрицательное значение стороны");
            if (firstSide + secondSide <= thirdSide ||
                secondSide + thirdSide <= firstSide ||
                firstSide + thirdSide <= secondSide)
                throw new ArgumentException("Несуществующий треугольник");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        public bool IsRightRectangle(Triangle triangle)
        {
            var firstSidiSquare = triangle.FirstSide * triangle.FirstSide;
            var secondSideSquare = triangle.SecondSide * triangle.SecondSide;
            var thirdSideSquare = triangle.ThirdSide * triangle.ThirdSide;
            return firstSidiSquare == secondSideSquare + thirdSideSquare ||
                secondSideSquare == firstSidiSquare + thirdSideSquare ||
                thirdSideSquare == firstSidiSquare + secondSideSquare;
        }

        public double Area()
        {
            var halfMeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(halfMeter * (halfMeter - FirstSide) *
                (halfMeter - SecondSide) * (halfMeter - ThirdSide));
        }
    }
}
