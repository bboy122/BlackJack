using System;
using System.Drawing;
using System.Drawing.Drawing2D;
//Header comments

namespace BlackJack
{
    class Card
    {
        //*************************************************************
        //Fields
        //*************************************************************
        int mvalue;  //face value of the card 2-11
        string mfileName;  //file name for the card to draw it
        
        //*************************************************************
        //Constructors
        //*************************************************************
        public Card(int value, string fileName)
        {
            this.mvalue = value;
            this.mfileName = fileName;
        }

        //*************************************************************
        //Properties (accessor and mutators)
        //*************************************************************
        // property to get access to the card value

        public int CardValue
        { 
        
            get{return mvalue;}
            set{ mvalue=value;}
        }

        //property to get access to the card filename
        public string fileName
        {

            get { return mfileName; }
            set { mfileName = value; }
        
        }

        //*************************************************************
        //Methods
        //*************************************************************

        //this draws the card on the surface g at the location x and y 

        public void Show(Graphics g, int x, int y, string resourceName)
        {
            Bitmap card = (Bitmap)Resource1.ResourceManager.GetObject(resourceName);
           
            
                

            g.DrawImage(card, x, y);

        }

        

    }
}
