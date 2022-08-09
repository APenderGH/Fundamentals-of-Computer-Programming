class Program
{
    static void Main()
    {
        Console.WriteLine("Give me two numbers, I'll tell you which one is biggest");
        Console.WriteLine("First number");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Second number");
        double y = double.Parse(Console.ReadLine());
        string response = (x > y) ? $"{x} is greater!" : $"{y} is greater!";

        Console.WriteLine(response);
    }
}
