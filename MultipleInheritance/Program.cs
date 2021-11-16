using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseInterfaceChildNormal
{
    class Program
    {
        static void Main(string[] args)
        {
            IArea ar = new Circle();
            ar.calculatearea();
            ar.calculateperimeter();
            ICircleArea cr = new Circle();
            cr.calculatearea();
            Circle cri = new Circle();
            cri.calculateperimeter();

        }

        public interface IArea
        {
            void calculatearea();

            void calculateperimeter();

        }

        public interface ICircleArea
        {
            void calculatearea();

        }

        public class Circle : IArea, ICircleArea
        {
             void IArea.calculatearea()
            {
                Console.WriteLine("Area  method implemented");
            }

            void ICircleArea.calculatearea()
            {
                Console.WriteLine("CircleArea method implemented");
            }
           

            public void calculateperimeter()
            {
                Console.WriteLine("child class perimeter");
            }

        }


    }
}
