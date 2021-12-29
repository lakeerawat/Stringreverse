using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
 class Program
    {
        static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) { return input; }
           StringBuilder result = new StringBuilder();
            string[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length ; i++)
            {
                result.Append(ReverseString(arr[i]));
                if(i != arr.Length - 1)
                {
                    result.Append(" ");
                }
            }
            return result.ToString().ToLower();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Welocome to the world"));
        }
    }
}
