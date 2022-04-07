using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SumOfNNumber
    {
      public int sumOfNumber(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum=sum+i;
            }
            return sum;
        }
      //public static void Main()
      //  {
      //      SumOfNNumber sumOfNNumber=new SumOfNNumber();
      //      Console.WriteLine(sumOfNNumber.sumOfNumber(5));
      //  }
    }
}
