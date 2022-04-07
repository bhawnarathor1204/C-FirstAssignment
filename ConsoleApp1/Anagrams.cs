using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    public class CheckAnagram
    {
        public Boolean isAnagram(String s1, String s2)
        {    
            //s1.Replace("//s","");
            //s2.Replace("//s","");
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
           
            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] != ch2[i])
                {
                    return false;
                }
            }
            //String val1=new String(ch1);
            //String val2 = new String(ch2);
            //if(val1== val2)
            //    flag = true;
            //if (ch1.SequenceEqual(ch2))
            //{
            //    flag = true;
            //}
            //for (int i = 0; i < ch1.Length; i++)
            //{
            //    if (ch1[i].ToString()!=ch2[i].ToString())
            //    {
            //        flag = false;
            //        break;
            //    }
            //}
            return true;
        }
        //public static void main(String[]args)
        //{
        //    CheckAnagram checkAnagram=new CheckAnagram();
        //    String s1=Console.ReadLine();
        //    String s2 = Console.ReadLine();
        //    Boolean flag=checkAnagram.isAnagram(s1,s2);
        //    if (flag)
        //        Console.WriteLine("String is anagram");
        //    else
        //        Console.WriteLine("String is not  anagram");

        //}

    }
}