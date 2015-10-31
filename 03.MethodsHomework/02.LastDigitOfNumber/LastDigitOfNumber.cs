using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LastDigitOfNumber
{
    class LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastDigitAsWord(485));
            Console.WriteLine(GetLastDigitAsWord(1234));
            Console.WriteLine(GetLastDigitAsWord(398));

        }

        static string GetLastDigitAsWord(int number)
        {
            char[] digits = number.ToString().ToCharArray();

            switch (digits[digits.Length-1])
            {
                case '0':
                    return "zero";
                    break;
                case '1':
                    return "one";
                    break;
                case '2':
                    return "two";
                    break;
                case '3':
                    return "three";
                    break;
                case '4':
                    return "four";
                    break;
                case '5':
                    return "five";
                    break;
                case '6':
                    return "six";
                    break;
                case '7':
                    return "seven";
                    break;
                case '8':
                    return "eight";
                    break;
                case '9':
                    return "nine";
                    break;
                default:
                    return "NaN";
                    break;
            }
        }
    }
}
