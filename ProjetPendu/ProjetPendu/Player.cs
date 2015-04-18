using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendu
{
    public class Player : IPlayer 
    {
        public string _idPlayer { get; private set; }

        Player(string idPlayer)
        {
            _idPlayer = idPlayer;
        }
    }
}
