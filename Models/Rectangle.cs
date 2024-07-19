using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesInterface.Models
{
    internal class Rectangle:IShape,IDrawable
    {
        public double Length {  get; set; }
        public double Breadth {  get; set; }
        public Rectangle(double length,double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public override string ToString()
        {
            return $"Area of Rectangle is: {CalculateArea()}\n" +
                $"Cicumference of Rectangle is {CalculatePerimeter()}\n";
        }
        public double CalculateArea()
        {
            return Length*Breadth;
        }

        public double CalculatePerimeter()
        {
            return (Length+Breadth)*2;
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle is drawn");
        }
    }
}
