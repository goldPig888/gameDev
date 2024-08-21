public class GD1_CH3to4
{
    public static float Sale(float cost1, float cost2, float cost3)
    {
        float minCost = Math.Min(Math.Min(cost1, cost2), cost3);
        return cost1 + cost2 + cost3 - minCost + (minCost * 0.5f);
    }


    public static int NumberOfFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                count++;
                if (i != number / i)
                {
                    count++;
                }
            }
        }

        return count;
    }

}