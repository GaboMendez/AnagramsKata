using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Wait...");
            var ret = DoKata();
            Console.Clear();
            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static List<string> DoKata()
        {
            List<string> words = File.ReadAllLines("wordlist.txt").ToList();
            List<string> ret = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                int count = 0;
                var lineAnagrams = "";
                string str1 = words[i];
                lineAnagrams += $"{str1} | ";
                for (int j = i+1; j < words.Count; j++)
                {
                    string str2 = words[j];

                    bool check = IsAnagrams(str1, str2);

                    if (check)
                    {
                        count++;
                        lineAnagrams += $"{str2} | ";
                    }
                }
                if (i.Equals(1000))
                    break;
                // This ignore only one word anagram in the txt file.
                if(count > 0)
                {
                    ret.Add(lineAnagrams);
                }
            }
            return ret;
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
