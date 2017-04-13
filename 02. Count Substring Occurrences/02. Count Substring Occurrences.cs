using System;

namespace _02.Count_Substring_Occurrences
{
    public class Program
    {
       public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var counter = 0;
            var index = -1;
            while (true)
            {
                index = text.IndexOf(pattern, index + 1);
                if (index < 0) 
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}