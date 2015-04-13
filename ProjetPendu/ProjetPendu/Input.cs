using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pendu;

namespace ProjetPendu
{
    public class InputConsole : IInput
    {
        /// <summary>
        /// Read the next input 
        /// </summary>
        /// <returns> Input pressed by the player</returns>
        public String Input()
        {
            return Console.ReadLine();
        }
    }
}
