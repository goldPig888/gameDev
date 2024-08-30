
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
                    for (int w = 0; w < width; w++)
                        if (grid[i + h, j + w]) { isValid = false; break; }
                if (isValid) validPlacements.Add(new Tuple<int, int>(j, i));
            }
        }

        return validPlacements;
    }
}
