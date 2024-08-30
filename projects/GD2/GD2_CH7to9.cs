public class GD2_CH7to9
{
    public static int[] RingTotals(int[,] grid)
    {

        for (int row = grid.GetLength(0); row >= 0; row--)
        {
            for (int col = grid.GetLength(1); col >= 0; col--)
            {
                Console.Write(grid[row, col] + " ring : " + col);
            }
                
            
        }

    }
}
