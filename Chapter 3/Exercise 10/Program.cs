class Program
{
    static void Main()
    {
        /* 
        Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
            - Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).
            - Prints on the console the number in reversed order: dcba(in our example 1102).
            - Puts the last digit in the first position: dabc(in our example 1201).
            - Exchanges the second and the third digits: acbd(in our example 2101).
        */

        Console.WriteLine("Give me a four digit number, I'm gonna do some magic:");
        string input = Console.ReadLine();
        if (input.Length != 4)
        {
            return;
        }

        byte sumOfDigits(string numberString)
        {
            byte sum = 0;
            foreach (char character in input)
            {
                sum += Convert.ToByte(character.ToString());
            }
            return sum;
        }

        string reversedOrder(string numberString)
        {
            char[] reversed = numberString.ToCharArray();
            Array.Reverse(reversed);
            return new string(reversed);
        }

        string moveLastNumToStart(string numberString)
        {
            numberString = numberString[numberString.Length - 1] + numberString;
            return numberString.Remove(numberString.Length - 1);
        }

        string exchangeSecondAndThird(string numberString)
        {
            char[] charArr = numberString.ToCharArray();
            charArr[1] = (char)(charArr[1] ^ charArr[2]);
            charArr[2] = (char)(charArr[1] ^ charArr[2]);
            charArr[1] = (char)(charArr[1] ^ charArr[2]);

            numberString = new string(charArr);
            return numberString;            
        }

        Console.WriteLine($"Here's the sum of your digits -->                                       {sumOfDigits(input)}");
        Console.WriteLine($"I've also reversed the order of your number -->                         {reversedOrder(input)}");
        Console.WriteLine($"I decided to also move your last digit to the start of your number -->  {moveLastNumToStart(input)}");
        Console.WriteLine($"Oh, one last thing. I swapped the middle digits!!! -->                  {exchangeSecondAndThird(input)}");
    }
}
