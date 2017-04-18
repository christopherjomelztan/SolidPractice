using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice
{
    public interface IShapeFactory
    {
        IShape CreateShape(string type, int width);
    }
}
