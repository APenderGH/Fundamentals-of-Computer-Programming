class SwapValues
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        Console.WriteLine($"a = {a}, b = {b}");

        a = a ^ b;
        b = b ^ a;
        a = a ^ b;

        Console.WriteLine($"a = {a}, b = {b}");

        // XOR swapping algorithm :
        // X:= X XOR Y; // XOR the values and store the result in X
        // Y:= Y XOR X; // XOR the values and store the result in Y
        // X:= X XOR Y; // XOR the values and store the result in X
    }
}
