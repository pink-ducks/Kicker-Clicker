using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App.Model
{
    public class DoubleClicker: Improvement
    {
        public DoubleClicker(int startingPrice)
        {
            NumberOfUpgrades = 0;
            StartingPrice = startingPrice;
            CurrentPrice = startingPrice;
        }

        public override void Upgrade()
        {
            NumberOfUpgrades++;
            CurrentPrice = Convert.ToInt32(StartingPrice * 2 * NumberOfUpgrades);
        }
    }
}
