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

        public void ClickBasicImprovement(BasicImprovement i, int index)
        {
            this.ChargeUser(i.CurrentPrice);
            View.SetLabelText(User.Points);

            //ScoreLabel.Content = user.Points;
            this.IncreaseUserAdditionSpeed(i.SpeedOfAddingPoints);
            this.UpgradeBasicImprovement(index);
            View.SetButtonText(i.CurrentPrice, index);
            View.UpgradeLevelLabel(index);
            View.SetSpeedOfAddingPointsLabelText(User.SpeedOfAddingPoints);
            // update pic
            View.UpdateBasicImprovementPic(index, i.NumberOfUpgrades);
        }

    }
}
