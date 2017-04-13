using System;
using System.Linq;
namespace _01.Reverse_String
{
    public class Program
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}