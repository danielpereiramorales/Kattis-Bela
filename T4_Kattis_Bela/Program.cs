using System;

namespace T4_Kattis_Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of hands in the game: ");
            string handsInput = Console.ReadLine();
            int hands = int.Parse(handsInput);

            Console.Write("Please enter the dominant suit (S,H,D,C) in the game: ");
            string domSuitInput = Console.ReadLine();

            Console.Write("Please enter the cards in the game in the format of number and suit: ");
            string cardValues = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < hands * 4; i++)
            {
                if (cardValues == "A")
                    sum += 11;

                else if (cardValues == "K")
                    sum += 4;

                else if (cardValues == "Q")
                    sum += 3;

                else if (cardValues == "T")
                    sum += 10;

                else if (cardValues == "8")
                    sum += 0;

                else if (cardValues == "7")
                    sum += 0;
            }
        }
    }
}
