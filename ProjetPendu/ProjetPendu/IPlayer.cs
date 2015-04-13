﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetPendu
{
    interface IPlayer
    {

        /// <summary>
        /// Plays a letter 
        /// </summary>
        /// <returns> The letter played by the player</returns>
        public String PlayChar();


        /// <summary>
        /// Plays a word
        /// </summary>
        /// <returns> The word played by the player </returns>
        public String PlayWord();

        /// <summary>
        /// the player give up the game 
        /// </summary>
        public void GiveUp();


    }
}
