    using System;
    using System.Text;


    class Program
    {
        static void Main()
        {
            ulong input = ulong.Parse(Console.ReadLine());
            string binaryNumber = string.Empty;

            while (input > 0)
            {
                ulong remainder = input % 2;
                binaryNumber = binaryNumber.Insert(0, (remainder).ToString());
                input = input / 2;
            }
            Console.WriteLine(binaryNumber);
        }
    }
