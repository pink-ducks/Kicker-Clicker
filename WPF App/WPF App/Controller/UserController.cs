using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_App.Model;

namespace WPF_App.Controller
{
    class UserController: MyController
    {
        public void ClickButton()
        {
            this.AddPointsToUser(User.PointsPerClick);
            View.SetLabelText(User.Points);
            View.ClickPointAddLabelAnimation();
            View.SetClickPointAddLabelText(User.PointsPerClick);
        }

        public void ClickBasicImprovement(int index)
        {
            if(BasicImprovements[index].checkPrice(User)) // check user's points
            {
                this.ChargeUser(BasicImprovements[index].CurrentPrice);
                View.SetLabelText(User.Points);

                //ScoreLabel.Content = user.Points;
                this.IncreaseUserAdditionSpeed(BasicImprovements[index].SpeedOfAddingPoints);
                this.UpgradeBasicImprovement(index);
                View.SetButtonText(BasicImprovements[index].CurrentPrice, index);
                View.UpgradeLevelLabel(index);
                View.SetSpeedOfAddingPointsLabelText(User.SpeedOfAddingPoints);
                // update pic
                View.UpdateBasicImprovementPic(index, BasicImprovements[index].NumberOfUpgrades);
            }
        }

        public void ClickDoubleClicker()
        {
            if (User.Points >= DoubleClicker.CurrentPrice)
            {
                DoubleClicker.Upgrade();
                View.SetButtonText(DoubleClicker.CurrentPrice, 6);
            }
        }
    }
}
