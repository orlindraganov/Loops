using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        ulong power = 0;
        BigInteger result = 0;
        while (n / 10 > 0)
        {
            result += ((n % 10) * (ulong)Math.Pow(2, power));
            n = n / 10;
            power++;
        }
        result += ((n % 10) * (ulong)Math.Pow(2, power));
        Console.WriteLine(result);
    }
}
