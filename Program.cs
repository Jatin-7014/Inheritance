using ShapesInterface.Models;

namespace ShapesInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable[] drawables = { new Circle(12), new Rectangle(12, 15) };
            PrintDetails(drawables);
        }
        static void PrintDetails(IDrawable[] drawables)
        {
            foreach(var shape in drawables)
            {
                Console.WriteLine($"=============Shape: {shape.GetType().Name}================");
                shape.Draw();
                Console.WriteLine(shape);
            }
        }
    }
}
