using System;
using System.Collections.Generic;

public class CountWords
{
    private Dictionary<string, int> _wordCounts;

    public CountWords()
    {
        _wordCounts = new Dictionary<string, int>();
    }

    public void AddWord(string word)
    {
        if (_wordCounts.ContainsKey(word))
        {
            _wordCounts[word]++;
        }
        else
        {
            _wordCounts[word] = 1;
        }
    }

    public int GetWordCount(string word)
    {
        if (_wordCounts.ContainsKey(word))
        {
            return _wordCounts[word];
        }
        else
        {
            return 0;
        }
    }

    public void PrintWordCounts()
    {
        foreach (KeyValuePair<string, int> kvp in _wordCounts)
        {
            Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        }
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

        counter.PrintWordCounts();
    }
}

