using System;
using System.Globalization;
using System.Threading;
class Arrow
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int halfN = n / 2;
        Console.Write(new string('.', halfN));
        Console.Write(new string('#', n));
        Console.Write(new string('.', halfN));
        Console.WriteLine();
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', halfN));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', n - 2));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', halfN));
            Console.WriteLine();
        }
        Console.Write(new string('#', halfN + 1));
        Console.Write(new string('.', n - 2));
        Console.Write(new string('#', halfN + 1));
        Console.WriteLine();
        int spacesBefore = 1;
        int midSpaces = (n+n/2+n/2)-4;
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', midSpaces));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', spacesBefore));
            Console.WriteLine();
            spacesBefore++;
            midSpaces -= 2;
        }
        Console.Write(new string('.', spacesBefore));
        Console.Write(new string('#', 1));
        Console.WriteLine(new string('.', spacesBefore));
    }
}
