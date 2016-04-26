using System;

class OddAndEven

{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        long oddProduct = 1;
        long evenProduct = 1;
        int counter = 1;
        string[] numbers = Console.ReadLine().Split(' ');

        foreach (string number in numbers)
        {
            if (counter % 2 == 0)
            {
                evenProduct *= int.Parse(number);
            }
            else
            {
                oddProduct *= int.Parse(number);
            }
            counter++;
        }
        Console.WriteLine(oddProduct == evenProduct ? "yes {0}" : "no {0} {1}", oddProduct, evenProduct);
    }
}
