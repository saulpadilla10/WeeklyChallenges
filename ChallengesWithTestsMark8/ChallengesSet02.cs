using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            List<char> alphaLetters = new List<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            char lowercaseChar = char.ToLower(c);
            
                if (alphaLetters.Contains(lowercaseChar))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
        public bool CharacterIsANotALetter(char nonletters)
        {
            List<char> nonalphaLetters = new List<char>
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };


            if (nonalphaLetters.Contains(nonletters))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            string[] array = vals;
            int count = array.Length;

            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }

        public bool IsNumberOdd(int num)
        {
            if(num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double plus = 0;
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() > 0)
            {
                double minValue = numbers.Min();
                double maxValue = numbers.Max();

                plus = minValue + maxValue;
            }
            else
            {
                return 0;
            }

            return plus;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            var plus = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                plus += numbers[i];
            }
            return plus;
        }

        public int SumEvens(int[] numbers)
        {
            {
                if (numbers == null)
                {
                    return 0;
                }

                var plus = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    plus += numbers[i];
                }
                return plus;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int plus = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                plus += numbers[i];
            }

            return plus % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            {
                int count = 0;

                for (int i = 1; i < number; i += 2)
                {
                    count++;
                }

                return count;
            }
        }
    }
}
