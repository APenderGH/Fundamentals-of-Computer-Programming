class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number and I'll tell you if it's even or odd:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(input % 2 == 0 ? "Even!" : "Odd!");
    }
}