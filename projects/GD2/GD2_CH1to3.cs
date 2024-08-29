public class GD2_CH1to3
{
    public static (float, float) Totals(float[] costs)
    {
        float sum = 0;
        foreach (float cost in costs)
        {
            sum += cost;
        }
        return (sum, sum * 1.0825f);
    }


    public static (string[], string[], float, float) EvaluateScores((string, int)[] students)
    {
        List<string> all = new List<string>();
        List<string> pass = new List<string>();
        float avg = 0;

        foreach ((string name, int score) in students)
        {
            all.Add(name);
            if (score >= 3) { pass.Add(name); }
            avg += score;
        }

        return (all.ToArray(), pass.ToArray(), (float)pass.Count / all.Count, avg / all.Count);
    }


    public static int Gather(char[] farm)
    {
        int homePosition = Array.IndexOf(farm, 'H');
        List<int> foodPositions = new List<int>();
        int steps = 0;

        for (int i = 0; i < farm.Length; i++)
        {
            if (farm[i] == 'F')
            {
                foodPositions.Add(i);
            }
        }

        if (foodPositions.Count == 0)
        {
            if (farm.Length == 1)
            {
                return 0;
            }
            else
            {
                steps += Math.Abs(homePosition - 0) * 2;
                steps += Math.Abs(farm.Length - 1 - homePosition);
                return steps;
            }
        }

        foreach (int foodPosition in foodPositions)
        {
            int distance = Math.Abs(foodPosition - homePosition);
            steps += distance * 2;
        }

        if (foodPositions[foodPositions.Count - 1] != farm.Length - 1)
        {
            steps += (farm.Length - 1 - homePosition) * 2;
        }

        if (foodPositions[0] != 0)
        {
            steps += (homePosition) * 2;
        }

        return steps;
    }

}
