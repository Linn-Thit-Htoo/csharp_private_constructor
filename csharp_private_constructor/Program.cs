public class Program
{
    public static void Main(string[] args)
    {
        Utils.DoSomething();
    }
}

public class Utils
{
    private Utils() { }

    public static void DoSomething()
    {
        Console.WriteLine("Something...");
    }
}