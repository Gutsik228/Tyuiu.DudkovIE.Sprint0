using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DudkovIE.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Substraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Divison(int a, int b)
        {
            if (b == 0) 
            {
                Console.WriteLine("На ноль делить нельзя");
                return -1;
            }
            else
                return a / b;
        }
    }
}