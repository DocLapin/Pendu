using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Pendu
{
    public class WordFileStorage : IWordStorage
    {

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            private set { _filePath = value; }
        }

        public WordFileStorage()
        {
            FilePath = ConfigurationManager.AppSettings["defaultWordsFilePath"];
        }

        /// <summary>
        /// Construct a wordFileStorage from a file path
        /// </summary>
        /// <param name="filePath">File's file path</param>
        public WordFileStorage(String filePath)
        {
            FilePath = filePath;
        }

        /// <summary>
        /// Load the file
        /// </summary>
        /// <returns>Words obtained by reading the file</returns>
        public List<Word> Load()
        {
            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException();
            }
            else
            {
                return ReadWords();
            }
        }

        /// <summary>
        /// Read the file
        /// </summary>
        /// <returns>Words contained in the file</returns>
        private List<Word> ReadWords()
        {
            List<Word> wordList = new List<Word>();
            using (StreamReader sr = File.OpenText(FilePath))
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
