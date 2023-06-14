using Gun3Odev2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun3Odev2
{
    public class Add
    {
        public int Add1(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        public int Add2(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //fonksiyon için number1 verilmek zorunda 
        public int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}




