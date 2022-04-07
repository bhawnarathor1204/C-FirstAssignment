using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Factorial
    {
        public int getFactorial(int n)
        {
            if(n == 0 || n < 0)
            {
                return 0;
            }
            int fact = 1;
            for(int i = n; i >0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
        //public static void Main(String[]args)
        //{
        //    Factorial factorial=new Factorial();
        //    int fact=factorial.getFactorial(5);
        //    Console.WriteLine(fact);
        //}
    }
}
