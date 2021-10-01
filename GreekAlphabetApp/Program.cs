using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreekAlphabetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GreekAlphabet alphabet = new GreekAlphabet();
            int numberOfLetter = alphabet["delta"];
            Console.WriteLine(numberOfLetter);
            string letter = alphabet[3];
            Console.WriteLine(letter);
        }
    }
}
