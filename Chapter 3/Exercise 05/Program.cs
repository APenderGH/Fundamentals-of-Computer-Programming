class Program
{
    static void Main()
    {
        Console.WriteLine("Give me sides a,b and the height of a trapezoid and we'll calculate it's area for you.");
        Console.WriteLine("Side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Height:");
        double height = double.Parse(Console.ReadLine());

        double area = 0.5 * height * (a + b);
        Console.WriteLine($"Area: {area}");
    }
}
