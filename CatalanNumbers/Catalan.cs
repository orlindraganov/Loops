/*
 * 
 *(2n)! / ((n+1)! * n!
 * 
 * 
 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger combinations = 1;

        for (int i = 0; i < n; i++)
        {
            combinations = combinations * (2 * n - i) / (1 + i);
        }

        Console.WriteLine("{0:F0}", combinations / (n + 1));

    }
}
