class heart
{
    static void Main(string[] args)
    {
        //upside down equalateral triangle
        int sideLength = 0;
        bool validInput = false;

        if (args.Length > 0)
        {
            validInput = int.TryParse(args[0], out sideLength);
        }
        while (!validInput)
        {
            Console.WriteLine("Side length wasn't correctly defined as an argument. Give a valid side length:");
            validInput = int.TryParse(Console.ReadLine(), out sideLength);
        }

        //draw the top triangles of the heart
        for (int i = 0; i < sideLength/2; i++)
        {
            //first triangle
            Console.Write(new String(' ', (sideLength / 2) - i));
            Console.Write(new String('o', i*2));
            //second triangle
            Console.Write(new String(' ',  2*((sideLength/2) - i)));
            Console.WriteLine(new String('o', i*2));
        }
        //draw the base triangle of the heart
        for (int i = sideLength; i > 0; i--)
        {
            Console.Write(new String(' ', sideLength-i));
            Console.WriteLine(new String('o', i*2));
        }
    }
}