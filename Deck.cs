using System;
using System.Drawing;
using System.Drawing.Drawing2D;
//Header Comments

//code to shuffle
//loop through every card(3-4 times), and every time you loop get a random number between 0 and 51.
//then switch that card with the first one

namespace BlackJack
{
    class Deck
    {
        //*************************************************************
        //Fields
        //*************************************************************
        private Card[] deck;
        private Card[] copyDeck;
        private int nextCard;

        //*************************************************************
        //Constructors
        //*************************************************************
        public Deck()
        {
            //create all 52 cards and assign them to the deck variable
            deck = new Card[52];
            nextCard = 0;

            //create the 52 cards and assign to deck
            //assign all aces
            deck[0] = new Card(11, "Card1");
            deck[13] = new Card(11, "Card14");
            deck[26] = new Card(11, "Card27");
            deck[39] = new Card(11, "Card40");

            //do the rest - use a loop to simplify

            int counter = 1;
            for (int i = 1; i < 13; i++)
            {
                counter++;
                deck[i] = new Card(counter, ("Card" + (i+1)));
                if (counter > 10)
                {
                    deck[i] = new Card(10, ("Card" + (i+1)));
                }
            }

            counter = 1;

            for (int i = 14; i < 26; i++)
            {
                counter++;

                deck[i] = new Card(counter, ("Card" + (i+1)));

                if (counter > 10)
                {
                    deck[i] = new Card(10, ("Card" + (i + 1)));
                }
            }
          
            counter = 1;

            for (int i = 27; i < 39; i++)
            {
                counter++;
                deck[i] = new Card(counter , ("Card" + (i+1)));
               
                if (counter > 10)
                {
                    deck[i] = new Card(10, ("Card" + (i + 1)));
                }

            }
            
            counter = 1;

            for (int i = 40; i < 52; i++)
            {
                counter++;
                deck[i] = new Card(counter , ("Card" + (i+1)));
                
                if (counter > 10)
                {
                    deck[i] = new Card(10, ("Card" + (i + 1)));
                }

            }

            //create a copy of the deck
           copyDeck = new Card[52];

            for (int a = 0; a < 52; a++)
            {

                copyDeck[a] = deck[a];
            
            }


        }


        //*************************************************************
        //Properties
        //*************************************************************



        //*************************************************************
        //Methods
        //*************************************************************
        public void Shuffle()
        {
            //This shuffles the deck
            //use Random class to generate the shuffling
            Random rand = new Random();


            int num = rand.Next(0, 51);
          
          

            //shuffle three times using loops
            for (int a = 0; a < 3; a++)
            {
                for (int i = 0; i < 52; i++)
                {
                    

                    deck[i] = deck[num];
                    deck[num]= copyDeck[i];
                    num = rand.Next(0, 51);

                }
            }
        }

        public Card Deal()
        {
            Card card = deck[nextCard];
            nextCard++;

            return card;

        }



    }
}
