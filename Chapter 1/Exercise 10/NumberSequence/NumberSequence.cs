class NumberSequence
{
    static void Main()
    {
        for (int i = 0; i < 101; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}