using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pendu
{
    public class Rules
    {
        /*
        / Values are only here for remember
        */

        private readonly int _minLengthWord = 3;

        public int MinLengthWord
        {
            get { return _minLengthWord; }
        } 

        private readonly int _maxLengthWord = 10;

        public int MaxLengthWord
        {
            get { return _maxLengthWord; }
        } 

        private readonly int _maxNbErrors = 8;

        public int MaxNbErrors
        {
            get { return _maxNbErrors; }
        } 

        private readonly string _rulesDetails = 
            "Le joueur peut proposer soit une lettre, soit un mot complet."
            + Environment.NewLine +
            "Le joueur ne peut proposer qu'une seule lettre par tour.";

        public string RulesDetails
        {
            get { return _rulesDetails; }
        }

        public Rules(int minLengthWord, int maxLengthWord, int maxNbErrors, string rulesDetails)
        {
            _minLengthWord = minLengthWord;
            _maxLengthWord = maxLengthWord;
            _maxNbErrors = maxNbErrors;
            _rulesDetails = rulesDetails;
        }

    }
}
