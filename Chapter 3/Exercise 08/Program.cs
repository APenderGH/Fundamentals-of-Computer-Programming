class Program
{
    static void Main()
    {
        Console.WriteLine("Give me an x and y coordinate, I'll let you know if it's in my circle:");
        Console.WriteLine("x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("y:");
        double y = double.Parse(Console.ReadLine());

        if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 5)
        {
            Console.WriteLine("Your point was not within my circle.");
        } else
        {
            Console.WriteLine("Your point was within my circle.");
        }
    }
}
