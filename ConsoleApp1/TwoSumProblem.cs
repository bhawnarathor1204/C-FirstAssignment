using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TwoSumProblem
    {
        public Boolean twoSum(int[] arr, int total)
        {
            Boolean flag=false;
            //int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == total)
                    {
                       flag = true;
                        break;
                    }

                }
            }
            return flag;
        }

        //public static void Main(String[]args)
        //{
        //    TwoSumProblem twoSumProblem = new TwoSumProblem();
        //    int[] a = {3, 5, 2, -4, 8, 11};
        //    Boolean flag=twoSumProblem.twoSum(a,7);
        //    if (flag)
        //        Console.WriteLine("Pair is present whose sum is total in array");
        //    else
        //    {
        //        Console.WriteLine("Pair is Not present");
        //    }
        //}

    }

}

// return all pairs of integers that sum to S
