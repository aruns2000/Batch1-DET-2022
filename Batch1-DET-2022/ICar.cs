using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public interface ICar
    {
        int GetPrice(String Name);

    }

    class Hyundai : ICar
    {
        public int GetPrice(String Name)
        {

        if(Name == "HG")
            return 1000000;
        else if(Name == "GH")
            return 1200000;
        else
            return 120000;
        }
        

} 
    class BMW:ICar
    {
        public int GetPrice(String Name)
        {

            if (Name == "HG")
                return 1000000;
            else if (Name == "GH")
                return 1200000;
            else
                return 120000;
        }




    }


}
