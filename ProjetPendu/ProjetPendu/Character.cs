using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Pendu
{
    /// <summary>
    /// Represents the character
    /// </summary>
    public class Character : ICharacter
    {
        #region Fields and Properties

        private static readonly int NUM_MIN_STATE = 1;

        private static readonly int NUM_NEXT_STATE = 7;

        private string _filePath;

        #endregion

        /// <summary>
        /// Gets the initial state of the character (generaly the ground)
        /// </summary>
        /// <param name="num">The number of the state to get</param>
        /// <returns>String arrray of the state</returns>
        public string[] GetState(int numero)
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                string numdep = numero.ToString();
                numero++;
                string numfin = numero.ToString();
                int lignedebut = NUM_MIN_STATE;
                int lignefin = NUM_NEXT_STATE;
                string[] lines = File.ReadAllLines(_filePath);
                string[] sublines;
                for (int i = 0; i <= lines.Length-1; i++)
                {
                    if (lines[i].Contains(numdep))
                    {
                        lignedebut = i + 1;
                    }
                    // no else
                    if (lines[i].Contains(numfin))
                    {
                        lignefin = i - 1;
                    }
                    // no else
                }
                sublines = SubArray<String>(lines, lignedebut, lignefin - lignedebut + 1);
                return sublines;
            }
        }

        /// <summary>
        /// Sets the source to load the character
        /// </summary>
        public void SetSource(string s)
        {
            _filePath = s;
        }

        private static T[] SubArray<T>(T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

    }
}
