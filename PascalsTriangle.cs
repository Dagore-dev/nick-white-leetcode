using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nick_white_leetcode;

public class PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int> { 1 });

        IList<int> previous;
        List<int> current;

        for (int i = 1; i < numRows; i++)
        {
            previous = result[i - 1];
            current = new List<int> { 1 };

            for (int j = 1; j < i; j++)
            {
                current.Add(previous[j - 1] + previous[j]);
            }

            current.Add(1);
            result.Add(current);
        }

        return result;
    }
}
