using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesInterface.Models
{
    internal interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }
}
