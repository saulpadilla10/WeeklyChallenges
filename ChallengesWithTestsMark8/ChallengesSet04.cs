using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var eveNs = numbers.Where(num => num % 2 == 0);
            var odDs = numbers.Where(num => num % 2 != 0);

            int sumEvens = eveNs.Sum();
            int sumOdds = odDs.Sum();

            return sumEvens - sumOdds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = { str1, str2, str3, str4 };

            int shortestLength = strings.Min(s => s.Length);

            return shortestLength;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] nums = { number1, number2, number3, number4 };
            int smallestNum = nums.Min();

            return smallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool isValidTriangle = (sideLength1 + sideLength2 > sideLength3) &&
                         (sideLength2 + sideLength3 > sideLength1) &&
                         (sideLength1 + sideLength3 > sideLength2);

            return isValidTriangle;

        }

        public bool IsStringANumber(string input)
        {
            bool stringisNumber = double.TryParse(input, out _);
            return stringisNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int countNull = objs.Count(obj => obj == null);
            int countNonNull = objs.Count(obj => obj != null);

            return countNull > countNonNull;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = numbers.Where(nums => nums % 2 == 0);
            //double averageEven = evens.Average();

            if (evens.Count() == 0)
            {
                return 0;
            }

            return evens.Average();
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}
