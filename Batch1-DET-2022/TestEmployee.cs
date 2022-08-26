using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmployee
    {
        public static void Main()
        {
            Employee e = new Employee(200, "arun", "bg", 5632, 73386524, 20000, 200);
            int result = e.GetEmpSalary();


            Console.WriteLine($"The Netsalary is  {e.GetEmpSalary()}");

        }
    }
}
