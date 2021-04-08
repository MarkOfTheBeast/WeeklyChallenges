using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return(vals.Length%2==0);
        }

        public bool IsNumberEven(int number)
        {
            return (number%2==0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num%2!=0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) return 0;
            if (numbers.Any()!=true)  return 0;
            return Enumerable.Min(numbers) + Enumerable.Max(numbers);
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {   if (numbers == null) return 0;
            else
            {
                int result = 0;
                foreach (int num in numbers)
                { result += num; }
                return result;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            else
            {
                int result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0) result += numbers[i];
                }
                return result;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            else
            {
                int result = 0;
                foreach (int num in numbers)
                { result += num; }
                return (result % 2 != 0);
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long result = 0;
            for (long i=0; i<number; i++)
            {
                if (i % 2 != 0) result ++;
            }
            return result;
        }
    }
}
