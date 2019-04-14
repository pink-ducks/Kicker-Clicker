using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF_App.Model;

namespace UnitTests
{
    [TestClass]
    public class ImprovementTest
    {
        [TestMethod]
        public void ImporvementInitializationTest()
        {
            Improvement I = new Improvement(10000, 0.1, 4);

            Assert.AreEqual(0, I.NumberOfUpgrades);
            Assert.AreEqual(10000, I.StartingPrice);
            Assert.AreEqual(10000, I.CurrentPrice);
            Assert.AreEqual(0.1 , I.StartingSpeed);
            Assert.AreEqual(0.1, I.CurrentSpeed);
            Assert.AreEqual(4, I.LevelRequired);
        }
        [TestMethod]
        public void ImporvementUpgradeTest()
        {

            User user5 = new User(5);
            Improvement I = new Improvement(10000, 0.1, 4);
            // user level > improvement level
            I.upgradeBy(user5);
            I.upgradeBy(user5);    
            // after double upgrade:
            Assert.AreEqual(2, I.NumberOfUpgrades);
            Assert.AreEqual(10000, I.StartingPrice);
            Assert.AreEqual(13225, I.CurrentPrice);
            Assert.AreEqual(0.1, I.StartingSpeed);
            Assert.AreEqual(0.3, I.CurrentSpeed, 0.00000001);
            Assert.AreEqual(4, I.LevelRequired);
        }
        [TestMethod]
        public void ImporvementUpgradeProhibitedTest()
        {
            User user3 = new User(3);
            Improvement I = new Improvement(10000, 0.1, 4);
            // user level < improvement level
            I.upgradeBy(user3);
            I.upgradeBy(user3);
            // upgrade prohibited
            // should not change:
            Assert.AreNotEqual(2, I.NumberOfUpgrades);
            Assert.AreNotEqual(13225, I.CurrentPrice);
            Assert.AreNotEqual(0.3, I.CurrentSpeed, 0.00000001);
            // should be:
            Assert.AreEqual(0, I.NumberOfUpgrades);
            Assert.AreEqual(10000, I.StartingPrice);
            Assert.AreEqual(10000, I.CurrentPrice);
            Assert.AreEqual(0.1, I.StartingSpeed);
            Assert.AreEqual(0.1, I.CurrentSpeed);
            Assert.AreEqual(4, I.LevelRequired);
        }
    }
}
