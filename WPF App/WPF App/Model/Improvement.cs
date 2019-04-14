using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App.Model
{
    public class Improvement
    {
        private int numbeOfUpgrades;
        private int startingPrice;
        private int currentPrice;
        private double startingSpeed;
        private double currentSpeed;
        private int levelRequired;

        public int NumberOfUpgrades { get => numbeOfUpgrades; set => numbeOfUpgrades = value; }
        public int StartingPrice { get => startingPrice; set => startingPrice = value; }
        public int CurrentPrice { get => currentPrice; set => currentPrice = value; }
        public double StartingSpeed { get => startingSpeed; set => startingSpeed = value; }
        public double CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }
        public int LevelRequired { get => levelRequired; set => levelRequired = value; }

        // CONSTRUCTORS
        public Improvement()
        {

        }
        // with startingPrice, startingSpeed and levelRequired
        public Improvement(int startingPrice, double startingSpeed, int levelRequired)
        {
            StartingPrice = startingPrice;
            CurrentPrice = startingPrice;
            StartingSpeed = startingSpeed;
            CurrentSpeed = startingSpeed;
            LevelRequired = levelRequired;
        }

        // METHODS
        public void upgradeBy(User user)
        {
            if(user.Level >= LevelRequired)
            {
                NumberOfUpgrades++;
                CurrentPrice = Convert.ToInt32(StartingPrice * Math.Pow(1.15, numbeOfUpgrades));
                CurrentSpeed = CurrentSpeed + StartingSpeed;
            }
        }
    }
}
