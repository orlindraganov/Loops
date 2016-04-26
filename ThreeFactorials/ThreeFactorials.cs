using System;

class ThreeFactorials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        decimal combinations = 1M;

        for (int i = 0; i < k; i++)
        {
            combinations = combinations * (n - i) / (1 + i);
        }

        Console.WriteLine("{0:F0}", combinations);

    }
}
