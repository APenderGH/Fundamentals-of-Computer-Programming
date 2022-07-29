class Program
{
    static void Main()
    {
        int v = 0xff;
        int p = 4;

        bool isSet = ((1 << p) & v) != 0;
        Console.WriteLine(isSet);
    }
}