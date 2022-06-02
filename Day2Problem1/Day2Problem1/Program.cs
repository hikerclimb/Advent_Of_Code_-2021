using System;
using System.Collections.Generic;
using System.IO;

namespace Day2Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            using (var file = new StreamReader(@"C:\Users\Aniket\Documents\Advent Of Code 2021\Day2Problem1\input.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    input.Add(line);
                }
            }

            List<string[]> command_and_num = new List<string[]>();
            int horizontal = 0;
            int depth = 0;

            foreach(var line in input)
            {
                command_and_num.Add(line.Split(" "));
            }

            for(int i = 0; i < command_and_num.Count; i++)
            {
                if (command_and_num[i][0]=="forward")
                {
                    horizontal = horizontal + Convert.ToInt32(command_and_num[i][1]);
                }
                if(command_and_num[i][0]=="down")
                {
                    depth = depth - Convert.ToInt32(command_and_num[i][1]);
                }
                if (command_and_num[i][0] == "up")
                {
                    depth = depth + Convert.ToInt32(command_and_num[i][1]);
                }
            }
            Console.WriteLine("horizontal" + horizontal);
            Console.WriteLine("depth" + depth);
            Console.WriteLine(depth * horizontal);

        }
    }
}
