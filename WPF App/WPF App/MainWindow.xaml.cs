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
        BasicImprovement BI1 = new BasicImprovement(15, 0.1, 0); // MODEL
        MyView view = new MyView(); // VIEW
        MyController controller = new MyController(); // CONTROLLER

        public MainWindow()
        {
            InitializeComponent();
            controller.LinkView(view);
            view.AddLabel(ScoreLabel);
            view.AddButton(Improvement1Button);
            view.SetButtonText(15);
            controller.AddBasicImprovement(BI1);
            controller.AddUser(user);
            //ConnSQL database = new ConnSQL();
            //database.Connection();

        }

        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPointsToUser(1);
            view.SetLabelText(user.Points);
        }
        private void Improvement1Button_Click(object sender, RoutedEventArgs e)
        {
            if(user.Points >= BI1.CurrentPrice && user.Level >= BI1.LevelRequired)
            {
                controller.ChargeUser(BI1.CurrentPrice);
                view.SetLabelText(user.Points);

                //ScoreLabel.Content = user.Points;
                controller.IncreaseUserAdditionSpeed(BI1.SpeedOfAddingPoints);
                controller.UpgradeBasicImprovement();
                view.SetButtonText(BI1.CurrentPrice);             
            }
        }
    }
}
