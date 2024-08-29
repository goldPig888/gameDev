public class GD2_CH4to6
{
    public static void RemovePrimes(List<int> numbers)
    {
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            if (IsPrime(numbers[i]))
            {
                numbers.RemoveAt(i);
            }
        }
    }
    public static bool IsPrime(int n) {
        if (n < 2) { return false; }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) { return false; }
        }
        return true;
    }

    
    public static List<long> FibonacciList(int wanted, out List<long> fib)
    {
        fib = new List<long>() {0};
        if (wanted == 1) { return fib; }
        fib.Add(1);
        
        for (int i = 2; i < wanted; i++)
        {
            fib.Add(fib[i - 1] + fib[i - 2]);
        }
        return fib;
    }
    
    public static List<string> MedianScores((List<(string,int)>) scores)
    {
   


    }



}