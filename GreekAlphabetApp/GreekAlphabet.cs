using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreekAlphabetApp
{
    class GreekAlphabet
    {
        private string[] alphabet = new string[]
        { "alpha",
          "beta",
          "gamma",
          "delta",
          "epsilon",
          "stigma",
          "zeta",
          "eta",
          "theta",
          "iota" 
        };
        private int GetIndexOfLetter(string key) 
        {
            int defaultIndex = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i]==key)
                {
                    defaultIndex = i;
                }
               
            }
            defaultIndex++;
            return defaultIndex;
        }
        private string GetLetter(int index) 
        {
            string letter = "";
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (i+1==index)
                {
                    letter = alphabet[i];

                }
            }
            return letter;
        
        
        }
        public int this[string  key]
        {
            get { return GetIndexOfLetter(key); }
           
        }
        public string this[int index]
        {
            get { return GetLetter(index); }
           
        }
    }
}
