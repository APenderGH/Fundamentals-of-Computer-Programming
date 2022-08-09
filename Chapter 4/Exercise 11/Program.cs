class Program
{
    static void Main()
    {
        const double GoldenRatio = 1.61803398874989484820458683436;

        for (int i = 0; i <= 100; i++)
        {
            double fibN = Math.Floor((Math.Pow(GoldenRatio, i) - Math.Pow((1 - GoldenRatio), i)) / Math.Sqrt(5));
            Console.WriteLine(fibN);
        }
    }
}