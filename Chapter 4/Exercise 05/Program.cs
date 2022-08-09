class Program
{
    static void Main()
    {
        Console.WriteLine("Give me two integers, I'll tell you something about them:");
        Console.WriteLine("Your first integer:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Your second integer:");
        int y = int.Parse(Console.ReadLine());

        foreach (int i in (x > y) ? Enumerable.Range(y, x-y).Where(value => value % 5 == 0) : Enumerable.Range(x,y-x).Where(value => value % 5 == 0))
        {
           Console.WriteLine("{0} is a number between {1} and {2} that is evenly divisible by 5!", i, x, y);
        }
    }
}