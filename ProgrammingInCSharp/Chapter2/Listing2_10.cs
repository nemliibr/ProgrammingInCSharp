using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_10 : IExecuter
    {
        public void Execute(string[] args)
        {
            Deck deck = new Deck();
            for (int i = 0; i < deck.Cards.Count; i++)
            {
                Console.WriteLine(deck[i].ToString());
            }
        }
    }

    class Card 
    {
        public static readonly int SPADES = 0;   // Codes for the 4 suits, plus Joker.
        public static readonly int HEARTS = 1;
        public static readonly int DIAMONDS = 2;
        public static readonly int CLUBS = 3;
        public static readonly int JOKER = 4;

        public static readonly int ACE = 1;      // Codes for the non-numeric cards.
        public static readonly int JACK = 11;    //   Cards 2 through 10 have their 
        public static readonly int QUEEN = 12;   //   numerical values for their codes.
        public static readonly int KING = 13;

        public int suit {get; set;} 
        public int value {get; set;}

        public Card() 
        {
            suit = JOKER;
            value = 1;
        }

        public Card(int theValue, int theSuit)
        {
            if (theSuit != SPADES && theSuit != HEARTS && theSuit != DIAMONDS && theSuit != CLUBS && theSuit != JOKER)
                throw new ArgumentException("Illegal playing card suit");
            if (theSuit != JOKER && (theValue < 1 || theValue > 13))
                throw new ArgumentException("Illegal playing card value");
            value = theValue;
            suit = theSuit;
        }

        public override string ToString()
        {
            if (suit == JOKER)
            {
                if (value == 1)
                    return "Joker";
                else
                    return "Joker #" + value;
            }
            else
                return getValueAsString() + " of " + getSuitAsString();
        }

        public String getSuitAsString()
        {
            if (suit == SPADES)
                return "Spades";
            else if (suit == HEARTS)
                return "Hearts";
            else if (suit == DIAMONDS)
                return "Diamonds";
            else if (suit == CLUBS)
                return "Clubs";
            else
                return "Joker";
        }

        public String getValueAsString()
        {
            if (suit == JOKER)
                return "" + value;
            else
            {
                switch (value)
                {
                    case 1: return "Ace";
                    case 2: return "2";
                    case 3: return "3";
                    case 4: return "4";
                    case 5: return "5";
                    case 6: return "6";
                    case 7: return "7";
                    case 8: return "8";
                    case 9: return "9";
                    case 10: return "10";
                    case 11: return "Jack";
                    case 12: return "Queen";
                    default: return "King";
                }
            }
        }
    }

    class Deck
    {
        public ICollection<Card> Cards { get; private set; }

        public Deck()
        {
            Cards = new List<Card>();
            Cards.Add(new Card()); //joker
            Cards.Add(new Card()); //joker

            Cards.Add(new Card(Card.ACE, Card.SPADES));
            Cards.Add(new Card(2, Card.SPADES));
            Cards.Add(new Card(3, Card.SPADES));
            Cards.Add(new Card(4, Card.SPADES));
            Cards.Add(new Card(5, Card.SPADES));
            Cards.Add(new Card(6, Card.SPADES));
            Cards.Add(new Card(7, Card.SPADES));
            Cards.Add(new Card(8, Card.SPADES));
            Cards.Add(new Card(9, Card.SPADES));
            Cards.Add(new Card(10, Card.SPADES));
            Cards.Add(new Card(Card.JACK, Card.SPADES));
            Cards.Add(new Card(Card.QUEEN, Card.SPADES));
            Cards.Add(new Card(Card.KING, Card.SPADES));

            Cards.Add(new Card(Card.ACE, Card.HEARTS));
            Cards.Add(new Card(2, Card.HEARTS));
            Cards.Add(new Card(3, Card.HEARTS));
            Cards.Add(new Card(4, Card.HEARTS));
            Cards.Add(new Card(5, Card.HEARTS));
            Cards.Add(new Card(6, Card.HEARTS));
            Cards.Add(new Card(7, Card.HEARTS));
            Cards.Add(new Card(8, Card.HEARTS));
            Cards.Add(new Card(9, Card.HEARTS));
            Cards.Add(new Card(10, Card.HEARTS));
            Cards.Add(new Card(Card.JACK, Card.HEARTS));
            Cards.Add(new Card(Card.QUEEN, Card.HEARTS));
            Cards.Add(new Card(Card.KING, Card.HEARTS));

            Cards.Add(new Card(Card.ACE, Card.DIAMONDS));
            Cards.Add(new Card(2, Card.DIAMONDS));
            Cards.Add(new Card(3, Card.DIAMONDS));
            Cards.Add(new Card(4, Card.DIAMONDS));
            Cards.Add(new Card(5, Card.DIAMONDS));
            Cards.Add(new Card(6, Card.DIAMONDS));
            Cards.Add(new Card(7, Card.DIAMONDS));
            Cards.Add(new Card(8, Card.DIAMONDS));
            Cards.Add(new Card(9, Card.DIAMONDS));
            Cards.Add(new Card(10, Card.DIAMONDS));
            Cards.Add(new Card(Card.JACK, Card.DIAMONDS));
            Cards.Add(new Card(Card.QUEEN, Card.DIAMONDS));
            Cards.Add(new Card(Card.KING, Card.DIAMONDS));

            Cards.Add(new Card(Card.ACE, Card.CLUBS));
            Cards.Add(new Card(2, Card.CLUBS));
            Cards.Add(new Card(3, Card.CLUBS));
            Cards.Add(new Card(4, Card.CLUBS));
            Cards.Add(new Card(5, Card.CLUBS));
            Cards.Add(new Card(6, Card.CLUBS));
            Cards.Add(new Card(7, Card.CLUBS));
            Cards.Add(new Card(8, Card.CLUBS));
            Cards.Add(new Card(9, Card.CLUBS));
            Cards.Add(new Card(10, Card.CLUBS));
            Cards.Add(new Card(Card.JACK, Card.CLUBS));
            Cards.Add(new Card(Card.QUEEN, Card.CLUBS));
            Cards.Add(new Card(Card.KING, Card.CLUBS));
        }

        public Card this[int index]
        {
            get { return Cards.ElementAt(index); }
        }
        
    }
}
