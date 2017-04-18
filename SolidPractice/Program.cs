using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace SolidPractice
{

    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            Container.RegisterElements(container);

            IMessenger volEnglishMessenger = container.Resolve<IMessenger>("VolEnglishMessenger");
            IMessenger areaEnglishMessenger = container.Resolve<IMessenger>("AreaEnglishMessenger");
            IAreaCalculator areaCalc = container.Resolve<IAreaCalculator>();
            IVolumeCalculator volumeCalc = container.Resolve<IVolumeCalculator>();
            IShapeFactory sf = container.Resolve<IShapeFactory>();

            IList<IArea> iArea = new List<IArea>();
            iArea.Add((IArea)sf.CreateShape("Cube", 5));

            IList<IVolume> iVolume = new List<IVolume>();
            iVolume.Add((IVolume)sf.CreateShape("Cube", 5));

            areaEnglishMessenger.Message(areaCalc.CalculateArea(iArea));
            volEnglishMessenger.Message(volumeCalc.CalculateVolume(iVolume));
            Console.ReadKey();
        }
    }
}
