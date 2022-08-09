class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            int number;

            Console.WriteLine("Give me an integer:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number)) break;
                else Console.WriteLine("Bro, give me an INTEGER!");
            }

            numbers.Add(number);
        }

        Console.WriteLine($"The sum of your integers was {numbers.Sum()}");
    }
}