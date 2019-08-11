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
        private SoundPlayer soundPlayer = new SoundPlayer(@"Sources\Sounds\SoccerKick_author$volivieri$.wav");
        public void ClickButton()
        {
            this.soundPlayer.Play();
            this.AddPointsToUser(User.PointsPerClick);
            View.SetScoreLabelText(User.Points);
            View.ClickPointAddLabelAnimation();
            View.SetClickPointAddLabelText(User.PointsPerClick);
        }

        public void ClickBasicImprovement(int index)
        {
            if(BasicImprovements[index].checkPrice(User)) // check user's points
            {
                new SoundPlayer(@"Sources\Sounds\SoccerFansCheering.wav").Play();
                this.ChargeUser(BasicImprovements[index].CurrentPrice);
                View.SetScoreLabelText(User.Points); //ScoreLabel.Content = user.Points;

                this.IncreaseUserAdditionSpeed(BasicImprovements[index].SpeedOfAddingPoints);
                this.UpgradeBasicImprovement(index);
                View.SetButtonText(BasicImprovements[index].CurrentPrice, index);
                View.UpgradeLevelLabel(index);
                // update pic
                View.UpdateBasicImprovementPic(index, BasicImprovements[index].NumberOfUpgrades);
            }
        }

        public void ClickDoubleClicker()
        {
            if (User.Points >= DoubleClicker.CurrentPrice)
            {
                new SoundPlayer(@"Sources\Sounds\SoccerFansCheering.wav").Play();
                this.ChargeUser(DoubleClicker.CurrentPrice);
                View.SetScoreLabelText(User.Points);
                View.UpgradeLevelLabel(6); // 6 -> DoubleClicker index 
                DoubleClicker.Upgrade();
                DoubleClicker.CurrentPrice = Convert.ToInt32(DoubleClicker.CurrentPrice * 4);
                this.User.PointsPerClick = this.User.PointsPerClick * 2;
                View.SetButtonText(DoubleClicker.CurrentPrice, 6); // 6 -> DoubleClicker index 
            }
        }
        public void ClickDoublePointer()
        {
            if (User.Points >= DoublePointer.CurrentPrice)
            {
                new SoundPlayer(@"Sources\Sounds\SoccerFansCheering.wav").Play();
                this.ChargeUser(DoublePointer.CurrentPrice);
                View.SetScoreLabelText(User.Points);
                View.UpgradeLevelLabel(7); // 7 -> DoublePointer index 
                DoublePointer.Upgrade();
                DoublePointer.CurrentPrice = Convert.ToInt32(DoublePointer.CurrentPrice * 10);
                View.SetButtonText(DoublePointer.CurrentPrice, 7); // 7 -> DoublePointer index 
                this.UpdateInfoLabels();
            }
        }
    }
}
