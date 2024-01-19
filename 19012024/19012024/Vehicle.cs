using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19012024
{
    internal abstract class Vehicle
    {
        private string _brand;
        public string Model;
        public decimal Milleage;

        public string Brand
        {
            get { return _brand; }
            set
            {
                if(LetterCheck(value))
                    _brand= value;
            }
        }

        public abstract void Drive(decimal km);

        public bool LetterCheck(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                    return false;  
                   
            }
            return true;
        }
    }
}
