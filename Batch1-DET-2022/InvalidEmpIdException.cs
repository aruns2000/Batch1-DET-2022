using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class InvalidEmpIdException:Exception
    {
        internal bool msg;

        public InvalidEmpIdException(string msg):base(msg)
        {

        }
    }
}
