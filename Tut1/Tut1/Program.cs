using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = new List<ANumber>();
            numList.Add(new ANumber(500));
            numList.Add(new ANumber(1993));
            numList.Add(new ANumber(1337));
            numList.Add(new ANumber("MCMLXXIII")); //1973
            numList.Add(new ANumber("MMXVIII")); //2018
            numList.Add(new ANumber("VIII")); //8

            foreach (var num in numList)
            {
                Console.WriteLine(String.Format("Arabic: {0}.  Roman: {1}.",num.ArabicNumeral,num.RomanNumeral));
            }


            var methodParameterNumber = new ANumber(RomanParser.ToRoman(8)); //VIII
            Console.WriteLine(String.Format("Arabic: {0}.  Roman: {1}.", methodParameterNumber.ArabicNumeral, methodParameterNumber.RomanNumeral));
        }
    }
}
