public class GD1_CH3to4
{
    public static float Sale(ref float cost1, ref float cost2, ref float cost3)
    {
        float minCost = Math.Min(Math.Min(cost1, cost2), cost3);
        if (cost1 == minCost)
        {
            cost1 /= 2;
        }
        else if (cost2 == minCost)
        {
            cost2 /= 2;
        }
        else if (cost3 == minCost)
        {
            cost3 /= 2;
        }
        return cost1 + cost2 + cost3;
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