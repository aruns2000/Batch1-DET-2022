using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
     class Genericdelegate
    {
        public static void Main()
        {
            //Action<string> helo = delegate (string name)
            //{
            //    Console.Write("Hello Name");
            //};

            Action<string> helo =  (string name) =>
            {
                Console.Write("Hello Name");
            };



        }
        static void Hi(string name)
        {
            Console.WriteLine("Hai" + name);
        }
    }
}
