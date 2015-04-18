using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendu
{
    public class Rules
    {

        public static readonly int MIN_LENGTH_WORD = 3 ;
            public static readonly int MAX_LENGTH_WORD = 10 ;

        /// <summary>
        /// Afiche les règles
        /// </summary>
        /// <returns></returns>
        public string GetRules()
        {
            return "Le joueur peut proposer soit une lettre, soit un mot complet.\n Le joueur ne peut proposer qu'une seule lettre par tour.";
        }//End of ShowRules


    }
}
