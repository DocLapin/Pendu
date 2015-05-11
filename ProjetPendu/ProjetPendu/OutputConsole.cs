using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Pendu.Properties;
using Pendu;

namespace Pendu
{
    /// <summary>
    /// Provides services to use the console <see cref="IOutput"/>
    /// </summary>
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
            character.SetSource(@ConfigurationManager.AppSettings["defaultCharacterPath"]);
            String[] characterState = character.GetState(numcharacter);
            foreach (String s in characterState)
            {
                Console.WriteLine(s);
            }
        }

        public void ShowWordState(Word w)
        {
            Console.WriteLine(w.GetCurrentState());
        }

        public void ShowLost(Word w)
        {
            Console.WriteLine(ConfigurationManager.AppSettings["lostPrompt"] + w.WordToFindString);
        }

        public void ShowWin()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["winPrompt"]);
        }

        public void ShowReset()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["resetPrompt"]);
        }

        public void ShowNoMoreWords()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["endwordsPrompt"]);
        }

        public void ShowNumber(Word w)
        {
            Console.WriteLine(ConfigurationManager.AppSettings["numberlettersPrompt"] + w.GetNumberLetter().ToString());
        }
    }
}
