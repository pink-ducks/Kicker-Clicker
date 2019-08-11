using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WPF_App.Model;

namespace WPF_App.Controller
{
    class UserController: MyController
    {
        public void ClickButton()
        {
            new SoundPlayer(@"Sources\Sounds\SoccerKick_author$volivieri$.wav").Play();
            this.AddPointsToUser(User.PointsPerClick);
            View.SetScoreLabelText(User.Points);
            View.ClickPointAddLabelAnimation();
            View.SetClickPointAddLabelText(User.PointsPerClick);
        }

        public void ClickBasicImprovement(int index)
        {
            if(BasicImprovements[index].checkPrice(User)) // check user's points
            {
                this.ChargeUser(BasicImprovements[index].CurrentPrice);
                View.SetScoreLabelText(User.Points); //ScoreLabel.Content = user.Points;

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
                this.ChargeUser(DoubleClicker.CurrentPrice);
                View.SetScoreLabelText(User.Points);
                View.UpgradeLevelLabel(6); // 6 -> DoubleClicker index 
                DoubleClicker.Upgrade();
                this.User.PointsPerClick = this.User.PointsPerClick * 2;
                View.SetButtonText(DoubleClicker.CurrentPrice, 6);
            }
        }
    }
}
