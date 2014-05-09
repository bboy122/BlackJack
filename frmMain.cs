using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class frmMain : Form
    {
        Deck deck;
        Hand player1;
        double money = 100.00;


        public frmMain()
        {
            InitializeComponent();
        }

        private void fileNew_Click(object sender, EventArgs e)
        {
            //initialize the deck and player classes as well as graphics
            deck = new Deck();
            player1 = new Hand();
            Graphics g = this.CreateGraphics();

            //make buttons visible
            btnDeal.Visible = true;
            btnHold.Visible = true;

            //shuffle the deck
            deck.Shuffle();

            //deal two cards to the player and display it on the form
            player1.AddCard(deck.Deal());
            player1.AddCard(deck.Deal());

            player1.DrawHand(g);
            lblOutputScore.Text = player1.getScore()+ "";
            lblDollarValue.Text = 100.00 + "$";
            

            //cause form to repaint itself
         this.Invalidate();

        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //end application          

        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Add code to Deal a Card");
            //add this to class
            
            Graphics g = this.CreateGraphics();
            player1.AddCard(deck.Deal());
            player1.DrawHand(g);

            if (player1.getScore() > 21)
            {

                lblDollarValue.Text = (money - 10) + "$";

                MessageBox.Show("You Lost 10$!");

                //restart round
                player1.discardHand();
                player1.AddCard(deck.Deal());
                player1.AddCard(deck.Deal());

                player1.DrawHand(g);
                lblOutputScore.Text = player1.getScore() + "";

            }


            //update score

            lblOutputScore.Text = player1.getScore() + "";
      
      
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            int score = player1.getScore();
            Graphics g = this.CreateGraphics();
            
            //get the players score and end round

            if(score>17 && score < 21)  
            {
                lblDollarValue.Text = (money +10) + "$";

                MessageBox.Show("You Won 10$!");
            }

            if (score==21) 
            {
                lblDollarValue.Text = (money + 20) + "$";


                MessageBox.Show("You Won 20$!");
            }

            if (score <=17)
            {
            
                 lblDollarValue.Text = (money -5) + "$";


                 MessageBox.Show("You Lost 5$!");
            }

            if (score>21)
            {
            
             lblDollarValue.Text = (money -10) + "$";

             MessageBox.Show("You Lost 10$!");
           

            }

            //restart round
            player1.discardHand();
            player1.AddCard(deck.Deal());
            player1.AddCard(deck.Deal());

            player1.DrawHand(g);
            lblOutputScore.Text = player1.getScore() + "";

            //repaint the form 
            this.Invalidate();

            
        }


        //override OnPaint event
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Draw Hand
            if (player1 != null)
            {
                player1.DrawHand(e.Graphics);
            }
        }

    }
}
