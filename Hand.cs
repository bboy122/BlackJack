using System;
using System.Drawing;
using System.Drawing.Drawing2D;
//Header Comments

namespace BlackJack
{
    class Hand
    {
        //*************************************************************
        //Fields
        //*************************************************************
        private Card[] hand;
        private int cards;

        //*************************************************************
        //Constructor
        //*************************************************************
        public Hand()
        {
            hand = new Card[52];
            this.cards = 0;
        }

        //*************************************************************
        //Properties
        //*************************************************************



        //*************************************************************
        //Methods
        //*************************************************************
        
        //discard hand
        public void discardHand()
        {


            
            this.cards = 0;
        
        }
        
        public void AddCard(Card card)
        {
           
            //assign the card to hand
            hand[cards]= card;
            cards++;

        }

        public void DrawHand(Graphics g)
        {
            //loop through each card in the hand 
            //and calculate the x and y position
            //and call method to show card on the screen

            int x = 0;
            int y = 0;

            


            for (int i = 0; i <hand.Length; i++)
            {
                //draw cards in hand
                if (hand[i] != null)
                {
                    x = (x+80 );
                    y = 100;
                    hand[i].Show(g, x, y, (hand[i].fileName));
                }
               
                // if there are no more cards left in the hand end loop
                if (hand[i] == null)
                {

                    i = 53;
                }


            }
        }


        public int getScore()
        {
            //loop through each card and 
            //add up the value of the card

            int score = 0;

            for (int i = 0; i < hand.Length; i++)
            {
                
                if (hand[i] != null)
                {

                    score = score + hand[i].CardValue;
                }

                //if there are no more cards left then end loop
                if (hand[i] == null)
                {

                    i = 53;
                }

            }


            return score;
        }

    }
}
