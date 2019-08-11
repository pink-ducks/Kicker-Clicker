using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App.Model
{
    public abstract class Improvement
    {
        private int _numberOfUpgrades;
        private int _startingPrice;
        private double _currentPrice;

        public int NumberOfUpgrades { get => _numberOfUpgrades; set => _numberOfUpgrades = value; }
        public int StartingPrice { get => _startingPrice; set => _startingPrice = value; }
        public double CurrentPrice { get => _currentPrice; set => _currentPrice = value; }

        // METHODS
        public abstract void Upgrade();
        public bool checkPrice(User u)
        {
            if (u.Points >= this.CurrentPrice)
                return true;
            else
                return false;
        }
    }
}
