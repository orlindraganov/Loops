using System;


class GCD
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int greaterNumber = int.Parse(input[0]);
        int lesserNumber = int.Parse(input[1]);
        int remainder = greaterNumber % lesserNumber;

        if (greaterNumber < lesserNumber)
        {
            greaterNumber = greaterNumber ^ lesserNumber;
            lesserNumber = greaterNumber ^ lesserNumber;
            greaterNumber = greaterNumber ^ lesserNumber;
        }
        while (remainder > 0)
        {
            remainder = greaterNumber % lesserNumber;
            greaterNumber = lesserNumber;
            lesserNumber = remainder;
        }
        Console.WriteLine(greaterNumber);
    }
}
