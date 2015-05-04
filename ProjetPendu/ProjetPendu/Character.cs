using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Pendu
{
    public class Character : ICharacter
    {

        private static readonly int NUM_MAX_STATE = 8;
        private static readonly int NUM_MIN_STATE = 1;
        private static readonly int NUM_NEXT_STATE = 7;

        private string filepath;

        public static T[] SubArray<T>(T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        public void SetFichier(string fileName)
        {
            if (fileName.Length > 0)
                filepath = fileName;
        }

        public String[] GetEtat(int numero)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                String numdep = numero.ToString();
                numero++;
                String numfin = numero.ToString();
                int lignedebut = NUM_MIN_STATE;
                int lignefin = NUM_NEXT_STATE;
                String[] lines = File.ReadAllLines(@filepath);
                String[] Sublines;
                for (int i = 0; i <= lines.Length-1; i++)
                {
                    if (lines[i].Contains(numdep))
                    {
                        lignedebut = i + 1;

                    }
                    if (lines[i].Contains(numfin))
                    {
                        lignefin = i - 1;
                    }

                }

                Sublines = SubArray<String>(lines, lignedebut, lignefin-lignedebut+1);

                return Sublines;
            }
        }

        public bool IsFinal(int numero)
        {
            return numero == NUM_MAX_STATE;
        }
    }
}
