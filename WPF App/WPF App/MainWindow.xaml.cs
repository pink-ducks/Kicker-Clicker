using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_App.Controller;
using WPF_App.Model;
using WPF_App.View;

namespace WPF_App
{
    public partial class MainWindow : Window
    {
        User user = new User(); // MODEL
        BasicImprovement BI1 = new BasicImprovement(15, 0.1); // MODEL
        BasicImprovement BI2 = new BasicImprovement(100, 1); // MODEL
        BasicImprovement BI3 = new BasicImprovement(1100, 8); // MODEL
        BasicImprovement BI4 = new BasicImprovement(12000, 47); // MODEL
        BasicImprovement BI5 = new BasicImprovement(130000, 260); // MODEL
        BasicImprovement BI6 = new BasicImprovement(1400000, 1400); // MODEL
        DoubleClicker doubleClicker = new DoubleClicker(50); // MODEL
        MyView view = new MyView(); // VIEW
        UserController controller = new UserController(); // CONTROLLER

        public MainWindow()
        {
            InitializeComponent();
            // link
            controller.LinkView(view);
            // main click
            view.AddLabel(ScoreLabel);
            view.AddSpeedOfAddingPointsLabel(SpeedOfAddingPointsLabel);
            view.AddClickPointAddLabel(ClickPointAddLabel);
            // improvmenets
            view.AddButtons(Improvement1Button, Improvement2Button, Improvement3Button, Improvement4Button, Improvement5Button, Improvement6Button);
            view.AddImprovementsLevelsLabels(Improvement1Label, Improvement2Label, Improvement3Label, Improvement4Label, Improvement5Label, Improvement6Label);
            view.AddImprovementImages(improvement1Image, improvement2Image, improvement3Image, improvement4Image, improvement5Image, improvement6Image);
            view.SetButtonsTexts(BI1.StartingPrice, BI2.StartingPrice, BI3.StartingPrice, BI4.StartingPrice, BI5.StartingPrice, BI6.StartingPrice);

            controller.AddBasicImprovements(BI1, BI2, BI3, BI4, BI5, BI6);
            // double clicker
            controller.AddBonusImprovements(doubleClicker);
            view.AddButtons(BonusImprovement1Button);
            //
            controller.AddUser(user);
        }
        // Main Click Button
        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickButton();
        }
        // Improvements
        private void Improvement1Button_Click(object sender, RoutedEventArgs e)
        {
            if(user.Points >= BI1.CurrentPrice)
            {
                controller.ClickBasicImprovement(BI1, 0);
            }
        }

        private void Improvement2Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI2.CurrentPrice)
            {
                controller.ClickBasicImprovement(BI2, 1);
            }
        }

        private void Improvement3Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI3.CurrentPrice)
            {
                controller.ClickBasicImprovement(BI3, 2);
            }
        }

        private void Improvement4Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI4.CurrentPrice)
            {
                controller.ClickBasicImprovement(BI4, 3);
            }
        }

        private void Improvement5Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI5.CurrentPrice)
            {
                controller.ClickBasicImprovement(BI5, 4);
            }
        }

        private void Improvement6Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI6.CurrentPrice)
            {
                controller.ClickBasicImprovement(BI6, 5);
            }
        }
        private void BonusImprovement1Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= doubleClicker.CurrentPrice)
            {
                // to create method in userController
                controller.UpgradeBonusImprovement(0);
                view.SetButtonText(doubleClicker.CurrentPrice, 6);
            }
        }
    }
}
