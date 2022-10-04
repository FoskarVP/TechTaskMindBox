using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTaskMindBox.Figure
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительной величиной");
            }

            Radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
