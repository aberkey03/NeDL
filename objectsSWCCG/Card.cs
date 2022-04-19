using System;

namespace SWCCGProgram
{
    class Card
    {
        private string Name; //card name
            //{get;set;}

        public string cardName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        private string Rarity; //card rarity
            //{get;set;}

        public string cardRarity
        {
            get
            {
                return Rarity;
            }
            set
            {
                Rarity = value;
            }
        }

        private int Id; //card id
            //{get;set;}

        public int cardId
        {
            get 
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        public Card()
        {
            Name = "unknown";
            Rarity = "unknown";
            Id = -1;
        }

        public Card(string cardName, int cardId, string cardRarity)
        {
            Name = cardName;
            Id = cardId;
            Rarity = cardRarity;
        }

        public override string ToString()
        {
            return $"Card: {Name}, Id: {Id}, Rarity: {Rarity}";
        }
    }
}