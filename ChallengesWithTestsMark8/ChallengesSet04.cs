using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0) total += num;
                else total -= num;
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = str1.Length;
            if (shortest > str2.Length) shortest = str2.Length;
            if (shortest > str3.Length) shortest = str3.Length;
            if (shortest > str4.Length) shortest = str4.Length;
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;
            if (smallest > number2) smallest = number2;
            if (smallest > number3) smallest = number3;
            if (smallest > number4) smallest = number4;
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool test1 = (sideLength1 + sideLength2 > sideLength3);
            bool test2 = (sideLength1 + sideLength3 > sideLength2);
            bool test3 = (sideLength2 + sideLength3 > sideLength1);

            return (test1 && test2 && test3);
        }

        public bool IsStringANumber(string input)
        {
            try
            {
                double x = double.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nulls = 0;
            int median = objs.Length / 2;
            foreach (object obj in objs)
            { 
                if (obj == null) nulls++;
            }
            if (nulls > median) return true;
            else return false;
        }

        public double AverageEvens(int[] numbers)
        {
            int evens = 0;
            double output = 0;
            if (numbers == null) return 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens++;
                    output += num;
                }
            }
            if (evens>0) output /= evens;
            return output;
        }

        public int Factorial(int number)
        {
            Exception e = new ArgumentOutOfRangeException();
            int output = 1;
            if (number < 0) throw e;
            for (int i = 1; i <= number; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}
