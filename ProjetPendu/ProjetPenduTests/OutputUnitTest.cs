using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pendu;
using System.Configuration;

namespace ProjetPenduTests
{
    /// <summary>
    /// Description résumée pour OutputUnitTest
    /// </summary>
    [TestClass]
    public class OutputUnitTest
    {
        public OutputUnitTest()
        {
            
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestBeginCharacter()
        {
            String[] waitedString = {" ", " ", " ", " ", " ", " ", "_____"};
            ICharacter character = new Character();
            Console.WriteLine(System.IO.Path.GetFullPath(@"\..\myfile.txt"));
            character.SetFichier("c:\\temp\\fichiePerso.txt");
            String[] resultString = character.GetEtat(0);
            for (int i = 0; i <= 6; i++)
            {
                Assert.AreEqual(waitedString[i].ToString(), resultString[i].ToString());
            }
        }

        [TestMethod]
        public void TestMiddleCharacter()
        {
            String[] waitedString = { " _______", " |/ |", " |  O", " | /", " |  ", " | ", "_|___" };
            ICharacter character = new Character();
            Console.WriteLine(System.IO.Path.GetFullPath(@"\..\myfile.txt"));
            character.SetFichier("c:\\temp\\fichiePerso.txt");
            String[] resultString = character.GetEtat(4);
            for (int i = 0; i <= 6; i++)
            {
                Assert.AreEqual(waitedString[i].ToString(), resultString[i].ToString());
            }
        }
        
        [TestMethod]
        public void TestEndCharacter()
        {
            String[] waitedString = { " _______", " |/ |", " |  O", " | /|\\", " |  |", " | / \\", "_|___" };
            ICharacter character = new Character();
            Console.WriteLine(System.IO.Path.GetFullPath(@"\..\myfile.txt"));
            character.SetFichier("c:\\temp\\fichiePerso.txt");
            String[] resultString = character.GetEtat(8);
            for (int i = 0; i <= 6; i++)
            {
                Assert.AreEqual(waitedString[i].ToString(), resultString[i].ToString());
            }
        }
    }
}
