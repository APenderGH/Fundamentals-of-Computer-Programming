class Program
{
    static void Main()
    {
        decimal total = 0;

        for (int i = 1; i <= 1000000; i++)
        {
            decimal prevTotal = total;
            total = i % 2 == 0 ? total + (1.0m / i) : total - (1.0m / i);
            if (Math.Abs(total - prevTotal) < 0.001m) 
            {
                break;
            }
        }

        Console.WriteLine(total + 2);
    }
}