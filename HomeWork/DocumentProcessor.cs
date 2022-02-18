using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork
{
    public class DocumentProcessor : IDocumentProcessor
    {
        public Stats Analyze(string document)
        {
            Stats stats = new Stats();
            // Number Of All Words
            var number =document.Split(' ');
            stats.NumberOfAllWords = number.ToList().Count;

            //  Number Of Words That Contain Only Digits
            int i = 0;
            int capitlCount = 0;
            int smallLetter = 0;
            //var numberWithOnlyDigit = number.All(Char.IsDigit);
            foreach (var num in number)
            {
                //var cha = Convert.ToChar(num);
                Regex rx = new Regex(@"^([1-9]\d*(\.)\d*|0?(\.)\d*[1-9]\d*|[1-9]\d*)$");
                if (rx.IsMatch(num))
                {
                    if (Convert.ToInt32(num) <= 0 || Convert.ToInt32(num) >= 9)
                    {
                        i++;
                    }
                }
                //string result = Regex.Replace(num, @"[^\d]", "").Trim();
                Regex rxCap = new Regex(@"(?=.*[A-Z])");
                

                if (rxCap.IsMatch(num))
                {
                    capitlCount++;

                }
                

                if (Char.IsLower(num[0]))
                {
                    smallLetter++;

                }


            }
            stats.NumberOfWordsThatContainOnlyDigits = i;


            stats.NumberOfWordsStartingWithCapitalLetter = capitlCount;

            var list = document.Split(' ').OrderByDescending(c=>c.Length).First();
            stats.TheLongestWord = list;

            var last = document.Split(' ').OrderBy(c => c.Length).First();
            stats.TheShortestWord = last;

            stats.NumberOfWordsStartingWithSmallLetter = smallLetter;





            return stats;
        }
    }
}
