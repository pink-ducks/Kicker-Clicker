using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPF_App.Model;
using WPF_App;
using System.Windows.Media.Imaging;

namespace WPF_App.View
{
    public class MyView
    {
        List<Button> buttons = new List<Button>();
        List<Label> impovementsLevelsLabels = new List<Label>();
        List<Image> improvementsImages = new List<Image>();
        Label label = new Label();
        Label speedOfAddingPointsLabel = new Label();
        User user = new User();

        public Label Label { get => label; set => label = value; }
        public Label SpeedOfAddingPointsLabel { get => speedOfAddingPointsLabel; set => speedOfAddingPointsLabel = value; }
        public User User { get => user; set => user = value; }
        public List<Button> Buttons { get => buttons; set => buttons = value; }
        public List<Label> ImpovementsLevelsLabels { get => impovementsLevelsLabels; set => impovementsLevelsLabels = value; }
        public List<Image> ImprovementsImages { get => improvementsImages; set => improvementsImages = value; }

        // CONSTRUCTORS
        public MyView()
        {

        }
        // METHODS
        public void AddButtons(params Button[] buttons)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                Buttons.Add(buttons[i]);
            }
        }
        public void AddImprovementsLevelsLabels(params Label[] labels)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                ImpovementsLevelsLabels.Add(labels[i]);
            }
        }
        public void AddImprovementImages(params Image[] images)
        {
            for (int i = 0; i < images.Length; i++)
            {
                ImprovementsImages.Add(images[i]);
            }
        }

        public void AddLabel(Label label) => Label = label;
        public void AddSpeedOfAddingPointsLabel(Label speedOfAddingPointsLabel) => SpeedOfAddingPointsLabel = speedOfAddingPointsLabel;
        public void LinkWithUser(User user) => User = user;
        // setters
        public void UpgradeLevelLabel(int index)
        {
            int updatedLevel = int.Parse(ImpovementsLevelsLabels[index].Content.ToString());
            updatedLevel++;
            ImpovementsLevelsLabels[index].Content = updatedLevel.ToString();
        }

        public void SetButtonsTexts(params int[] prices)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                Buttons[i].Content = prices[i];
            }
        }

        public void SetButtonText(int price, int index)
        {
            buttons[index].Content = price;
        }

        public void SetLabelText(double points)
        {
            if (User.Points < 10000)
            {
                const int Digits = 1;
                double pointsToDisplay = Math.Round(points, Digits);
                label.Content = pointsToDisplay;
            }
            else
            {
                label.Content = points;
            }

        }
        public void SetSpeedOfAddingPointsLabelText(double speedOfAddingPoints)
        {
            if (User.SpeedOfAddingPoints < 10000)
            {
                const int Digits = 1;
                double pointsAddingSPeedToDisplay = Math.Round(speedOfAddingPoints, Digits);
                speedOfAddingPointsLabel.Content = "+" + pointsAddingSPeedToDisplay;
            }
            else
            {
                speedOfAddingPointsLabel.Content = "+" + speedOfAddingPoints;
            }

        }
        public void UpdateBasicImprovementPic(int index, int level)
        {
            if(level == 2)
            {
                this.ImprovementsImages[index].Source = new BitmapImage(new Uri("Sources/"+ index + "1.png", UriKind.Relative));
            }
            else if(level == 3)
            {
                this.ImprovementsImages[index].Source = new BitmapImage(new Uri("Sources/" + index + "2.png", UriKind.Relative));
            }
        }
    }
}
