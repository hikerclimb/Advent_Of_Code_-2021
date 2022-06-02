using System;
using System.Collections.Generic;
using System.IO;

namespace Day1Problem1
{
    internal class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            //read every line
            List<int> input = new List<int>();
            using (var file = new StreamReader(@"C:\Users\Aniket\Documents\Advent Of Code 2021\Day1Problem1\input.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    input.Add(Convert.ToInt32(line));   
                }
            }
            
            for(int i = 0; i < input.Count-1; i++)
            {
                Compare(Convert.ToInt32(input[i]), Convert.ToInt32(input[i + 1]));
            }

            Console.WriteLine(count);
        }

        static void Compare(int first, int second)
        {
            if (first - second < 0)
            {
                count++;
            }
        }
    }
}
