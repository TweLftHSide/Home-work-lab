using System;
using System.Collections.Generic;

public class CountWords
{
    private int _wordCount;
    private List<string> _words;

    public CountWords()
    {
        _wordCount = 0;
        _words = new List<string>();
    }

    public void AddWord(string word)
    {
        _wordCount++;
        _words.Add(word);
    }

    public int GetWordCount()
    {
        return _wordCount;
    }

    public List<string> GetWords()
    {
        return _words;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CountWords counter = new CountWords();

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                counter.AddWord(word);
            }
        }

        Console.WriteLine("Кількість слів: {0}", counter.GetWordCount());

        foreach (string word in counter.GetWords())
        {
            Console.WriteLine(word);
        }
    }
}

