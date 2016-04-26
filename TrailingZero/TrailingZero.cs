using System;


class TrailingZero
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int zeros = 0;
        int divisor = 5;

        while (number / divisor >= 1)
        {
            zeros += (number / divisor);
            divisor *= 5;
        }
        Console.WriteLine(zeros);
    }
}
