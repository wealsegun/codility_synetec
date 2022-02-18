using System;

namespace HomeWork
{
    class Program
    {
        public Program()
        {

        }
        static void Main(string[] args)
        {
            DocumentProcessor doc = new DocumentProcessor();
            string data = "I'm a very good programmer. Even though I am 12 years old.";
            var response = doc.Analyze(data);
            Console.WriteLine("Number Of All Words = " + response.NumberOfAllWords);
            Console.WriteLine("Number Of Words Starting With Capital Letter  = " + response.NumberOfWordsStartingWithCapitalLetter);
            Console.WriteLine("Number Of Words Starting With Small Letter  = " + response.NumberOfWordsStartingWithSmallLetter);
            Console.WriteLine("Number Of Words That Contain Only Digits = " + response.NumberOfWordsThatContainOnlyDigits);
            Console.WriteLine("The Longest Word = " + response.TheLongestWord);
            Console.WriteLine("The Shortest Word = " + response.TheShortestWord);

        }
    }
}
