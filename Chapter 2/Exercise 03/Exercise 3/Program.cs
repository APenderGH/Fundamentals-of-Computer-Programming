class NumberComparison
{
    static void Main()
    {
        double a = 1.21212132121;
        double b = 1.21212123112;
        bool isEqual = Math.Abs(a - b) < 0.000001;

        if (isEqual)
        {
            Console.WriteLine("{0} and {1} are EQUAL", a, b);  
        } else
        {
            Console.WriteLine("{0} and {1} are NOT EQUAL", a, b);
        }
    }
}