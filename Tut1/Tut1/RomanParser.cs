using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut1
{
    public static class RomanParser
    {
        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900); //EDIT: i've typed 400 instead 900
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        // Finds decimal value of a given romal numeral
        public static int ToInt(String str)
        {
            // Initialize result
            int res = 0;

            for (int i = 0; i < str.Length; i++)
            {
                // Getting value of symbol s[i]
                int s1 = value(str[i]);

                // Getting value of symbol s[i+1]
                if (i + 1 < str.Length)
                {
                    int s2 = value(str[(i + 1)]);

                    // Comparing both values
                    if (s1 >= s2)
                    {
                        // Value of current symbol is greater
                        // or equalto the next symbol
                        res = res + s1;
                    }
                    else
                    {
                        res = res + s2 - s1;
                        i++; // Value of current symbol is
                             // less than the next symbol
                    }
                }
                else
                {
                    res = res + s1;
                    i++;
                }
            }

            return res;
        }

        // This function returns value of a Roman symbol
        private static int value(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return -1;
        }
    }
}
