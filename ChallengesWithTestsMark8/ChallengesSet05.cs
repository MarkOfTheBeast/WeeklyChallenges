using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int num = startNumber;
            do
            {
                num++;
                if (num % n == 0) return num;
            }
            while (num % n != 0);
            return 0;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business b in businesses)
            {
                if (b.TotalRevenue == 0) b.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null||numbers.Length==0) return false;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i+1]<numbers[i]) return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Length == 0) return 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0) sum += numbers[i]; 
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string output = "";
            if (words == null || words.Length == 0) return "";
            bool emptyArray = true;
            for (int i = 0; i < words.Length; i++)
            {
                string check = words[i];
                bool checker = check.Any(x => !char.IsLetter(x));
                if (checker == false) emptyArray = false;
            }
            if (emptyArray == true) return "";
            for (int i = 0; i < words.Length; i++)
            {    
                string s = words[i];
                string c="";
                bool empty = !s.Any(x => char.IsLetter(x)||char.IsPunctuation(x));
                if (empty == false)
                {
                    foreach (char x in s)
                    { 
                        if (x != ' ') c = c + x;
                    }
                    output = $"{output} {c}";
                }
            }
            output =$"{output}.".Trim();
            return output;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var nullD = new double[0];
            if (elements == null) return nullD;
            var dlist = new List<double>();
            foreach (double d in elements)
            { if (d % 4 == 0) dlist.Add(d);}
            return dlist.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length <2) return false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber&& i != j) return true;
                }
            }
            return false;
        }
    }
}
