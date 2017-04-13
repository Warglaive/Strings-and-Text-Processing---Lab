using System;

namespace _03.Text_Filter
{
    public class Program
    {
       public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new[] { ' ', ',' }
            , StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}