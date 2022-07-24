class UsingUnicode
{
    static void Main()
    {
        char letter = 'H';
        char Unicode = '\u0048';

        Console.WriteLine("{0} : H \n{1} : 0x48 -> H", letter, Unicode);
    }
}