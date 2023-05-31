using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Conservatoire.Modele;
using Conservatoire.DAL;
using Conservatoire.Controleur;


namespace UnitTestConservatoire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mgr monManager = new Mgr();
            Assert.AreEqual(false, monManager.verifConnexion("Bonjour", "on"));
            Assert.AreEqual(true, monManager.verifConnexion("login", "mdp"));
            Assert.IsTrue(monManager.verifConnexion("login", "mdp"));


            /*monManager.verifConnexion
            */


        }
    }
}
