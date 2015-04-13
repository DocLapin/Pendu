using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetPendu
{
    interface ICharacter
    {

        /// <summary>
        /// Set the file to use as the character
        /// </summary>
        /// <param name="fileName">the file path of the file</param>
        public void SetFichier(String fileName);

        /// <summary>
        /// Get the initial state of the pendu (generaly the ground)
        /// </summary>
        public void GetEtatInitial();

        /// <summary>
        /// Get the next state of the pendu
        /// </summary>
        public void GetEtatSuivant();

        /// <summary>
        /// Tell if the previous state showed is the final state
        /// </summary>
        /// <returns>True or False</returns>
        public Boolean IsFinal();
    }
}
