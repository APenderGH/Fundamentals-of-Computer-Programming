class Program
{
    static void Main()
    {
        Console.WriteLine("Let me know the length and width of the rectangle:");
        Console.WriteLine("length:");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("width:");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine($"Area: {length * width}");
        Console.WriteLine($"Perimeter: {(length + width)*2}");
    }

}
