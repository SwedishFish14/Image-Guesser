﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Image_Guesser.Data.Components;

namespace Image_Guesser.Data
{
    public class Game
    {
        private Image currentImage;
        private int startingTime;
       

        public Game()
        {            
            startingTime = 10;
            currentImage = new Image("cat", "https://static01.nyt.com/images/2021/09/14/science/07CAT-STRIPES/07CAT-STRIPES-mediumSquareAt3X-v2.jpg", startingTime);
        }

        public String getCorrectWord()
        {
            return currentImage.getCorrectName();
        }

        public Image getCurrentImage()
        {

            return currentImage;
        }
        public int getBlurValue()
        {
            return currentImage.getBlurValue();
        }

        public int getStartingTime()
        {
            return startingTime;
        }
    }
}
