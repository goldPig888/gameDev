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
        string[] all = new string[students.Length];
        string[] pass = new string[students.Length];
        float avg = 0;

        foreach ((string name, int score) in students)
        {
            all.Append(name);
            if (score >= 3) { pass.Append(name); }
            avg += score;
        }

        return (all, pass, all.Length / students.Length, avg);
    }

    public static int Gather(char[] farm)
    {

        int left = 0, right = 0, steps = 0;
        int start = Array.IndexOf(farm, 'H');

        while (left != 0)
        {
            if (farm[left] == 'F') {
                steps += (start - left * 2);
                farm[left] = '-';
            }
            left++;

        }

        while (right != farm.Length-1)
        {
            if (farm[right] == 'F')
            {
                steps += (right * 2);
                farm[right] = '-';
            }
            right++;

        }
        return steps;


    }
}