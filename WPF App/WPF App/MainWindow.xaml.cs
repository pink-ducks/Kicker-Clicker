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
        MyView view = new MyView(); // VIEW
        MyController controller = new MyController(); // CONTROLLER

        public MainWindow()
        {
            InitializeComponent();
            // link
            controller.LinkView(view);
            // main click
            view.AddLabel(ScoreLabel);
            // improvmenets
            view.AddButton(Improvement1Button);
            view.AddButton(Improvement2Button);
            view.AddButton(Improvement3Button);
            view.AddButton(Improvement4Button);
            view.AddButton(Improvement5Button);
            view.AddButton(Improvement6Button);

            view.SetButtonText(BI1.StartingPrice, 0);
            view.SetButtonText(BI2.StartingPrice, 1);
            view.SetButtonText(BI3.StartingPrice, 2);
            view.SetButtonText(BI4.StartingPrice, 3);
            view.SetButtonText(BI5.StartingPrice, 4);
            view.SetButtonText(BI6.StartingPrice, 5);

            controller.AddBasicImprovement(BI1);
            controller.AddBasicImprovement(BI2);
            controller.AddBasicImprovement(BI3);
            controller.AddBasicImprovement(BI4);
            controller.AddBasicImprovement(BI5);
            controller.AddBasicImprovement(BI6);

            controller.AddUser(user);
            //ConnSQL database = new ConnSQL();
            //database.Connection();

        }
        // Main Click Button
        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPointsToUser(1);
            view.SetLabelText(user.Points);
        }
        // Improvements
        private void Improvement1Button_Click(object sender, RoutedEventArgs e)
        {
            if(user.Points >= BI1.CurrentPrice)
            {
                controller.ChargeUser(BI1.CurrentPrice);
                view.SetLabelText(user.Points);

                //ScoreLabel.Content = user.Points;
                controller.IncreaseUserAdditionSpeed(BI1.SpeedOfAddingPoints);
                controller.UpgradeBasicImprovement(0);
                view.SetButtonText(BI1.CurrentPrice, 0);             
            }
        }

        private void Improvement2Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI2.CurrentPrice)
            {
                controller.ChargeUser(BI2.CurrentPrice);
                view.SetLabelText(user.Points);

                //ScoreLabel.Content = user.Points;
                controller.IncreaseUserAdditionSpeed(BI2.SpeedOfAddingPoints);
                controller.UpgradeBasicImprovement(1);
                view.SetButtonText(BI2.CurrentPrice, 1);
            }
        }

        private void Improvement3Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI3.CurrentPrice)
            {
                controller.ChargeUser(BI3.CurrentPrice);
                view.SetLabelText(user.Points);

                //ScoreLabel.Content = user.Points;
                controller.IncreaseUserAdditionSpeed(BI3.SpeedOfAddingPoints);
                controller.UpgradeBasicImprovement(2);
                view.SetButtonText(BI3.CurrentPrice, 2);
            }
        }

        private void Improvement4Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI4.CurrentPrice)
            {
                controller.ChargeUser(BI4.CurrentPrice);
                view.SetLabelText(user.Points);

                //ScoreLabel.Content = user.Points;
                controller.IncreaseUserAdditionSpeed(BI4.SpeedOfAddingPoints);
                controller.UpgradeBasicImprovement(3);
                view.SetButtonText(BI4.CurrentPrice, 3);
            }
        }

        private void Improvement5Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI5.CurrentPrice)
            {
                controller.ChargeUser(BI5.CurrentPrice);
                view.SetLabelText(user.Points);

                //ScoreLabel.Content = user.Points;
                controller.IncreaseUserAdditionSpeed(BI5.SpeedOfAddingPoints);
                controller.UpgradeBasicImprovement(4);
                view.SetButtonText(BI5.CurrentPrice, 4);
            }
        }

        private void Improvement6Button_Click(object sender, RoutedEventArgs e)
        {
            if (user.Points >= BI6.CurrentPrice)
            {
                controller.ChargeUser(BI6.CurrentPrice);
                view.SetLabelText(user.Points);

                //ScoreLabel.Content = user.Points;
                controller.IncreaseUserAdditionSpeed(BI6.SpeedOfAddingPoints);
                controller.UpgradeBasicImprovement(5);
                view.SetButtonText(BI6.CurrentPrice, 5);
            }

        }
    }
}
