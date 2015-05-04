using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Pendu;

namespace Pendu
{
    public class OutputConsole : IOutput
    {
        public void ShowMenu()
        {
            Console.Write(ConfigurationManager.AppSettings["mainMenu"]);
        }
        public void ShowRules(Rules r)
        {
            Console.Write(r.RulesDetails);
        }

        /*
         * Displaying the actual character (pendu)
        */
        public void ShowCharacter(ICharacter character, int numcharacter)
        {
            character.SetFichier(ConfigurationManager.AppSettings["defaultCharacterPath"]);
            String[] bonhomme = character.GetEtat(numcharacter); 
            foreach (String s in bonhomme) {
                Console.Write(s);
            }
        }

        public void ShowWord(Word w)
        {
            Console.WriteLine(w.GetCurrentState());
        }
    }
}
