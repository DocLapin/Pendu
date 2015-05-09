using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Pendu
{
    /// <summary>
    /// Represents values about rules and symbol
    /// </summary>
    public class Rules
    {

        #region Fields and Properties

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

        private readonly string _rulesDetails;

        public string RulesDetails
        {
            get { return _rulesDetails; }
        }

        private readonly string _symbolRules;

        public string SymbolRules
        {
            get { return _symbolRules; }
        }

        private readonly string _symbolQuit;
       
        public string SymbolQuit
        {
            get { return _symbolQuit; }
        }

        private readonly string _symbolReset;

        public string SymbolReset
        {
            get { return _symbolReset; }
        }

        #endregion

        public Rules()
        {
            _minLengthWord = int.Parse(ConfigurationManager.AppSettings["minLengthWord"]);
            _maxLengthWord = int.Parse(ConfigurationManager.AppSettings["maxLengthWord"]);
            _maxNbErrors = int.Parse(ConfigurationManager.AppSettings["maxNbErrors"]);
            _rulesDetails = ConfigurationManager.AppSettings["rulesDetails"];
            _symbolRules = ConfigurationManager.AppSettings["symbolRules"];
            _symbolQuit = ConfigurationManager.AppSettings["symbolQuit"];
            _symbolReset = ConfigurationManager.AppSettings["symbolReset"];
        }

        public Rules(int minLengthWord, int maxLengthWord, int maxNbErrors, string rulesDetails, string symbolRules, string symbolQuit, string symbolReset)
        {
            _minLengthWord = minLengthWord;
            _maxLengthWord = maxLengthWord;
            _maxNbErrors = maxNbErrors;
            _rulesDetails = rulesDetails;
            _symbolRules = symbolRules;
            _symbolQuit = symbolQuit;
            _symbolReset = _symbolReset;
        }

    }
}
