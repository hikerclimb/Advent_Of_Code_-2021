using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static int output = 0;
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
            
            for(int i = 0; i<=input.Count-4; i++)
            { 
                Console.WriteLine(i);
                int first = Add3(input[i], input[i + 1], input[i + 2]);
                Console.WriteLine("first:" + first);
                int second = Add3(input[i + 1], input[i + 2], input[i + 3]);
                Console.WriteLine("second:" + second);

                if (second > first)
                {
                    output++;
                }
            }
            Console.WriteLine(output);  
        }

        static int Add3(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }
    }
}
