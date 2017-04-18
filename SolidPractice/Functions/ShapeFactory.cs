using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice
{
    public class ShapeFactory : IShapeFactory
    {
        public IShape CreateShape(string type, int width)
        {
            switch (type)
            {
                case "Square": return new Square { Width = width };
                case "Circle": return new Circle { Width = width };
                case "Equilateral_Triange": return new Equilateral_Triangle { Width = width };
                case "Cube": return new Cube { Width = width };
                default: return new Square { Width = width };
            }
        }
    }
}
