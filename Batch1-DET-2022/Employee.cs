using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Employee
    {
        int rollNumber;
        String eName;
        String address;
        int pinCode;
        int phonenumber;
        int grossSalary;
        int pf;
        int netSalary;
        public Employee(int rollNumber,String eName,String address,int pinCode,int phonenumber,int grossSalary)
        {
            this.rollNumber = rollNumber;
            this.eName = eName;
            this.address = address;
            this.pinCode = pinCode;
            this.phonenumber = phonenumber;
            this.grossSalary = grossSalary;
            this.pf = pf;
          


        }

        public int GetEmpSalary()
        {
            netSalary = 12 * grossSalary / 100;
            return netSalary;
        }

        public char GetEmployeeDetails()
        {
            if (GetEmpSalary() > 10000)
                return 'A';
            else if (GetEmpSalary() > 8000)
                return 'B';
            else
                return 'C';
        }
       
    }
}
