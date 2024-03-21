using System;
using System.Text.RegularExpressions;

class Search_For_Strengths
{
    static void Main(string[] args)
    {
        // Введення тексту
        Console.WriteLine("Введіть текст:");
        string link = Console.ReadLine();

        // Регулярний вираз для пошуку валідних посилань
        string pattern = @"(https?:\/\/)([^\s<>""'()\[\]]+)([:\d\/\w])?([^\s<>""'()\[\]]+)?";
        Regex regex = new Regex(pattern);

        // Пошук всіх посилань у тексті
        MatchCollection matches = regex.Matches(link);

        // Вивід знайдених посилань
        if (matches.Count > 0)
        {
            Console.WriteLine("Знайдено {0} посилань:", matches.Count);
            foreach (Match match in matches)
            {
                Console.WriteLine("   - {0}", match.Value);
            }
        }
        else
        {
            Console.WriteLine("Посилання не знайдено.");
        }
    }
}
