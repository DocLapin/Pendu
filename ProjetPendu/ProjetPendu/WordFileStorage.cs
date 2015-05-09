using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Pendu
{
    /// <summary>
    /// Provides services if words are stored in a file <see cref="WordFileStorage"/>
    /// </summary>
    public class WordFileStorage : IWordStorage
    {

        #region Fields and Properties

        /// <summary>
        /// File path to the file which contains words
        /// </summary
        private string _filePath;

        #endregion

        /// <summary>
        /// Construct a WordFileStorage from the default file which contains words
        /// </summary>
        public WordFileStorage()
        {
            _filePath = ConfigurationManager.AppSettings["defaultWordsFilePath"];
        }

        /// <summary>
        /// Construct a WordFileStorage from a file which contains words
        /// </summary>
        /// <param name="filePath">File path</param>
        public WordFileStorage(String filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Loads the file
        /// </summary>
        /// <returns>Words obtained by reading the file</returns>
        public List<Word> Load()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                return ReadWords();
            }
        }

        /// <summary>
        /// Reads the file
        /// </summary>
        /// <returns>Words contained in the file</returns>
        private List<Word> ReadWords()
        {
            List<Word> wordList = new List<Word>();
            using (StreamReader sr = File.OpenText(_filePath))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    if(!String.IsNullOrWhiteSpace(s))
                    {
                        wordList.Add(new Word(s));
                    }
                    // no else
                }
            }
            return wordList;
        }
       
    }
}
