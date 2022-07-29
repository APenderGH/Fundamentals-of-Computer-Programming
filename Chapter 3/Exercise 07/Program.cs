class Program
{
    static void Main()
    {
        Console.WriteLine("How much do you weigh on earth? (in Newtons)");
        Console.WriteLine($"Cool! You'd weigh about {0.17 * double.Parse(Console.ReadLine())} on the Moon!");
    }
}