class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = " World";

        object obj = hello.Concat(world);
        Console.WriteLine(obj);
    }
}