using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var check = Array.Exists(vals, x => x == false);

            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            int sum = 0;

            foreach (var item in numbers)
            {
                if (item % 2 == 1 || item % 2 == -1 || item == 1 || item == -1)
                {
                    sum += item;
                }

            }

            if (sum % 2 == 1 || sum % 2 == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
           

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }

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
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var first = nums.First();
            var last = nums.Last();

            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
            return odds;
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
