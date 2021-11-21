using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace Laboratory_Work2._3_WPF
{

    enum suit
    {
        KRESTI,
        BUBNI,
        CHERVI,
        PIKI
    }

    enum rank
    {
        ACE = 0,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING,
        JOKERBLACK,
        JOKERRED
        
    }




    class Card
    {
        private Image backImage;
        private Image frotImage;

        private string backPath = @"D:\STUDY\POLYTECH\4 course POLYTECH\ISRPO\WPF Laboratory Work\Laboratory_Work2_WPF(пример)\lab2.3\cards\55.jpg";

        private string frontPath;

        private  int indexCard;
        private string nameCard;


        public Image GetImage(bool img)
        {
            //suit suit;
            //suit.
            //for (int i = 0; i < ; i++)
            //{

            //}
            //int numberCard = (int)suit * 13 + (int)rank + 1;
            //if (numberCard >= 55)
            //{
            //    numberCard = 55;
            //}
            //frontPath = @"D:\STUDY\POLYTECH\4 course POLYTECH\ISRPO\WPF Laboratory Work\Laboratory_Work2_WPF(пример)\lab2.3\cards\" + suits + ".jpg";
            //frotImage = new Image()
            //{
            //    Source = new BitmapImage(new Uri(frontPath))
            //};
            Image retImg = (img) ? frotImage : backImage;
            return retImg;
        }
        

        

        

        private Card()
        {

        }

        public Card(rank rank, suit suit)
        {
            
            indexCard = (int)suit * 13 + (int)rank + 1;

            frontPath = @"D:\STUDY\POLYTECH\4 course POLYTECH\ISRPO\WPF Laboratory Work\Laboratory_Work2_WPF(пример)\lab2.3\cards\" + indexCard + ".jpg";

            frotImage = new Image()
            {
                Source = new BitmapImage(new Uri(frontPath))
            };

            backImage = new Image()
            {
                Source = new BitmapImage(new Uri(backPath))
            };

            nameCard = (string)suit.ToString() + " " + (string)rank.ToString(); 

        }






        public override string ToString()
        {
            return nameCard;
        }
    }

}
