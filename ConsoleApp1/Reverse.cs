using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reverse
    {
        public String GetReverseString(String s)
        {
            string s1 = "";
            char[]ch=s.ToCharArray();
            for(int i =ch.Length-1;i>=0; i--)
            {
               s1=s1+ch[i]; 
            }
            return s1;
        }
      //public static void Main(String[] args)
      //  {
      //      Reverse reverse=new Reverse();
      //      String s=reverse.GetReverseString("bhawna");
      //      Console.WriteLine(s);
      //  }
    }
}
