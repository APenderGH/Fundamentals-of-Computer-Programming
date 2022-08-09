class Program
{
    static void Main()
    {
        int num1 = 123;
        double num2 = 1.1232148193281;
        double num3 = -1.23214324245321;

        Console.Write("|0x{0, -8:x}", num1);
        Console.Write("|{0, -10:f2}", num2);
        Console.Write("|{0, -10:f2}|", num3);
    }
}