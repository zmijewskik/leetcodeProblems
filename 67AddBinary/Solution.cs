using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var resultBuilder = new StringBuilder();
            int remainder = 0;
            for (int ai = a.Length - 1, bi = b.Length - 1; (ai >= 0 || bi >= 0);)
            {
                int charA = ai < 0 ? 0 : (int)Char.GetNumericValue(a[ai--]);
                int charB = bi < 0 ? 0 : (int)Char.GetNumericValue(b[bi--]);

                int sum = charA + charB + remainder;
                remainder = 0;

                resultBuilder.Insert(0, sum % 2);
                if (sum >= 2) remainder = 1;
            }
            if (remainder == 1) resultBuilder.Insert(0, '1');
            return resultBuilder.ToString();
        }
    }
}
