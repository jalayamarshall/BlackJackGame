using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    public class DeckOfCards  //here is where a single deck of 52 cards is created
    {
        //attributes 
        private int _numberOfCards = 52;
        private String[] _theDeck;

        //constructor 
        public DeckOfCards()
        {
            //call each method in turn to create a deck of cards
            //make sure the final deck is stored in _theDeck

            createDeck();
            numberTheCards();
           addPicturesAndAcesToCards();
            addSuitsToTheCards();
           
        }

        public String[] getTheDeck()
        {
            return _theDeck;
        }


        private void createDeck()
        {
            _theDeck = new String[_numberOfCards];
        }

        private void numberTheCards()
        {
            for (int n = 0; n < _theDeck.Length; n++)
            {
                _theDeck[n] = Convert.ToString(n + 1);
            }
        }

        private void addSuitsToTheCards()
        {
            for (int n = 0; n < _theDeck.Length; n++)
            {
                int numCardsInASuit = 13;
                if (n / numCardsInASuit == 0)
                {
                    _theDeck[n] += " clubs";
                }
                else if (n / numCardsInASuit == 1)
                {
                    _theDeck[n] += " diamonds";
                }
                else if (n / numCardsInASuit == 2)
                {
                    _theDeck[n] += " hearts";
                }
                else
                {
                    _theDeck[n] += " spades";
                }
            }

        }

        private void addNumberValueToEachCard()
        {
            for (int n = 0; n < _theDeck.Length; n++)
            {
                int value = n % 13 + 1;
                if (value == 1)
                {
                    _theDeck[n] = "ace ";
                }
                else if (value == 11)
                {
                    _theDeck[n] = "jack ";
                }
                else if (value == 12)
                {
                    _theDeck[n] = "queen ";
                }
                else if (value == 13)
                {
                    _theDeck[n] = "king ";
                }
                else
                {
                    _theDeck[n] = value + " ";
                }
            }
        }


        private void addPicturesAndAcesToCards()
        {
            int n = 0;
            while (n < _theDeck.Length)
            {
                switch ((n + 1) % 13)
                {
                    case 1:
                        _theDeck[n] = "ace";
                        break;
                    case 11:
                        _theDeck[n] = "jack";
                        break;
                    case 12:
                        _theDeck[n] = "queen";
                        break;
                    case 0:
                        _theDeck[n] = "king";
                        break;
                    default:
                        _theDeck[n] = ((n + 1) % 13).ToString();
                        break;
                }
                n++;
            }
        }


        public void displayTheDeck(String[] deck)
        {
            String message = "  ";

            for (int n = 0; n < _theDeck.Length; n++)
            {
                if (n % 13 == 0 && n > 0)
                {
                    message += "\n";
                }
                message += _theDeck[n] + "        ";
            }
            Console.WriteLine( message.ToString());
        }
    }
}
