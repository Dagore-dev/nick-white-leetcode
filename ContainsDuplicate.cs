using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nick_white_leetcode;

public class ContainsDuplicate
{
    public bool ContainsDuplicateI(int[] nums)
    {
        HashSet<int> seen = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!seen.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}
