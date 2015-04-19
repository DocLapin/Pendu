using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendu;
using System.IO;
using System.Collections.Generic;

namespace ProjetPenduTests
{
    [TestClass]
    public class UnitTestWordFileStorage
    {
        private readonly string TEST_FILE_PATH = Path.GetTempFileName();

        private StreamWriter _file;

        private readonly Word[] TEST_WORDS = { new Word("UnitTest1"), new Word("UnitTest2") };

        [TestInitialize]
        public void TestInitialize()
        {
            using (_file = new StreamWriter(TEST_FILE_PATH))
            {
                foreach (Word word in TEST_WORDS)
                {
                    _file.WriteLine(word.WordString);
                }
            }
            _file.Close();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            File.Delete(TEST_FILE_PATH);
        }


        [TestMethod]
        public void TestLoad1()
        {
            IWordStorage wordStorage = new WordFileStorage(TEST_FILE_PATH);
            List<Word> words = wordStorage.Load();
            int expected = TEST_WORDS.Length;
            int actual = words.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoad2()
        {
            IWordStorage wordStorage = new WordFileStorage(TEST_FILE_PATH);
            List<Word> words = wordStorage.Load();
            Word expectedWord = TEST_WORDS[0];
            Word actualWord = words[0];
            string expected = expectedWord.WordString;
            string actual = actualWord.WordString;
            Assert.AreEqual(expected, actual);
        }
    }
}
