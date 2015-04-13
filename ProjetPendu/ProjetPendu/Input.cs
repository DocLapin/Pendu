using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetPendu
{
    public class InputConsole : IInput
    {
        /// <summary>
        /// Read the next input 
        /// </summary>
        /// <returns> Input pressed by the player</returns>
        string Input()
        {
            return Console.ReadLine();
        }
    }
}
