﻿using System;
using System.Collections.Generic;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Iris> irises = new List<Iris>()
            {
                #region IrisesSetosa

                new IrisSetosa(5.1, 3.5, 1.4, 0.2),
                new IrisSetosa(4.9, 3.0, 1.4, 0.2),
                new IrisSetosa(4.7, 3.2, 1.3, 0.2),
                new IrisSetosa(4.6, 3.1, 1.5, 0.2),
                new IrisSetosa(5.0, 3.6, 1.4, 0.2),
                new IrisSetosa(5.4, 3.9, 1.7, 0.4),
                new IrisSetosa(4.6, 3.4, 1.4, 0.3),
                new IrisSetosa(5.0, 3.4, 1.5, 0.2),
                new IrisSetosa(4.4, 2.9, 1.4, 0.2),
                new IrisSetosa(4.9, 3.1, 1.5, 0.1),
                new IrisSetosa(5.4, 3.7, 1.5, 0.2),
                new IrisSetosa(4.8, 3.4, 1.6, 0.2),
                new IrisSetosa(4.8, 3.0, 1.4, 0.1),
                new IrisSetosa(4.3, 3.0, 1.1, 0.1),
                new IrisSetosa(5.8, 4.0, 1.2, 0.2),
                new IrisSetosa(5.7, 4.4, 1.5, 0.4),
                new IrisSetosa(5.4, 3.9, 1.3, 0.4),
                new IrisSetosa(5.1, 3.5, 1.4, 0.3),
                new IrisSetosa(5.7, 3.8, 1.7, 0.3),
                new IrisSetosa(5.1, 3.8, 1.5, 0.3),
                new IrisSetosa(5.4, 3.4, 1.7, 0.2),
                new IrisSetosa(5.1, 3.7, 1.5, 0.4),
                new IrisSetosa(4.6, 3.6, 1.0, 0.2),
                new IrisSetosa(5.1, 3.3, 1.7, 0.5),
                new IrisSetosa(4.8, 3.4, 1.9, 0.2),
                new IrisSetosa(5.0, 3.0, 1.6, 0.2),
                new IrisSetosa(5.0, 3.4, 1.6, 0.4),
                new IrisSetosa(5.2, 3.5, 1.5, 0.2),
                new IrisSetosa(5.2, 3.4, 1.4, 0.2),
                new IrisSetosa(4.7, 3.2, 1.6, 0.2),
                new IrisSetosa(4.8, 3.1, 1.6, 0.2),
                new IrisSetosa(5.4, 3.4, 1.5, 0.4),
                new IrisSetosa(5.2, 4.1, 1.5, 0.1),
                new IrisSetosa(5.5, 4.2, 1.4, 0.2),
                new IrisSetosa(4.9, 3.1, 1.5, 0.1),
                new IrisSetosa(5.0, 3.2, 1.2, 0.2),
                new IrisSetosa(5.5, 3.5, 1.3, 0.2),
                new IrisSetosa(4.9, 3.1, 1.5, 0.1),
                new IrisSetosa(4.4, 3.0, 1.3, 0.2),
                new IrisSetosa(5.1, 3.4, 1.5, 0.2),
                new IrisSetosa(5.0, 3.5, 1.3, 0.3),
                new IrisSetosa(4.5, 2.3, 1.3, 0.3),
                new IrisSetosa(4.4, 3.2, 1.3, 0.2),
                new IrisSetosa(5.0, 3.5, 1.6, 0.6),
                new IrisSetosa(5.1, 3.8, 1.9, 0.4),
                new IrisSetosa(4.8, 3.0, 1.4, 0.3),
                new IrisSetosa(5.1, 3.8, 1.6, 0.2),
                new IrisSetosa(4.6, 3.2, 1.4, 0.2),
                new IrisSetosa(5.3, 3.7, 1.5, 0.2),
                new IrisSetosa(5.0, 3.3, 1.4, 0.2),

                #endregion
              
                #region IrisesVersicolor
                
                new IrisVersicolor(7.0, 3.2, 4.7, 1.4),
                new IrisVersicolor(6.4, 3.2, 4.5, 1.5),
                new IrisVersicolor(6.9, 3.1, 4.9, 1.5),
                new IrisVersicolor(5.5, 2.3, 4.0, 1.3),
                new IrisVersicolor(6.5, 2.8, 4.6, 1.5),
                new IrisVersicolor(5.7, 2.8, 4.5, 1.3),
                new IrisVersicolor(6.3, 3.3, 4.7, 1.6),
                new IrisVersicolor(4.9, 2.4, 3.3, 1.0),
                new IrisVersicolor(6.6, 2.9, 4.6, 1.3),
                new IrisVersicolor(5.2, 2.7, 3.9, 1.4),
                new IrisVersicolor(5.0, 2.0, 3.5, 1.0),
                new IrisVersicolor(5.9, 3.0, 4.2, 1.5),
                new IrisVersicolor(6.0, 2.2, 4.0, 1.0),
                new IrisVersicolor(6.1, 2.9, 4.7, 1.4),
                new IrisVersicolor(5.6, 2.9, 3.6, 1.3),
                new IrisVersicolor(6.7, 3.1, 4.4, 1.4),
                new IrisVersicolor(5.6, 3.0, 4.5, 1.5),
                new IrisVersicolor(5.8, 2.7, 4.1, 1.0),
                new IrisVersicolor(6.2, 2.2, 4.5, 1.5),
                new IrisVersicolor(5.6, 2.5, 3.9, 1.1),
                new IrisVersicolor(5.9, 3.2, 4.8, 1.8),
                new IrisVersicolor(6.1, 2.8, 4.0, 1.3),
                new IrisVersicolor(6.3, 2.5, 4.9, 1.5),
                new IrisVersicolor(6.1, 2.8, 4.7, 1.2),
                new IrisVersicolor(6.4, 2.9, 4.3, 1.3),
                new IrisVersicolor(6.6, 3.0, 4.4, 1.4),
                new IrisVersicolor(6.8, 2.8, 4.8, 1.4),
                new IrisVersicolor(6.7, 3.0, 5.0, 1.7),
                new IrisVersicolor(6.0, 2.9, 4.5, 1.5),
                new IrisVersicolor(5.7, 2.6, 3.5, 1.0),
                new IrisVersicolor(5.5, 2.4, 3.8, 1.1),
                new IrisVersicolor(5.5, 2.4, 3.7, 1.0),
                new IrisVersicolor(5.8, 2.7, 3.9, 1.2),
                new IrisVersicolor(6.0, 2.7, 5.1, 1.6),
                new IrisVersicolor(5.4, 3.0, 4.5, 1.5),
                new IrisVersicolor(6.0, 3.4, 4.5, 1.6),
                new IrisVersicolor(6.7, 3.1, 4.7, 1.5),
                new IrisVersicolor(6.3, 2.3, 4.4, 1.3),
                new IrisVersicolor(5.6, 3.0, 4.1, 1.3),
                new IrisVersicolor(5.5, 2.5, 4.0, 1.3),
                new IrisVersicolor(5.5, 2.6, 4.4, 1.2),
                new IrisVersicolor(6.1, 3.0, 4.6, 1.4),
                new IrisVersicolor(5.8, 2.6, 4.0, 1.2),
                new IrisVersicolor(5.0, 2.3, 3.3, 1.0),
                new IrisVersicolor(5.6, 2.7, 4.2, 1.3),
                new IrisVersicolor(5.7, 3.0, 4.2, 1.2),
                new IrisVersicolor(5.7, 2.9, 4.2, 1.3),
                new IrisVersicolor(6.2, 2.9, 4.3, 1.3),
                new IrisVersicolor(5.1, 2.5, 3.0, 1.1),
                new IrisVersicolor(5.7, 2.8, 4.1, 1.3),

                #endregion

                #region IrisesVirginica

                new IrisVirginica(6.3, 3.3, 6.0, 2.5),
                new IrisVirginica(5.8, 2.7, 5.1, 1.9),
                new IrisVirginica(7.1, 3.0, 5.9, 2.1),
                new IrisVirginica(6.3, 2.9, 5.6, 1.8),
                new IrisVirginica(6.5, 3.0, 5.8, 2.2),
                new IrisVirginica(7.6, 3.0, 6.6, 2.1),
                new IrisVirginica(4.9, 2.5, 4.5, 1.7),
                new IrisVirginica(7.3, 2.9, 6.3, 1.8),
                new IrisVirginica(6.7, 2.5, 5.8, 1.8),
                new IrisVirginica(7.2, 3.6, 6.1, 2.5),
                new IrisVirginica(6.5, 3.2, 5.1, 2.0),
                new IrisVirginica(6.4, 2.7, 5.3, 1.9),
                new IrisVirginica(6.8, 3.0, 5.5, 2.1),
                new IrisVirginica(5.7, 2.5, 5.0, 2.0),
                new IrisVirginica(5.8, 2.8, 5.1, 2.4),
                new IrisVirginica(6.4, 3.2, 5.3, 2.3),
                new IrisVirginica(6.5, 3.0, 5.5, 1.8),
                new IrisVirginica(7.7, 3.8, 6.7, 2.2),
                new IrisVirginica(7.7, 2.6, 6.9, 2.3),
                new IrisVirginica(6.0, 2.2, 5.0, 1.5),
                new IrisVirginica(6.9, 3.2, 5.7, 2.3),
                new IrisVirginica(5.6, 2.8, 4.9, 2.0),
                new IrisVirginica(7.7, 2.8, 6.7, 2.0),
                new IrisVirginica(6.3, 2.7, 4.9, 1.8),
                new IrisVirginica(6.7, 3.3, 5.7, 2.1),
                new IrisVirginica(7.2, 3.2, 6.0, 1.8),
                new IrisVirginica(6.2, 2.8, 4.8, 1.8),
                new IrisVirginica(6.1, 3.0, 4.9, 1.8),
                new IrisVirginica(6.4, 2.8, 5.6, 2.1),
                new IrisVirginica(7.2, 3.0, 5.8, 1.6),
                new IrisVirginica(7.4, 2.8, 6.1, 1.9),
                new IrisVirginica(7.9, 3.8, 6.4, 2.0),
                new IrisVirginica(6.4, 2.8, 5.6, 2.2),
                new IrisVirginica(6.3, 2.8, 5.1, 1.5),
                new IrisVirginica(6.1, 2.6, 5.6, 1.4),
                new IrisVirginica(7.7, 3.0, 6.1, 2.3),
                new IrisVirginica(6.3, 3.4, 5.6, 2.4),
                new IrisVirginica(6.4, 3.1, 5.5, 1.8),
                new IrisVirginica(6.0, 3.0, 4.8, 1.8),
                new IrisVirginica(6.9, 3.1, 5.4, 2.1),
                new IrisVirginica(6.7, 3.1, 5.6, 2.4),
                new IrisVirginica(6.9, 3.1, 5.1, 2.3),
                new IrisVirginica(5.8, 2.7, 5.1, 1.9),
                new IrisVirginica(6.8, 3.2, 5.9, 2.3),
                new IrisVirginica(6.7, 3.3, 5.7, 2.5),
                new IrisVirginica(6.7, 3.0, 5.2, 2.3),
                new IrisVirginica(6.3, 2.5, 5.0, 1.9),
                new IrisVirginica(6.5, 3.0, 5.2, 2.0),
                new IrisVirginica(6.2, 3.4, 5.4, 2.3),
                new IrisVirginica(5.9, 3.0, 5.1, 1.8),

                #endregion
            };

            Iris.Analyze(irises);

            Console.ReadKey();
        }
    }

    abstract class Iris
    {
        public int Count { get; set; }

        public double SepalLength { get; set; }
        public double SepalWidth { get; set; }
        public double PetalLength { get; set; }
        public double PetalWidth { get; set; }

        private static int count = 0;

        protected Iris(double SepalLength, double SepalWidth, double PetalLength, double PetalWidth)
        {
            this.Count = ++count;

            this.SepalLength = SepalLength;
            this.SepalWidth = SepalWidth;
            this.PetalLength = PetalLength;
            this.PetalWidth = PetalWidth;
        }

        public override string ToString()
        {
            return "#" + this.Count + " | " + this.SepalLength + " | " + this.SepalWidth + " | " + this.PetalLength + " | " + this.PetalWidth;
        }
        
        public static void Analyze(List<Iris> irises)
        {
            foreach (Iris iris in irises)
            {
                if (iris.PetalWidth < 0.7)
                {
                    if (iris.Count > 50)
                    {
                        Console.WriteLine(iris + " | " + "type is IrisSetosa");
                    }
                }
                else if (iris.PetalWidth > 1.6 || iris.PetalLength > 4.9)
                {
                    if (iris.Count < 101)
                    {
                        Console.WriteLine(iris + " | " + "type is IrisVirginica");
                    }
                }
                else
                {
                    if (iris.Count < 50 || iris.Count > 101)
                    {
                        Console.WriteLine(iris + " | " + "type is IrisVersicolor");
                    }
                }
            }
        }
    }

    class IrisSetosa : Iris
    {
        public IrisSetosa(double SepalLength, double SepalWidth, double PetalLength, double PetalWidth)
            : base(SepalLength, SepalWidth, PetalLength, PetalWidth)
        { }
    }

    class IrisVersicolor : Iris
    {
        public IrisVersicolor(double SepalLength, double SepalWidth, double PetalLength, double PetalWidth)
            : base(SepalLength, SepalWidth, PetalLength, PetalWidth)
        { }
    }

    class IrisVirginica : Iris
    {
        public IrisVirginica(double SepalLength, double SepalWidth, double PetalLength, double PetalWidth)
            : base(SepalLength, SepalWidth, PetalLength, PetalWidth)
        { }
    }
}
