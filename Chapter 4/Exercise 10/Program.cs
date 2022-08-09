class Program
{
    static void Main()
    {
        Console.WriteLine("Watch how fast I can count! Give me number!!!");
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i <= input; i++)
        {
            Console.WriteLine($"{i}!!");
        }
    }
}