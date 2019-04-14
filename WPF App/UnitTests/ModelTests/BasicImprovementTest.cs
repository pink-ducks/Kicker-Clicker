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
            BasicImprovement I = new BasicImprovement(10000, 0.1);

            Assert.AreEqual(0, I.NumberOfUpgrades);
            Assert.AreEqual(10000, I.StartingPrice);
            Assert.AreEqual(10000, I.CurrentPrice);
            Assert.AreEqual(0.1 , I.SpeedOfAddingPoints);
        }
        [TestMethod]
        public void BIUpgradeTest()
        {
            BasicImprovement I = new BasicImprovement(10000, 0.1);
            // user level > improvement level
            I.Upgrade();
            I.Upgrade();    
            // after double upgrade:
            Assert.AreEqual(2, I.NumberOfUpgrades);
            Assert.AreEqual(10000, I.StartingPrice);
            Assert.AreEqual(13225, I.CurrentPrice);
            Assert.AreEqual(0.1, I.SpeedOfAddingPoints);
        }
    }
}
