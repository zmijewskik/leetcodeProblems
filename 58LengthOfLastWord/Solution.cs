using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58LengthOfLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var lastWordLetterCounter = 0;
            for (int i = s.Length - 1; i >= 0;)
            {
                if (s[i--] != ' ') lastWordLetterCounter++;
                else if (lastWordLetterCounter > 0) return lastWordLetterCounter;
            }
            return lastWordLetterCounter;
        }
    }
}
