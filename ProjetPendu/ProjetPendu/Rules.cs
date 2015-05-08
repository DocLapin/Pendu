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

        private readonly string _rulesDetails;
        public string _symbolRules { get; private set; }
        public string _symbolQuit { get; private set; }

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
            _symbolRules = ConfigurationManager.AppSettings["symbolRules"];
            _symbolQuit = ConfigurationManager.AppSettings["symbolQuit"];
        }

    }
}
