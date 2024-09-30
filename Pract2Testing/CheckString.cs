using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Pract2Testing
{
    public class CheckString
    {
        public string str;
        public string FindShortestWord(string str)
        {
            str = Regex.Replace(str, @"[^\p{L}\s]", "");

            return str.Split(' ').OrderBy(x => x.Length).ToArray<string>()[0].ToString();
        }

        public int CountWord(string str)
        {
            str = Regex.Replace(str, @"[^\p{L}\s]", "");

            return str.Split(' ').Length;
        }

        public int CountSymbols(string str)
        {
            str = Regex.Replace(str, @"[^\p{P}]", "");

            return str.Length;
        }

        public char FindSymbolByIndex(string str, int index) 
        {
            str = str.Replace(" ", "");
            return str[index-1];
        }

        public int CountNumbers(string str)
        {
            str = Regex.Replace(str, @"[^\d]", "");

            return str.Length;
        }

        public int ConsecutiveNumbers(string str)
        {
            str = Regex.Replace(str, @"[^\d\s]", "");

            for (int i = 0; i < str.Length; i++) 
            {
                if (str[i] == ' ') 
                {
                    if (i+1 <= str.Length || str[i + 1] == ' ') 
                    {
                        str.Remove(i);
                    }
                }
            }
            return str.Split(' ').OrderBy(x => x.ToString().Length).ToArray().Last().Length; 
        }

        public int CountCombination(string str, string combination) 
        {
            String[] temp = str.Split(new[] { combination }, StringSplitOptions.None);
            return temp.Length - 1;
        }
    }
}
