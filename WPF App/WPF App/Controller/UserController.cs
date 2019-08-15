using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using WPF_App.Model;

namespace WPF_App.Controller
{
    class UserController: MyController
    {
        private SoundPlayer clickSound = new SoundPlayer(@"Sources\Sounds\SoccerKick_author$volivieri$.wav");
        private SoundPlayer upgradeSound = new SoundPlayer(@"Sources\Sounds\SoccerFansCheering.wav");
        private GameSaver gameSaver = new GameSaver();

        // DESTRUCTOR
        ~UserController()
        {
            SaveGameInfo();
        }
        public void SaveGameInfo()
        {
            gameSaver.SaveData(this);
        }

        public void UploadSavedData()
        {
            gameSaver.LoadScoreAndImprovements(this);
        }
        public void ClickButton()
        {
            this.clickSound.Play();
            this.AddPointsToUser(User.PointsPerClick);
            View.SetScoreLabelText(User.Points);
            View.ClickPointAddLabelAnimation();
            View.SetClickPointAddLabelText(User.PointsPerClick);
        }
        public void ClickBasicImprovement(int index)
        {
            if(BasicImprovements[index].checkPrice(User)) // check user's points
            {
                upgradeSound.Play();
                this.ChargeUser(BasicImprovements[index].CurrentPrice);
                upgradeImprovement(index);
            }
        }
        public void upgradeImprovement(int index)
        {
            View.SetScoreLabelText(User.Points); //ScoreLabel.Content = user.Points;
            this.IncreaseUserAdditionSpeed(BasicImprovements[index].SpeedOfAddingPoints);
            this.UpgradeBasicImprovement(index);
            View.SetButtonText(BasicImprovements[index].CurrentPrice, index);
            View.UpgradeLevelLabel(index);
            // update pic
            View.UpdateBasicImprovementPic(index, BasicImprovements[index].NumberOfUpgrades);
        }


        public void ClickDoubleClicker()
        {
            if (User.Points >= DoubleClicker.CurrentPrice)
            {
                new SoundPlayer(@"Sources\Sounds\SoccerFansCheering.wav").Play();
                this.ChargeUser(DoubleClicker.CurrentPrice);
                UpgradeDoubleClicker();
            }
        }

        public void UpgradeDoubleClicker()
        {
            View.SetScoreLabelText(User.Points);
            View.UpgradeLevelLabel(6); // 6 -> DoubleClicker index 
            DoubleClicker.Upgrade();
            const int Digits = 1;
            DoubleClicker.CurrentPrice = Math.Round(DoubleClicker.CurrentPrice * 2, Digits);
            this.User.PointsPerClick = this.User.PointsPerClick * 2;
            View.SetButtonText(DoubleClicker.CurrentPrice, 6); // 6 -> DoubleClicker index 
        }

        public void ClickDoublePointer()
        {
            if (User.Points >= DoublePointer.CurrentPrice)
            {
                new SoundPlayer(@"Sources\Sounds\SoccerFansCheering.wav").Play();
                this.ChargeUser(DoublePointer.CurrentPrice);
                UpgradeDoublePointer();
            }
        }

        public void UpgradeDoublePointer()
        {
            View.SetScoreLabelText(User.Points);
            View.UpgradeLevelLabel(7); // 7 -> DoublePointer index 
            DoublePointer.Upgrade();
            const int Digits = 1;
            DoublePointer.CurrentPrice = Math.Round(DoublePointer.CurrentPrice * 100, Digits);
            View.SetButtonText(DoublePointer.CurrentPrice, 7); // 7 -> DoublePointer index 
            this.UpdateInfoLabels();
        }

    }
}
