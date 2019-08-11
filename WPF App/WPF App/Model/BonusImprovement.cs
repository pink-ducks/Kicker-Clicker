using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App.Model
{
    public class BonusImprovement: Improvement
    {
        public BonusImprovement(int startingPrice)
        {
            NumberOfUpgrades = 0;
            StartingPrice = startingPrice;
            CurrentPrice = startingPrice;
        }

        public override void Upgrade()
        {
            this.NumberOfUpgrades++;
        }
    }
}
