class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = " World";

        object obj = String.Concat(hello, world);
        string objString = (string)obj;
        Console.WriteLine(obj);
        Console.WriteLine(objString);
    }
}