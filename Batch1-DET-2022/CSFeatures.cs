using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CSFeatures
    {
        public static void Main()
        {
            Action<string> action=(string name)  => { Console.WriteLine($"Hello {name}"); };
            action.Invoke("Arun");

            Action<string, string> action1 = (string s1,string s2) => { Console.WriteLine($"Hello {s1} welcome to {s2}"); };
            action1.Invoke("Arun","csharp Advance");


            Action<int, string,string> action3 = (int s1, string s2,string s3) => { Console.WriteLine($"Hello EmpId {s1} and name {s2} welcome to {s3} deparment"); };
            action3.Invoke(22819, "Arun","Delivery operation");

            //Action<double> action2 = (double radius) => { Console.WriteLine($"Area of circle is {Math.PI * radius * radius}); };
            //action2.Invoke(3.2);
            Func<int, int, long> multiply = (x, y) =>
            {
                return x * y;
            };
            long result = multiply(10, 10);
            Console.WriteLine(result);

            HashSet<int> ids = new HashSet<int>();
            ids.Add(10);
            ids.Add(10);
            ids.Add(123);
            ids.Add(110);


            foreach (int id in ids)
                Console.WriteLine(id);


            

        }

    }
}
