public class GD1_CH1to2
{
    public static int TotalServings(int cupCakes, int eightInchCakes, int sheetCakes)
    {
        return cupCakes + 18*eightInchCakes + 58*sheetCakes;
    }

    public static void TimeDifference(int startTime, int endTime, out int hours, out int minutes)
    {
        int startHours = startTime / 100;
        int startMinutes = startTime % 100;
        int endHours = endTime / 100;
        int endMinutes = endTime % 100;

        hours = endHours - startHours;
        minutes = endMinutes - startMinutes;

        if (minutes < 0)
        {
            minutes += 60;
            hours -= 1;
        }

    }
}