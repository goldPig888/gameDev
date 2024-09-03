public class GD2_CH7to9
{
    public static List<Tuple<int, int>> BuildingPlacement(int width, int height, bool[,] grid)
    {
        var validPlacements = new List<Tuple<int, int>>();
        int rows = grid.GetLength(0), cols = grid.GetLength(1);

        for (int i = 0; i <= rows - height; i++)
        {
            for (int j = 0; j <= cols - width; j++)
            {
                bool isValid = true;
                for (int h = 0; h < height && isValid; h++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        if (grid[i + h, j + w])
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    validPlacements.Add(new Tuple<int, int>(j, i));
                }
            }
        }

        return validPlacements;
    }

    public static int[] RingTotals(int[,] grid)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int ringsCount = Math.Min(rows, cols) / 2 + Math.Min(rows, cols) % 2;

        int[] ringSums = new int[ringsCount];

        for (int ring = 0; ring < ringsCount; ring++)
        {
            ringSums[ring] = SumLayer(grid, ring, rows, cols);
        }

        return ringSums;
    }

    private static int SumLayer(int[,] grid, int ring, int rows, int cols)
    {
        int sum = 0;
        int top = ring;
        int bottom = rows - ring - 1;
        int left = ring;
        int right = cols - ring - 1;

        for (int i = left; i <= right; i++) sum += grid[top, i];
        for (int i = top + 1; i <= bottom; i++) sum += grid[i, right];
        if (bottom > top)
        {
            for (int i = right - 1; i >= left; i--) sum += grid[bottom, i];
        }
        if (right > left)
        {
            for (int i = bottom - 1; i > top; i--) sum += grid[i, left];
        }

        return sum;
    }

    public static Tuple<string, int, int> FindWord(string word, char[,] grid)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        int[] rowDirection = { 0, 1, 1, -1 };
        int[] colDirection = { 1, 1, 0, 1 };

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                for (int d = 0; d < 4; d++)
                {
                    if (CheckWord(word, grid, row, col, rowDirection[d], colDirection[d]))
                    {
                        return new Tuple<string, int, int>(word, col, row);
                    }
                }
            }
        }
        return null;
    }

    private static bool CheckWord(string word, char[,] grid, int startRow, int startCol, int rowDir, int colDir)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        for (int i = 0; i < word.Length; i++)
        {
            int nRow = startRow + i * rowDir;
            int nCol = startCol + i * colDir;
            if (nRow < 0 || nRow >= rows || nCol < 0 || nCol >= cols || grid[nRow, nCol] != word[i])
            {
                return false;
            }
        }
        return true;
    }
}
