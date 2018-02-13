using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut1
{
    class ANumber
    {
        public int ArabicNumeral { get; set; }
        public string RomanNumeral { get; set; }

        public ANumber(string roman)
        {
            RomanNumeral = roman;
            ArabicNumeral = RomanParser.ToInt(roman);
        }

        public ANumber(int number)
        {
            ArabicNumeral = number;
            RomanNumeral = RomanParser.ToRoman(number);
        }
    }
}
