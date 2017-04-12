using System;
using System.Collections.Generic;

namespace SolidPractice
{
    class SolidClass
    {
        //Interfaces------------------------------------------------------------------------------------
        public interface IShape
        {
            int Width { get; set; }
            
        }
        public interface IArea
        {
            double GetArea();
        }

        public interface IVolume
        {
            double GetVolume();
        }

        public interface IAreaCalculator
        {
            double CalculateArea(IList<IArea> shapes);
        }

        public interface IMessanger
        {
            void Message(double val);

        }

        public interface IVolumeCalculator
        {
            double CalculateVolume(IList<IVolume> shapes);
        }
        //----------------------------------------------------------------------------------------------------------

        //Shapes------------------------------------------------------------------------------------------------------
        public class Square : IShape, IArea
        {
            private int width;
            public Square()
            {
            }

            public int Width
            {
                get { return width; }
                set { width = value; }
            }

            public double GetArea()
            {
                double area = Width * Width;
                return area;
            }
        }

        public class Circle : IShape, IArea
        {
            private int width;
            public Circle()
            {
            }

            public int Width
            {
                get { return width; }
                set { width = value; }
            }

            public double GetArea()
            {
                double area = Math.PI * (width / 2) * (width / 2);
                return area;
            }
        }

        public class Equilateral_Triangle : IShape, IArea
        {
            private int width;
            public Equilateral_Triangle()
            {
            }

            public int Width
            {
                get { return width; }
                set { width = value; }
            }

            public double GetArea()
            {
                double area = (Math.Sqrt(3) / 4) * width * width;
                return area;
            }

        }


        public class Cube : IShape,IArea,IVolume
        {
            private int width;
            public int Width
            {
                get { return width; }
                set { width = value; }
            }

            public double GetArea()
            {
                return 6 * Width * Width;
            }

            public double GetVolume()
            {
                return Width * Width * Width;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------

        public class AreaCalculator : IAreaCalculator
        {
            IMessanger messager;
            public AreaCalculator(IMessanger msg)
            {
                messager = msg;
            }
            public double CalculateArea(IList<IArea> shapes)
            {
                double totalArea = 0;
                foreach (IArea shape in shapes)
                {
                    totalArea += shape.GetArea();
                }
                messager.Message(totalArea);
                return totalArea;
            }
        }

        public class VolumeCalculator : IVolumeCalculator
        {
            IMessanger messager;
            public VolumeCalculator(IMessanger msg)
            {
                messager = msg;
            }

            public double CalculateVolume(IList<IVolume> shapes)
            {
                double totalVolume = 0;
                foreach (var shape in shapes)
                {
                    totalVolume += shape.GetVolume();
                }
                messager.Message(totalVolume);
                return totalVolume;
            }
        }

        public class VolEnglishMessanger : IMessanger
        {
            public void Message(double volume)
            {
                Console.WriteLine("The total Volume is " + volume);
            }
        }

        public class VolFrenchMessanger : IMessanger
        {
            public void Message(double volume)
            {
                Console.WriteLine("Le volume total est " + volume);
            }
        }

        public class AreaEnglishMessanger : IMessanger
        {
            public void Message(double area)
            {
                Console.WriteLine("The total Area is " + area);
            }
        }

    }
}
