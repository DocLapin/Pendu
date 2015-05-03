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

        public void ShowCharacter(ICharacter character, int numcharacter)
        {
        }

        public void ShowWord(Word w)
        {
            Console.WriteLine(w.GetCurrentState());
        }
    }
}
