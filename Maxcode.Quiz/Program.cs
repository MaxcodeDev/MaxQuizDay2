using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Maxcode.Quiz
{
    class Program
    {
        /*
         * Maxquiz Olympics Day 2
         * Do not change initialization of DavidLetterman class
         * You should add methods in DavidLetterman class only!
         * Good luck!
         * Submit your response here https://docs.google.com/forms/d/e/1FAIpQLScdpCWlr8IICuXmEwkzom7-A8tbMzat6uVbTtjkUpmDSlfWbg/viewform
         * Read more about rules and prizes here https://www.facebook.com/notes/maxcode/maxquiz-rulebook-/3195266267201373/
         */
        static void Main(string[] args)
        {
            var letters = new[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            var davidLetterman = new DavidLetterman
            {
                'a',
                {'b'},
                'c',
                letters.Where(x => x % 2 == 0),
                {letters.Where(x => x % 2 == 1)}
            };

            foreach (var letter in davidLetterman)
            {
                Console.WriteLine(letter);
            }
        }

        class DavidLetterman : IEnumerable<char>
        {
            private readonly List<char> _myLetters = new List<char>();
            public IEnumerator<char> GetEnumerator() => _myLetters.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            /*
             * Your code goes here
             */
        }
    }
}