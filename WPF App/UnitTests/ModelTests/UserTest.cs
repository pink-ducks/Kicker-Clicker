using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF_App.Model;

namespace UnitTests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserInitializationTest()
        {
            User TestUser = new User();

            double expectedPoints = 0;
            double expectedAddingSpeed = 0;

            double currentPoints = TestUser.Points;
            double currentAddingSpeed = TestUser.SpeedOfAddingPoints;

            Assert.AreEqual(expectedPoints, currentPoints);
            Assert.AreEqual(expectedAddingSpeed, currentAddingSpeed);
        }
    }
}
