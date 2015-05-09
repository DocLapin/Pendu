using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendu
{
    /// <summary>
    /// Provides services to use a character
    /// </summary>
    public interface ICharacter
    {
        /// <summary>
        /// Gets the initial state of the character (generaly the ground)
        /// </summary>
        /// <param name="num">The number of the state to get</param>
        /// <returns>String arrray of the state</returns>
	    string[] GetState(int num);

        /// <summary>
        /// Sets the source to load the character
        /// </summary>
        void SetSource(string s);
    }
}
