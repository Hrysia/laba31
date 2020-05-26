using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str1;
            string str;
            List<int> b = new List<int>();

            Console.WriteLine("Enter the sentence");
            str = Console.ReadLine();
            str = str.Trim();
            Console.WriteLine(Regex.Replace(str, "[ ]+", " "));

            string[] split = str.Split(new Char[] { ' ', ',', '.' });

            for (int j = 0; j < split.Length; j++)
            {
                b.Add(0);
                str1 = split[j].ToCharArray();
                for (int i = 0; i < str1.Length; i++)
                {
                    if ((str1[i] == 'a') || (str1[i] == 'e') || (str1[i] == 'i') || (str1[i] == 'o') || (str1[i] == 'u') || (str1[i] == 'y'))
                    {

                        b[j] += 1;
                    }

                }

            }
            int max = 0;
            for (int j = 0; j < split.Length; j++)
            {
                max = b[j];
                if (b[j] > max)
                {
                    max = b[j];
                }
            }
            Console.WriteLine(split[max]);

        }
    }
}
