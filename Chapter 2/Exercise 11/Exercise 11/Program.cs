class isoscelesTriangle
{
    static void Main(string[] args)
    {
        int sideLength = 0;
        bool validInput = false;

        if (args.Length == 1)
        {
            validInput = int.TryParse(args[0], out sideLength);
        }
        while (!validInput)
        {
            Console.WriteLine("The side length wasn't correctly defined as an argument. \nGive a valid side length:");
            validInput = int.TryParse(Console.ReadLine(), out sideLength);
        }

        for (int i = 0; i < sideLength; i++)
        {
            Console.Write(new String(' ', sideLength - i));
            Console.WriteLine(new String('\u00A9', i * 2));
        }
    }
}
