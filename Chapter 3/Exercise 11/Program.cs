class Program
{
    static void Main()
    {
        int n = 32; //00100000
        int p = 4;  
        int i = 1;  //00000001
        int mask = i << p;

        Console.WriteLine((i & n) != 0 ? $"The {p}'th bit of {n} is 1" : $"The {p}'th bit of {n} is 0");
    }
}
