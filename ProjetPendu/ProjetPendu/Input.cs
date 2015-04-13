using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetPendu
{
    public class InputConsole : IInput
    {

        string Input()
        {
            return Console.ReadLine();
        }
    }
}
