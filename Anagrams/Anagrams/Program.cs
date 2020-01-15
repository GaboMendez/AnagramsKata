using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadKey();
        }

        public static bool IsAnagrams(string str1, string str2)
        {
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1.Equals(val2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
