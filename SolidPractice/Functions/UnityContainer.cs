using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace SolidPractice
{
    public class Container
    {
        public static void RegisterElements(IUnityContainer container)
        {
            container.RegisterType<IMessenger, VolEnglishMessenger>("VolEnglishMessenger");
            container.RegisterType<IMessenger, AreaEnglishMessenger>("AreaEnglishMessenger");
            container.RegisterType<IAreaCalculator, AreaCalculator>();
            container.RegisterType<IVolumeCalculator, VolumeCalculator>();
            container.RegisterType<IShapeFactory, ShapeFactory>();
        }
    }
}
