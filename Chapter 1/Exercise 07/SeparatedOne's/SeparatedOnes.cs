class SeparatedOnes
{
    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("1" + new string('0', i) + "1");
        }
    }
}
