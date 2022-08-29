using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Company
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string  Phone { get; set; }

        public string Website { get; set; }

        public CompanyManager Manager { set; get; }

       override public string ToString()
        {
            return $"Name={Name} ,Address={Address},Website={Website},Manager={Manager.Print()}";
        }
    }
}
