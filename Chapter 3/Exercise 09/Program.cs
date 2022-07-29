class Program
{
    static void Main()
    {
        bool isInCircle(double x, double y)
        {
            return !(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 5);
        }
        bool isOutOfRect(double x, double y)
        {
            return !((x >= -1) && (x <= 5) && (y >= 1) && (y <= 5));
        }

        Console.WriteLine("Give me an x and y coordinate, I'll let you know if it's in my circle but out of my rectangle:");
        Console.WriteLine("x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("y:");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine((isInCircle(x, y) && isOutOfRect(x, y)) ? $"Your point ({x}, {y}) met my requirements!" : $"Hmm, your point ({x}, {y}) doesn't seem to fit my requirements.");    
    }
}
