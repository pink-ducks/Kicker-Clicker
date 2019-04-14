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
using WPF_App.Model;

namespace WPF_App
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User testuser = new User();
        public MainWindow()
        {
            InitializeComponent();
            //ConnSQL database = new ConnSQL();
            //database.Connection();
        }

        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            ScoreLabel.Content =++testuser.Points;
        }
    }
}
