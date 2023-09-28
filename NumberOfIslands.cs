namespace nick_white_leetcode;

public class NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        int count = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    count++;
                    CleanIsland(i, j, grid);
                }
            }
        }

        return count;
    }

    private static void CleanIsland(int i, int j, char[][] grid)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == '0')
        {
            return;
        }

        grid[i][j] = '0';
        CleanIsland(i + 1, j, grid);
        CleanIsland(i, j + 1, grid);
        CleanIsland(i - 1, j, grid);
        CleanIsland(i, j - 1, grid);
    }
}
