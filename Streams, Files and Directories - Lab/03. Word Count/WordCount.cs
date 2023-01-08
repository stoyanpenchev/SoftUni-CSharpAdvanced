﻿//Write a program that reads a list of words from a given file (e. g. words.txt) and finds how many times each of the words occurs in another file (e. g. text.txt). Matching should be case-insensitive. The result should be written to an output text file (e. g. output.txt). Sort the words by frequency in descending order.

namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] words;
            using (var reader = new StreamReader(wordsFilePath))
            {
                words = reader.ReadToEnd().Split();                
            }
            string[] inputText;
            char[] separators = { ' ', '.', ',', '-', '?', '!', };
            using (var reader = new StreamReader(textFilePath))
            {
                inputText = reader.ReadToEnd().Split(separators);
            }
            var wordOccurences = new Dictionary<string, int>();

            foreach (var wordToFind in words)
                foreach (var inputWord in inputText)
                    if (wordToFind.ToLower() == inputWord.ToLower())
                    {
                        if (!wordOccurences.ContainsKey(wordToFind))
                            wordOccurences.Add(wordToFind, 0);
                        wordOccurences[wordToFind]++;
                    }

            using (var writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in wordOccurences.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
