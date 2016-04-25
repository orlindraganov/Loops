using System;

class PrintADeck
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] suites = new string[4] { "spades, ", "clubs, ", "hearts, ", "diamonds" };
        string[] cards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        foreach (string card in cards)
        {
            foreach (string suite in suites)
            {
                Console.Write("{0} of {1}", card, suite);
            }
            Console.WriteLine();
            if (card == input)
            {
                break;
            }
        }
    }
}
