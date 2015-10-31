using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace _05.ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double reversed = GetReversedNumber(123.45);

            Console.WriteLine(reversed);
        }

        static double GetReversedNumber(double testNumber)
        {
            string testNumberStr = testNumber.ToString();

            char[] testNumberArr = testNumberStr.ToCharArray();

            char[] testNumberReversed = new char[testNumberArr.Length];

            for (int i = 0; i < testNumberReversed.Length; i++)
            {
                testNumberReversed[i] = testNumberArr[testNumberArr.Length - 1 - i];
            }

            string resultStr = new string(testNumberReversed);
            double resultDbl = double.Parse(resultStr);

            return resultDbl;
        }
    }
}