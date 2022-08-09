class Program
{
    static void Main()
    {
        double biggestNum = double.MinValue;
        for (int i = 0; i < 5; i++)
        {
            double number;

            Console.WriteLine("Give me an number:");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out number)) break;
                else Console.WriteLine("Bro, give me an INTEGER!");
            }

            if (number > biggestNum) biggestNum = number;

        }

        Console.WriteLine($"The biggest number you gave me was {biggestNum}");
    }
}
