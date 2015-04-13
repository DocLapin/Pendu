using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetPendu
{
    class Character : ICharacter
    {
        private string filepath;

        public void SetFichier(string fileName)
        {
            if (fileName.Length > 0)
                filepath = fileName;
        }

        public String[] GetEtat(int numero)
        {
            throw new NotImplementedException();
        }

        public bool IsFinal()
        {
            throw new NotImplementedException();
        }
    }
}
