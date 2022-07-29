class Program
{
    static void Main()
    {
        Console.WriteLine("Give me a number and I'll tell you if it's divisible by 5 AND 7!");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine((input % 5 == 0 && input % 7 == 0) ? $"{input} is divisible by both 5 and 7!" : $"{input} isn't divisible by both 5 and 7!");
    }
}