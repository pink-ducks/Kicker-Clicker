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
        User user = new User();
        public MainWindow()
        {
            InitializeComponent();
            MyView view = new MyView(Improvement1Button); // VIEW
            view.SetStartingPrice(15);

            BasicImprovement BI1 = new BasicImprovement(15, 0.1, 0); // MODEL
            MyController controller = new MyController(BI1); // CONTROLLER

            //ConnSQL database = new ConnSQL();
            //database.Connection();
        }

        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            ScoreLabel.Content =++user.Points;
        }
        private void Improvement1Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
