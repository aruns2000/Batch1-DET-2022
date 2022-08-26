using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCircle
    {
        public static void Main()
        {
            Circle circle = new Circle();
            double result = circle.area();

            Console.WriteLine($"Area of Circle = {result}");


        }
    }
}
