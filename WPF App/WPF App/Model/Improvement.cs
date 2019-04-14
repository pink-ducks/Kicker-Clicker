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
        private int _currentPrice;
        private int _levelRequired;

        public int NumberOfUpgrades { get => _numberOfUpgrades; set => _numberOfUpgrades = value; }
        public int StartingPrice { get => _startingPrice; set => _startingPrice = value; }
        public int CurrentPrice { get => _currentPrice; set => _currentPrice = value; }
        public int LevelRequired { get => _levelRequired; set => _levelRequired = value; }

        // METHODS
        public abstract void Upgrade();
    }
}
