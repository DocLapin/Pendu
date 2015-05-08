using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Pendu.Properties;
using Pendu;

namespace Pendu
{
    public class OutputConsole : IOutput
    {
        public void ShowMenu()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["mainMenu"]);


        }
        public void ShowRules(Rules r)
        {
            Console.WriteLine(r.RulesDetails);
        }

        public void ShowCharacter(ICharacter character, int numcharacter)
        {
           
            character.SetFichier(@ConfigurationManager.AppSettings["defaultCharacterPath"]);
            String[] bonhomme = character.GetEtat(numcharacter);
            foreach (String s in bonhomme)
            {
                Console.WriteLine(s);
            }
        }

        public void ShowWord(Word w)
        {
            Console.WriteLine(w.GetCurrentState());
        }

        public void ShowString(String s)
        {
            Console.WriteLine("Le mot était : " + s);
        }

        public void ShowLost()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["lostPrompt"]);
        }

        public void ShowWin()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["winPrompt"]);
        }

        public void ShowReset()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["resetPrompt"]);
        }
        public void ShowEndWords()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["endwordsPrompt"]);
        }
    }
}
