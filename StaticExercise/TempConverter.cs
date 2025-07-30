namespace StaticExercise;

public static class TempConverter
{
    public static double FerToCel(double f)
    {
        var c = (f - 32) * 5 / 9;
        return c;
    }

    public static double CelToFer(double c)
    {
        var f = (c * 9 / 5) + 32;
        return f;
    }
}