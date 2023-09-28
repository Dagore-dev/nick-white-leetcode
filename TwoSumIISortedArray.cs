using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nick_white_leetcode;

public class TwoSumIISortedArray
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int a = 0;
        int b = numbers.Length - 1;
        int intent;

        while (a <= b)
        {
            intent = numbers[a] + numbers[b];
            if (intent == target)
            {
                return new int[] { a + 1, b + 1 };
            }

            if (intent > target)
            {
                b--;
            }
            else
            {
                a++;
            }
        }

        return new int[] { a + 1, b + 1 };
    }
}
