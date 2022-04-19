using System;

namespace SWCCGProgram
{
  class Program
  {
    static void Main(string[] args)
    {
        int arrLength = 5;
        Card[] cardArray = new Card[arrLength];
        
        for (int i = 0; i < cardArray.Length; i++)
        {
            cardArray[i] = new Card();
        }
        
        Card AdmiralMotti = new Card("Admiral Motti", 2, "R2");
        //Console.WriteLine(AdmiralMotti);

        cardArray[2] = AdmiralMotti;
        
        for (int i = 0; i < cardArray.Length; i++)
        {
            Console.WriteLine(cardArray[i]);
        }

        Console.WriteLine("Enter the card name.");
        string cardName = Console.ReadLine();
        cardArray[2].cardName = cardName;
        Console.WriteLine(cardArray[2]);

        //search
        Console.WriteLine("Enter the name of the card you are looking for.");
        string nameSearch = Console.ReadLine();
        int resultIndex = -1;

        for (int i = 0; i < arrLength; i++)
        {
            if (cardArray[i].cardName == nameSearch)
            {
                resultIndex = i;
                break;
            }
            else
            {
                resultIndex = -1;
            }
        }
        if (resultIndex == -1)
        {
            Console.WriteLine("card not found");
        }
        else
        {
            Console.WriteLine("Do you want to \"Update\" -or- \"Delete\" ?");
            string userResponse1 = Console.ReadLine();
            if (userResponse1=="Update")
            {
                Console.WriteLine("Which field do you want to update? \"Name\", \"Id\", \"Rarity\", or \"ALL\"");
                string userResponse2 = Console.ReadLine();
                switch (userResponse2)
                {
                    case "Name":
                        Console.WriteLine("Enter the new name.");
                        string newName = Console.ReadLine();
                        cardArray[resultIndex].cardName = newName;
                        break;
                    case "Id":
                        Console.WriteLine("Enter the new Id.");
                        int newId = Convert.ToInt16(Console.ReadLine());
                        cardArray[resultIndex].cardId = newId;
                        break;
                    case "Rarity":
                        Console.WriteLine("Enter the new Id.");
                        string newRarity = Console.ReadLine();
                        cardArray[resultIndex].cardRarity = newRarity;
                        break;
                    case "ALL":
                        Console.WriteLine("Enter the new name.");
                        newName = Console.ReadLine();
                        Console.WriteLine("Enter the new Id.");
                        newId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the new rarity.");
                        newRarity = Console.ReadLine();
                        cardArray[resultIndex] = new Card(newName,newId,newRarity);
                        break;
                    default:
                        Console.WriteLine("No valid option was selected.");
                        break;
                }
            }
            else if (userResponse1=="Delete")
            {
                cardArray[resultIndex] = new Card();
            }
        }
        Console.WriteLine(cardArray[resultIndex]);
    }
  }
}