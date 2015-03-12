using System;
using System.Globalization;
using System.Threading;

class OddEvenElements
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        string[] userInput = input.Split(' ');
        if (input == "")
        {
            userInput = new string[0];
        }
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        int index = 1;
        foreach (string number in userInput)
        {
            decimal value = decimal.Parse(number);
            if (index % 2 == 1)
            {
                oddSum += value;
                oddMin = Math.Min(value, oddMin);
                oddMax = Math.Max(value, oddMax);
            }
            else
            {
                evenSum += value;
                evenMin = Math.Min(value, evenMin);
                evenMax = Math.Max(value, evenMax);
            }
            index++;
        }
        if (userInput.Length==0)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", "No", "No", "No", "No", "No", "No");
        }
        else if (userInput.Length==1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, "No", "No", "No");
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
    }
}
