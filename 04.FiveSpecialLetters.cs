using System;
using System.Globalization;
using System.Threading;

class FiveSpecialLetters
{
    private static long WeightCalculator(string combination)
    {
        bool[] used = new bool[5];
        long letterWeight = 0;
        long weight = 0;
        long index = 1;
        foreach (var character in combination)
        {
            if (!used[character - 'a'])
            {
                letterWeight = GetLetterWeight(character);
                weight += index * letterWeight;
                used[character - 'a'] = true;
                index++;
            }
        }
        return weight;
    }

    private static int GetLetterWeight(char character)
    {
        int letterWeight=0;
        switch (character)
        {
            case 'a': letterWeight = 5; break;
            case 'b': letterWeight = -12; break;
            case 'c': letterWeight = 47; break;
            case 'd': letterWeight = 7; break;
            case 'e': letterWeight = -32; break;
        }

        return letterWeight;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long start = long.Parse(Console.ReadLine());
        long end = long.Parse(Console.ReadLine());
        int combinations = 0;
        for (char p1= 'a'; p1<='e';p1++)
        {
            for (char p2 = 'a'; p2 <= 'e'; p2++)
            {
                for (char p3 = 'a'; p3 <= 'e'; p3++)
                {
                    for (char p4 = 'a'; p4 <= 'e'; p4++)
                    {
                        for (char p5 = 'a'; p5 <= 'e'; p5++)
                        {
                            string combination = "" + p1 + p2 + p3 + p4 + p5;
                            long weight = WeightCalculator(combination);
                            if (weight >= start && weight <= end)
                            {
                                if (combinations > 0)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(combination);
                                combinations++;
                            }
                        }
                    }
                }
            }
        }
        if (combinations==0)
        {
            Console.WriteLine("No");
        }
    }
}
