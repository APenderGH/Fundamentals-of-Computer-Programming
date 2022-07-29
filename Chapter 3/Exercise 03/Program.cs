class Program
{
    static void Main()
    {
        bool checkThirdLastDigit(int number)
        {
            string _number = number.ToString();
            if (_number.Length < 3)
            {
                return false;
            } else
            {
                return _number[_number.Length - 3] == '7';
            }
        }

        Console.WriteLine("Give me a number and I'll let you know if the third last digit is a '7':");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(checkThirdLastDigit(input) ? $"The third last digit of {input} was '7'" : $"The third last digit of {input} wasn't '7'");
    }
}