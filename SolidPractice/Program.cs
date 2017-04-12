using System;
using System.Collections.Generic;

namespace SolidPractice
{

    class Program
    {
        static void Main(string[] args)
        {
            VolEnglishMessenger vol = new VolEnglishMessenger();
            AreaEnglishMessenger area = new AreaEnglishMessenger();
            AreaCalculator areaCalculator = new AreaCalculator();
            VolumeCalculator volumeCalculator = new VolumeCalculator();

            IList<IArea> iArea = new List<IArea>();
            iArea.Add(new Circle() { Width = 5 });
            iArea.Add(new Square() { Width = 6 });
            iArea.Add(new Cube() { Width = 5 });


            IList<IVolume> iVolume = new List<IVolume>();
            iVolume.Add(new Cube() { Width = 5 });

            area.Message(areaCalculator.CalculateArea(iArea));
            vol.Message(volumeCalculator.CalculateVolume(iVolume));
            Console.ReadKey();
        }
    }
}
