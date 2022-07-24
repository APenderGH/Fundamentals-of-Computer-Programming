class GenderSelector
{
    static void Main()
    {
        bool isMale;
        Console.WriteLine("Hey, how's it going...\nbefore we continue, let me know your gender...");
        string userInput = Console.ReadLine();
        if (userInput.ToUpper() == "MALE")
        {
            isMale = true;
            Console.WriteLine("You're a male :|");
        } else
        {
            isMale = false;
            Console.WriteLine("You're not a male :)");
        }
    }
}