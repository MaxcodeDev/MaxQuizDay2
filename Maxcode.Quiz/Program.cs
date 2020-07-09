using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Maxcode.Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            var w = new DavidLetterman
            {
                'a',
                { 'b' },
                'c',
                letters.Where(x=>x%2==0),
                {  letters.Where(x=>x%2==1) }
            };
            foreach (var v in w)
                Console.WriteLine(v);
        }
    }
    class DavidLetterman : IEnumerable<char>
    {
       private readonly List<char> _myLetters = new List<char>();
        public IEnumerator<char> GetEnumerator() => _myLetters.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /*
         * Your code goes here:*
         */
    }
}
