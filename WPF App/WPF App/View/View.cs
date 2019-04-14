using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPF_App.Model;
using WPF_App;

namespace WPF_App.View
{
    public class MyView
    {
        Button button = new Button();
        Label label = new Label();
        User user = new User();
        public Button Button { get => button; set => button = value; }
        public Label Label { get => label; set => label = value; }
        public User User { get => user; set => user = value; }

        // CONSTRUCTORS
        public MyView()
        {

        }
        // METHODS
        public void AddButton(Button button) => Button = button;
        public void AddLabel(Label label) => Label = label;
        public void LinkWithUser(User user) => User = user;

        public void SetButtonText(int price) => Button.Content = price;
        public void SetLabelText(double points)
        {
            if (User.Points < 10000)
            {
                const int Digits = 2;
                label.Content = Math.Round(points, Digits);
            }
            else
            {
                label.Content = points;
            }

        }
    }
}
