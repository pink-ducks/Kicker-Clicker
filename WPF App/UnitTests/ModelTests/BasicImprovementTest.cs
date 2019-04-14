using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF_App.Model;

namespace UnitTests
{
    [TestClass]
    public class BasicImprovementTest
    {
        [TestMethod]
        public void BIInitializationTest()
        {
            BasicImprovement I = new BasicImprovement(10000, 0.1, 4);

            Assert.AreEqual(0, I.NumberOfUpgrades);
            Assert.AreEqual(10000, I.StartingPrice);
            Assert.AreEqual(10000, I.CurrentPrice);
            Assert.AreEqual(0.1 , I.StartingSpeed);
            Assert.AreEqual(0.1, I.CurrentSpeed);
            Assert.AreEqual(4, I.LevelRequired);
        }
        [TestMethod]
        public void BIUpgradeTest()
        {
            BasicImprovement I = new BasicImprovement(10000, 0.1, 4);
            // user level > improvement level
            I.Upgrade();
            I.Upgrade();    
            // after double upgrade:
            Assert.AreEqual(2, I.NumberOfUpgrades);
            Assert.AreEqual(10000, I.StartingPrice);
            Assert.AreEqual(13225, I.CurrentPrice);
            Assert.AreEqual(0.1, I.StartingSpeed);
            Assert.AreEqual(0.3, I.CurrentSpeed, 0.00000001);
            Assert.AreEqual(4, I.LevelRequired);
        }
    }
}
