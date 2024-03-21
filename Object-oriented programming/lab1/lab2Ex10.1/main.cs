using System;
using System.Text.RegularExpressions;

class Parser
{
      private Regex regex = new Regex(@"(https?:\/\/)([^\s<>""'()\[\]]+)([:\d\/\w])?([^\s<>""'()\[\]]+)?");

    public void Parse()
    {
        Console.WriteLine("Enter the expression:");
        string input = Console.ReadLine();

        Match matches = regex.Match(input);

        if (matches.Success)
        {
            string part1 = matches.Groups[1].Value;
            string part2 = matches.Groups[2].Value;
            string part3 = matches.Groups[3].Value;
            string part4 = matches.Groups[4].Value;


            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parser parser = new Parser();
        parser.Parse();
    }
}