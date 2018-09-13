using System;

namespace LeetCode_171_TDD
{
    public class Solution
    {
        private const int AsciiBase = 64;

        /// <summary>
        ///Given a column title as appear in an Excel sheet,
        ///return its corresponding column number.
        ///For example:
        ///
        ///    A -> 1
        ///    B -> 2
        ///    C -> 3
        ///    ...
        ///    Z -> 26
        ///    AA -> 27
        ///    AB -> 28
        ///    ...
        ///Example 1:   Input: "A"  Output: 1
        ///Example 2:   Input: "AB" Output: 28
        ///Example 3:   Input: "ZY" Output: 701
        /// </summary>
        /// <param name="num">The Number.</param>
        /// <returns></returns>
        public int TitleToNumber(string num)
        {
            var result = 0;
            var power = num.Length - 1;

            foreach (char c in num)
            {
                var idxNum = GetEnglishCharNumber(c);
                result += CountWithPower(idxNum, power);
                power--;
            }
            return result;
        }

        private int CountWithPower(int idxNum, int power)
        {
            const int englishLetterCount = 26;
            return power == 0
                ? idxNum
                : idxNum * (int)Math.Pow(englishLetterCount, power);
        }

        private int GetEnglishCharNumber(char c) => c - AsciiBase;
    }
}