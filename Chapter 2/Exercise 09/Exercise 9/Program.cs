class quotations
{
    static void Main()
    {
        string notquoted = "The \"use\" of quotations causes difficulties.";
        string quoted = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("This string is not quoted : {0}\nThis string is quoted : {1}", notquoted, quoted);
    }
}