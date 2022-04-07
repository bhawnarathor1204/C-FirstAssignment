using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DriverMethod
    {
        public static void Main(String[] args)
        {
            //Console.WriteLine("You want to enter choice = ");
            //String option=Console.ReadLine();
            //while (option == "y" || option = "yes")
            //{
                //Console.WriteLine("Enter 1 for Prime Program /n " +
                //                  "Enter 2 for Anagram /n " +
                //                  "Enter 3 for sumOfNNumber /n " +
                //                  "Enter 4 for factorial /n " +
                //                  "Enter 5 for TwoSum /n" +
                //                  "Enter 6 for StringReverse /n ");

                //int ch = 2;
                ///*Convert.ToInt16(Console.ReadLine());*/
                //switch (ch)
                //{
                //    case 1:
                //        {
                //            PrimeOrNot primeOrNot = new PrimeOrNot();
                //            Console.WriteLine("Enter any number for check prime or not = ");
                //            int n = Convert.ToInt16(Console.ReadLine());
                //            Boolean flag = primeOrNot.isPrime(n);
                //            if (flag)
                //            {
                //                Console.WriteLine("Number is prime");
                //            }
                //            else
                //            {
                //                Console.WriteLine("Number is not prime");
                //            }
                //            break;
                //        }
                //    case 2:
                //        {
                //            CheckAnagram checkAnagram = new CheckAnagram();
                //            Console.WriteLine("Enter first String = ");
                //            String s1 = Console.ReadLine();
                //            Console.WriteLine("Enter second String = ");
                //            String s2 = Console.ReadLine();
                //            Boolean flag = checkAnagram.isAnagram(s1, s2);
                //            if (flag)
                //                Console.WriteLine("String is anagram");
                //            else
                //                Console.WriteLine("String is not  anagram");
                //            break;
                //        }

                //    case 3:
                //        {
                //            SumOfNNumber sumOfNNumber = new SumOfNNumber();
                //            Console.WriteLine("Enter any number for sum = ");
                //            int n = Convert.ToInt16(Console.ReadLine());
                //            Console.WriteLine(sumOfNNumber.sumOfNumber(n));
                //            break;
                //        }
                //    case 4:
                //        {
                //            Factorial factorial = new Factorial();
                //            int fact = factorial.getFactorial(5);
                //            Console.WriteLine(fact);
                //            break;
                //        }

                //    case 5:
                //        {
                //            TwoSumProblem twoSumProblem = new TwoSumProblem();
                //            // int[] a = {3, 5, 2, -4, 8, 11};
                //            int[] a = new int[6];
                //            Console.WriteLine("Enter array values = ");
                //            for (int i = 0; i < 6; i++)
                //            {
                //                a[i] = Convert.ToInt16(Console.ReadLine());
                //            }
                //            Boolean flag = twoSumProblem.twoSum(a, 7);
                //            if (flag)
                //            {
                //                Console.WriteLine("Pair is present whose sum is total in array");
                //            }
                //            else
                //            {
                //                Console.WriteLine("Pair is Not present");
                //            }
                //            break;
                //        }
                //    case 6:
                //        {
                //            Reverse reverse = new Reverse();
                //            Console.WriteLine("Enter any string = ");
                //            String s1 = Console.ReadLine();
                //            String s = reverse.GetReverseString(s1);
                //            Console.WriteLine(s);
                //            break;
                //        }

              UserData userData = new UserData();
                    userData.Name = "bhawna";
                    Console.WriteLine(userData.Name);



         }

               
         }
       

    }

