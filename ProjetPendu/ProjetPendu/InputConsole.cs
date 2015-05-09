using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pendu;

namespace Pendu
{
    public class InputConsole : IInput
    {
        /// <summary>
        /// Reads the next input 
        /// </summary>
        /// <returns> Input pressed by the player</returns>
        public string Input()
        {
            return Console.ReadLine();
        }
    }
}
