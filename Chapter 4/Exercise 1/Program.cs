class Program
{
    static void Main()
    {
        Console.WriteLine("Give me 3 numbers seperated by commas:");
        List<int> numbers = new List<int>();
        foreach (string i in Console.ReadLine().Split(','))
        {
            numbers.Add(int.Parse(i));
        }
        Console.WriteLine("The sum of those numbers is " + numbers.Sum());
    }
}