using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class F
    {
        public static string RL()
        {
            return Console.ReadLine() + "";
        }
        public static void W(string a)
        {
            Console.Write(a);
        }
        public static void WL(string a)
        {
            Console.WriteLine(a);
        }
        public static int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
        public static int Diff(string a, string b)
        {
            return int.Parse(a) - int.Parse(b);
        }
        public static int Times(string a, string b)
        {
            return int.Parse(a) * int.Parse(b);
        }
        public static int DividedBy(string a, string b)
        {
            return int.Parse(a) / int.Parse(b);
        }
    }
}
