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
        ProgramData models = new ProgramData(); // ALL THE MODELS
        MyView view = new MyView(); // VIEW
        UserController controller = new UserController(); // CONTROLLER
        public MainWindow()
        {
            InitializeComponent();
            models.SendData(controller, view);
            SendViewData(view);
            controller.UploadSavedData();
        }
        // Main Click Button
        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            controller.ClickButton();
            ClickPointAddLabel.Margin = new Thickness(rnd.Next(0, 150), rnd.Next(0, 150), rnd.Next(0, 150), rnd.Next(0, 150));
        }
        private void ClickPointAddLabel_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickButton();
        }
        // Improvements
        private void Improvement1Button_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickBasicImprovement(0);
        }

        private void Improvement2Button_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickBasicImprovement(1);
        }

        private void Improvement3Button_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickBasicImprovement(2);
        }

        private void Improvement4Button_Click(object sender, RoutedEventArgs e)
        {
        
            controller.ClickBasicImprovement(3);
        }

        private void Improvement5Button_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickBasicImprovement(4);
        }

        private void Improvement6Button_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickBasicImprovement(5);
        }
        private void BonusImprovement1Button_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickDoubleClicker();
        }
        private void BonusImprovement2Button_Click(object sender, RoutedEventArgs e)
        {
            controller.ClickDoublePointer();
        }
        private void SendViewData(MyView v)
        {
            v.AddLabel(ScoreLabel);
            v.AddSpeedOfAddingPointsLabel(SpeedOfAddingPointsLabel);
            v.AddClickPointAddLabel(ClickPointAddLabel);
            // improvmenets
            v.AddButtons(Improvement1Button, Improvement2Button, Improvement3Button, Improvement4Button, Improvement5Button, Improvement6Button);
            v.AddImprovementsLevelsLabels(Improvement1Label, Improvement2Label, Improvement3Label, Improvement4Label, Improvement5Label, Improvement6Label, DoubleClickerLabel, DoublePointerLabel);
            v.AddInfoLabels(Info1Label, Info2Label, Info3Label, Info4Label, Info5Label, Info6Label);
            v.AddImprovementImages(improvement1Image, improvement2Image, improvement3Image, improvement4Image, improvement5Image, improvement6Image);
            v.SetButtonsTexts(controller.BasicImprovements[0].StartingPrice,
                controller.BasicImprovements[1].StartingPrice,
                controller.BasicImprovements[2].StartingPrice,
                controller.BasicImprovements[3].StartingPrice,
                controller.BasicImprovements[4].StartingPrice,
                controller.BasicImprovements[5].StartingPrice);
            // double clicker + double pointer
            v.AddButtons(BonusImprovement1Button);
            v.AddButtons(BonusImprovement2Button);
        }

    }
}
