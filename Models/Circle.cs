using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesInterface.Models
{
    internal class Circle : IShape, IDrawable
    {
        public double Radius{ get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return double.Pi * Radius;
        }

        public override string ToString()
        {
            return $"Area of circle is: {Math.Round(CalculateArea(),3)}\n" +
                $"Cicumference of circle is {Math.Round(CalculatePerimeter(),3)}\n";
        }
        public double CalculatePerimeter()
        {
            return 2*double.Pi*Radius;
        }

        public void Draw()
        {
            Console.WriteLine("Circle is drawn");
        }
    }
}
