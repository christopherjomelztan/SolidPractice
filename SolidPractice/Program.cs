using System;
using System.Collections.Generic;
using static SolidPractice.SolidClass;

namespace SolidPractice
{

    class Program
    {
        static void Main(string[] args)
        {
            VolFrenchMessanger vol = new VolFrenchMessanger();
            AreaEnglishMessanger area = new AreaEnglishMessanger();
            AreaCalculator areaCalculator = new AreaCalculator(area);
            VolumeCalculator volumeCalculator = new VolumeCalculator(vol);

            IList<IArea> iArea = new List<IArea>();
            iArea.Add(new Circle() { Width = 5 });
            iArea.Add(new Square() { Width = 6 });
            iArea.Add(new Cube() { Width = 5 });


            IList<IVolume> iVolume = new List<IVolume>();
            iVolume.Add(new Cube() { Width = 5 });

            areaCalculator.CalculateArea(iArea);
            volumeCalculator.CalculateVolume(iVolume);
            Console.ReadKey();
        }
    }
}
