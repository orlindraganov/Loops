using System;
using System.Text;


class DecToHex
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        string hexNumber = string.Empty;
        ulong remainder = 0;

        while (input > 0)
        {
            remainder = input % 16;
            if (remainder < 10)
            {
                hexNumber = hexNumber.Insert(0, remainder.ToString());
            }
            else if (remainder == 10)
            {
                hexNumber = hexNumber.Insert(0, "A");
            }
            else if (remainder == 11)
            {
                hexNumber = hexNumber.Insert(0, "B");
            }
            else if (remainder == 12)
            {
                hexNumber = hexNumber.Insert(0, "C");
            }
            else if (remainder == 13)
            {
                hexNumber = hexNumber.Insert(0, "D");
            }
            else if (remainder == 14)
            {
                hexNumber = hexNumber.Insert(0, "E");
            }
            else if (remainder == 15)
            {
                hexNumber = hexNumber.Insert(0, "F");
            }
            input = input / 16;
        }
        Console.WriteLine(hexNumber);
    }
}
