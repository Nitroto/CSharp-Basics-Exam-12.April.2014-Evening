using System;
using System.Globalization;
using System.Threading;

class BitRoller
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            int result = 0;
            for (int bit = 0; bit < 19; bit++)
            {
                int currentBit = (n >> bit) & 1;
                if (bit == f)
                {
                    result |= (currentBit << bit);
                }
                else
                {
                    int newBit = GetNewPosition(bit);
                    if (newBit == f)
                    {
                        newBit = GetNewPosition(newBit);
                    }
                    result |= (currentBit << newBit);
                }
            }
            n = result;
        }
        Console.WriteLine(n);
    }
    static int GetNewPosition(int oldBit)
    {
        int newBit = oldBit - 1;
        if (newBit <0)
        {
            newBit = 19-1;
        }
        return newBit;
    }
}
