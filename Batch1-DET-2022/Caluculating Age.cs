using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Caluculating_Age
    {
        public static void Main()
        {
            Console.WriteLine("Enter your date of birth");
          
           
        }
        public static int getAge(DateTime dob)
        {
            int age;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            return age;
        }
        public int getAge2(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.AddYears(-dob.Year).Year;
            return age;
        }
    }
}
