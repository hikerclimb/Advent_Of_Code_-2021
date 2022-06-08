using System;
using System.Collections.Generic;
using System.IO;

namespace Day3Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            using (var file = new StreamReader(@"C:\Users\Aniket\Documents\Advent Of Code 2021\Day3Problem1\input.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    input.Add(line);
                }
            }

            int[] num_Of_Zeros = new int[input[0].Length];
            int[] num_Of_Ones = new int[input[0].Length]; 
            string gamma_rate = "";
            string epsilon_rate = "";
            for (int i = 0; i < input.Count; i++)
            {
                //Console.WriteLine("i:" + i);
                for (int j = 0; j < input[i].Length; j++)
                {
                    //Console.WriteLine("j:" + j);
                    if (Convert.ToInt32(input[i][j].ToString())==0)
                    {
                        //Console.WriteLine("enter zeros");
                        num_Of_Zeros[j]++;
                    }
                    else if (Convert.ToInt32(input[i][j].ToString())==1)
                    {
                        //Console.WriteLine("enter ones");
                        num_Of_Ones[j]++;   
                    }
                }
            }

            for (int j = 0; j < num_Of_Zeros.Length; j++)
            {
                //find most common bit
                gamma_rate = gamma_rate + find_Most_Common(num_Of_Zeros[j], num_Of_Ones[j]);
            }

            for (int j = 0; j < num_Of_Zeros.Length; j++)
            {
                //find most common bit
                epsilon_rate = epsilon_rate + find_Least_Common(num_Of_Zeros[j], num_Of_Ones[j]);
            }

            /*Console.WriteLine("Zeros");
            foreach (var num in num_Of_Zeros)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Ones");
            foreach (var num in num_Of_Ones)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("gamma_rate:" + gamma_rate);
            Console.WriteLine("epsilon_rate:"+ epsilon_rate);*/

            int gamma_rate_decimal = Convert.ToInt32(gamma_rate, 2);
            int epsilon_rate_decimal = Convert.ToInt32(epsilon_rate, 2);

            Console.WriteLine("output:" + gamma_rate_decimal * epsilon_rate_decimal);
        }

        static string find_Most_Common(int first_Column, int second_Column)
        {
            string gamma_rates = "";
            if (first_Column > second_Column)
            {
                gamma_rates = gamma_rates + "0";
            }
            if (first_Column < second_Column)
            {
                gamma_rates = gamma_rates + "1";
            }
            return gamma_rates;
        }
                
        static string find_Least_Common(int first, int second)
        {
            string epsilon_rates = "";
            if (first < second)
            {
                epsilon_rates = "0" + epsilon_rates;
            }
            if (first > second)
            {
                epsilon_rates = "1" + epsilon_rates;
            }
            return epsilon_rates;
        }
    }
}
