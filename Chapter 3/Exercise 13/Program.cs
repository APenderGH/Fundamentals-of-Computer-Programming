class Program
{
    static void Main()
    {
        int n = 35;
        int v = 0;
        int p = 5;
        //Set the p'th bit of n to v

        n = n & (~(1 << p)); //unsets the p'th bit
        if (v == 1)
        {
            n = n | (1 << p); //sets the p'th bit to 1
        }
        
        Console.WriteLine(n);
    }
}
