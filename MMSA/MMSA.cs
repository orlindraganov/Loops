using System;
using System.Globalization;
using System.Threading;

class MMSA
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double? minNum = null;
        double? maxNum = null;
        double sumNum = 0;
        double avgNum = 0;
        int count = int.Parse(Console.ReadLine());
        for (int i = 1; i <= count; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number < minNum ^ minNum == null)
            {
                minNum = number;
            }
            if (number > maxNum ^ maxNum == null)
            {
                maxNum = number;
            }
            sumNum += number;
            avgNum = sumNum / i;
        }
        Console.WriteLine("min={0:F}", minNum);
        Console.WriteLine("max={0:F}", maxNum);
        Console.WriteLine("sum={0:F}", sumNum);
        Console.WriteLine("avg={0:F}", avgNum);
    }
}
