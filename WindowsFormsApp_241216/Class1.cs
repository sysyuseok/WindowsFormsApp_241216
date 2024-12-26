using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_241216
{
    internal class Class1
    {
        public int myOwnCalculator(int num1,int num2,char oper)
        {
            if (oper == '+')
            {
                return num1 + num2;
            }
            else if (oper == '-')
            {
                return num1- num2;
            }
            else if (oper == '/')
            {
                return num1 / num2;
            }
            else if (oper == '*')
            {
                return num1 * num2;
            }
            else
            {
                return 1000000000;
            }
        }
    }
}
