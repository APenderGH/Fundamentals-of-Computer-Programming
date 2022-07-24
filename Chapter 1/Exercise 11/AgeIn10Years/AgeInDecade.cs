class AgeInDecade
{
    static void Main()
    {
        int age;
        Console.Write("What is your age?: ");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("You'll be {0} in 10 years!", (age + 10).ToString());
    }
}
