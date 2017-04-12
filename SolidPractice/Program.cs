using System;
using System.Collections.Generic;
using static SolidPractice.SolidClass;

namespace SolidPractice
{

    class Program
    {
        static void Main(string[] args)
        {
            VolEnglishMessanger vol = new VolEnglishMessanger();
            AreaEnglishMessanger area = new AreaEnglishMessanger();
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
