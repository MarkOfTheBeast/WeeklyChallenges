using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool trigger = false;
            foreach (bool b in vals)
            { if (b == false) trigger = true; }
            return trigger;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers != null)
            {
                var odds = numbers.Where(x => x % 2 != 0);
                var oddSum = odds.Sum();
                return (oddSum % 2 != 0) ? true : false;
            }
            else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit)) return true;
            else return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (DivideByZeroException ex)
            {
                return 0;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < 100; i++)
            { if (i % 2 != 0) nums.Add(i); }
            return nums.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
