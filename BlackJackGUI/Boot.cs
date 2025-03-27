using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doc_Deck
{
    public class Boot
    {
        //attributes 
        private String[] _bootOfCards;
        private int _numberOfDecks = 6;
       


        //Constructors nhghn
        public Boot()
        {
           //initialize deck of card class
            CardDeck.DeckOfCards deck = new CardDeck.DeckOfCards();

            //obtain 1 deck
            String[] aDeck = deck.getTheDeck();

            //display the deck
            deck.displayTheDeck(aDeck);

            _bootOfCards = createBoot(aDeck);
           
            displayTheBoot(_bootOfCards);
            Console.WriteLine("\n" + _bootOfCards.Length);

        }

        //behaviors 

        //create array for 6 decks  
        private String[] createBoot(String[] aDeck)
            //do not use i and j because it's commonly found in bad code, opt out for varaibles like n, p, q, ect. 
        {
            int deckLength = aDeck.Length;
            String[] bootOfCards = new String[deckLength * _numberOfDecks];
           //int q = card number
            int q = 0;

            for (int n = 0; n < _numberOfDecks; n++)
            {
                for (int p = 0; p < deckLength; p++)
                {
                    bootOfCards[q++] = aDeck[p];
                }
            }
            return bootOfCards;
        }

        
        private void displayTheBoot(String[] bootOfCards)
        {
            String message = "  ";

            for (int n = 0; n < _bootOfCards.Length; n++)
            {
                if (n % 13 == 0 && n > 0)
                {
                    message += "\n";
                }
                message += _bootOfCards[n] + "    ";
            }
            Console.WriteLine(message.ToString());  
        }
    }
}
