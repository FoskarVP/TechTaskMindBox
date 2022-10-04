using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTaskMindBox.Figure
{
    public class Triangel : Figure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangel(double sideA, double sideB, double sideC)
        {
            if (sideA >= sideB + sideC ||
                sideB >= sideA + sideC ||
                sideC >= sideA + sideB)
            {
                throw new ArgumentException("Треугольник не существует");
            }

            if (sideA <= 0 || sideB <= 0 || sideC <=0)
            {
                throw new ArgumentException("Сторона теугольника должна быть положительной величиной");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsRightangel()
        {
            return SideC * SideC == SideA * SideA + SideB * SideB ||
                SideA * SideA == SideC * SideC + SideB * SideB ||
                SideB * SideB == SideA * SideA + SideC * SideC;
        }

        public override double GetSquare()
        {
            double halfPerimeter = (SideA + SideB + SideC)/2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }
    }
}
