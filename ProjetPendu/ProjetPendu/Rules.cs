using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Pendu
{
    public class Rules
    {
        private readonly int _minLengthWord;

        public int MinLengthWord
        {
            get { return _minLengthWord; }
        } 

        private readonly int _maxLengthWord;

        public int MaxLengthWord
        {
            get { return _maxLengthWord; }
        } 

        private readonly int _maxNbErrors;

        public int MaxNbErrors
        {
            get { return _maxNbErrors; }
        }

        private readonly string _mainRules;

        public string MainRules
        {
            get { return _mainRules; }
        }

        private readonly string _rulesDetails = 
            "Le joueur peut proposer soit une lettre, soit un mot complet."
            + Environment.NewLine +
            "Le joueur ne peut proposer qu'une seule lettre par tour.";


        public string RulesDetails
        {
            get { return _rulesDetails; }
        }

        public Rules()
        {
            _minLengthWord = int.Parse(ConfigurationManager.AppSettings["minLengthWord"]);
            _maxLengthWord = int.Parse(ConfigurationManager.AppSettings["maxLengthWord"]);
            _maxNbErrors = int.Parse(ConfigurationManager.AppSettings["maxNbErrors"]);
            _rulesDetails = ConfigurationManager.AppSettings["rulesDetails"];
            _mainRules = ConfigurationManager.AppSettings["mainRules"];
        }

    }
}
