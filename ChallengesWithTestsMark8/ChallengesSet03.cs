using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else if (vals.Contains(true))
                {
                    return false;
                }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sumOfOdds = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sumOfOdds += number;
                }
            }

            return sumOfOdds % 2 != 0;
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (var letter in password)
            {
                if (char.IsUpper(letter))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(letter))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(letter))
                {
                    hasNumber = true;
                }

                if (hasUpper && hasLower && hasNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstChar = val[0];
            return firstChar;
        }

        public char GetLastLetterOfString(string val)
        {
            int finalChar = val.Length - 1;
            char lastCharacter = val[finalChar];
            return lastCharacter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
            {
                decimal result = dividend / divisor;
                return result;
            }
            else
            {
                return 0;
            }
        }


        public int LastMinusFirst(int[] nums)
        {
            if (nums.Length > 0)
            {
                int first = nums[0];
                int last = nums[nums.Length - 1];

                int minus = last - first;

                return minus;
            }
            else
            {
                return 0;
            }
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
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
