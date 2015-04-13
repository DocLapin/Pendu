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
        void SetFichier(String fileName);

        /// <summary>
        /// Get the initial state of the pendu (generaly the ground)
        /// </summary>
        /// <param name="num">The number of the state to get</param>
        /// <returns>String arrray of the state</returns>
        string[] GetEtat(int num);



        /// <summary>
        /// Tell if the previous state showed is the final state
        /// </summary>
        /// <returns>True or False</returns>
        bool IsFinal();
    }
}
