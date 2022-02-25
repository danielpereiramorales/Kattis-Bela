//Team Charlie
//T4 Kattis Bela Problem

using System;

namespace T4_Kattis_Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construct variables
            int sum = 0;

            //Console.Write("Please enter number of hands and the dominate suit: ");    ----COMMENTED OUT FOR KATTIS VERIFICATION----
            string handsInput = Console.ReadLine();
            
            //Identifies location of space in string for indexing
            int space = handsInput.IndexOf(' ');

            //Find number of hands by parsing input string and multiply by 4
            int hands = int.Parse(handsInput.Substring(0, space)) * 4;

            //Identifies suit as character that follows space in user input
            char suit = handsInput[space + 1];

            //Console.Write("Please enter the cards in the game in the format of number and suit: ");   ----COMMENTED OUT FOR KATTIS VERIFICATION----

            //Loop for number of hands
            for (int i = 0; i < hands; i++)
            {
                string cardValues = Console.ReadLine();

                //Isolate card number from suit
                char cardNum = cardValues[0];

                //Check card value/suit and add to sum accordingly
                if (cardNum == 'A')
                {
                    sum += 11;
                }

                else if (cardNum == 'K')
                {
                    sum += 4;
                }

                else if (cardNum == 'Q')
                {
                    sum += 3;
                }

                else if (cardNum == 'J')
                {
                    if (cardValues[1] == suit)
                    {
                        sum += 20;
                    }
                    else
                    {
                        sum += 2;
                    }
                }

                else if (cardNum == 'T')
                {
                    sum += 10;
                }

                else if (cardNum == '9')
                {
                    if (cardValues[1] == suit)
                    {
                        sum += 14;
                    }

                    else
                    {
                        sum += 0;
                    }
                }

                else if (cardNum == '8')
                {
                    sum += 0;
                }

                else if (cardNum == '7')
                {
                    sum += 0;
                }
            }

            //Print sum aka points
            Console.WriteLine(sum);
        }
    }
}
