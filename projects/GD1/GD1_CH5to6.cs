public class GD1_CH5to6
{
    public static long NthFibonacci(long p)
    {
        if (p <= 0) return -1;
        double a = (1 + Math.Sqrt(5)) / 2;
        double b = (1 - Math.Sqrt(5)) / 2;
        return (long)Math.Round((Math.Pow(a, p - 1) - Math.Pow(b, p - 1)) / Math.Sqrt(5));
    }

    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }

    public static int DaysInMonth(int month, int year)
    {
        return DateTime.DaysInMonth(year, month);
    }

    public static int DaysBetween(int startMonth, int startDay, int startYear, int endMonth, int endDay, int endYear)
    {
        DateTime startDate = new DateTime(startYear, startMonth, startDay);
        DateTime endDate = new DateTime(endYear, endMonth, endDay);
        return (endDate - startDate).Days;
    }
}
