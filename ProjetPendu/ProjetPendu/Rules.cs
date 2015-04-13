using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetPendu
{
    class Rules
    {

        /// <summary>
        /// Afiche les règles
        /// </summary>
        /// <returns></returns>
        public string GetRules()
        {
            return "Le joueur peut proposer soit une lettre, soit un mot complet.\n Le joueur ne peut proposer qu'une seule lettre par tour." 
        }//End of ShowRules
    }
}
