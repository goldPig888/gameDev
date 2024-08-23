public class GD2_CH1to3
{
    public static (float, float) Totals(float[] costs)
    {
        float sum = 0;
        foreach (float i in costs)
        {
            sum += i;
        }
        return (sum, sum * 1.0825f);
    }

    public static (string[], string[], float, float) EvaluateScore((string, int)[] students)
    {
        foreach (Student s in students)
        {
            console.WriteLine(s); 
        }
    }


}