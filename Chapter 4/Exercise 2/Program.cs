class Program
{
    static void Main()
    {
        Console.WriteLine("Tell me the radius of your circle:");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine($"Circumference is: {2 * r * Math.PI}");
        Console.WriteLine($"Area is: {Math.PI * Math.Pow(r, 2)}");
    }
}
