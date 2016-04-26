using System;

// x*16^y
// 
    class HexToDec
{
    static void Main()
    {
        string hexNum = Console.ReadLine();
        int power = hexNum.Length - 1;
        ulong result = 0;

        foreach (char digit in hexNum)
        {
            if (digit > 57)
            {
                result += (ulong)(digit - 'A' + 10) * (ulong)Math.Pow(16, power);
                power--;
            }
            else
            {
                result += (ulong)(digit - '0') * (ulong)Math.Pow(16, power);
                power--;
            }
        }
        Console.WriteLine(result);
    }
}
