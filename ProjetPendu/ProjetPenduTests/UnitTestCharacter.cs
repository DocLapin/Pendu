using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendu;
using System.Configuration;

namespace ProjetPenduTests
{
    
    [TestClass]
    public class UnitTestCharacter
    {
        private static ICharacter character;

        [TestInitialize]
        public void TestInitialize()
        {
            character = new Character();
            character.SetSource(ConfigurationManager.AppSettings["defaultCharacterPath"]);
        }

        [TestMethod]
        public void TestBeginCharacter()
        {
            string[] waitedString = {" ", " ", " ", " ", " ", " ", "_____"};
            string[] resultString = character.GetState(0);
            for (int i = 0; i <= 6; i++)
            {
                Assert.AreEqual(waitedString[i].ToString(), resultString[i].ToString());
            }
        }

        [TestMethod]
        public void TestMiddleCharacter()
        {
            string[] waitedString = { " _______", " |/ |", " |  O", " | /", " |  ", " | ", "_|___" };
            string[] resultString = character.GetState(4);
            for (int i = 0; i <= 6; i++)
            {
                Assert.AreEqual(waitedString[i].ToString(), resultString[i].ToString());
            }
        }
        
        [TestMethod]
        public void TestEndCharacter()
        {
            string[] waitedString = { " _______", " |/ |", " |  O", " | /|\\", " |  |", " | / \\", "_|___" };
            string[] resultString = character.GetState(8);
            for (int i = 0; i <= 6; i++)
            {
                Assert.AreEqual(waitedString[i].ToString(), resultString[i].ToString());
            }
        }
    }
}
