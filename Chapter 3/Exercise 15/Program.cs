using System.Collections;
class Program
{
    static void Main()
    {
        UInt32 number = 0x00ffffff;
        int[,] positions = new int[3, 2] { { 3, 24 }, { 4, 25 }, { 5, 26 } };
        printBits(number);

        int readNthBit(UInt32 number, int n)
        {
            return ((1 << n) & number) != 0 ? 1 : 0;
        }

        void printBits(UInt32 number)
        {
            for (int i = 0; i < 32; i++)
            {
                Console.Write(readNthBit(number, i));
            }
            Console.Write("\n");
        }

        //Exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32 - bit unsigned integer.
        for (int i = 0; i < (positions.Length/2); i++)
        {
            //for each set of numbers, store the values of the bits [0] and [1]
            //then, reset bit [0] and bit [1]
            //then, either set or don't set bits [0] and [1]
            int firstBit = readNthBit(number, positions[i, 0]);
            int secondBit = readNthBit(number, positions[i, 1]);

            number = number & (uint)~(1 << positions[i, 0]); //reset bit [0]
            number = number & (uint)~(1 << positions[i, 1]); //reset bit [1]

            if (firstBit == 1)
            {
                number = number | (uint)(1 << positions[i, 1]); //set set bit [1]
            }
            if (secondBit == 1)
            {
                number = number | (uint)(1 << positions[i, 0]); //set bit [0]
            }
        }
        printBits(number);
    }
}
