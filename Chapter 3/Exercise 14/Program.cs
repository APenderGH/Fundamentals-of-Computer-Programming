class Program
{
    static void Main()
    {
        Console.WriteLine("Give me a number between 1 and 100, I'll let you know if it's prime or not:");
        int input = int.Parse(Console.ReadLine());
        
        bool isPrime(int number)
        {
            for (int i = 1; i < 101; i++)
            {
                if ((i != input) && (i != 1))
                {
                    if ((input % i) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        Console.WriteLine(isPrime(input) ? "Your number is prime" : "Your number is not a prime number");
    }
}