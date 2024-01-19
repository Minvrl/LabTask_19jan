using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19012024
{
    internal class Bicycle:Vehicle
    {
        string milleageStr;
        decimal milleage;   
        public override void Drive(decimal km)
        {
          
            Milleage += km;
        }
    }
}
