class Program
{
    static void Main()
    {
        Console.WriteLine("Let me take a look at the third bit in your favourite integer 0_o");
        string input = Convert.ToString(byte.Parse(Console.ReadLine()),2);
        input = new String('0', 8 - input.Length) + input;
        Console.WriteLine(input[input.Length - 3] == '1' ? $"The third bit of {input} is a 1" : $"The third bit of {input} is a 0");
    }
}