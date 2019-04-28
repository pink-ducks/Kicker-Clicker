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
        List<Button> buttons = new List<Button>();
        Label label = new Label();
        User user = new User();
        public Label Label { get => label; set => label = value; }
        public User User { get => user; set => user = value; }
        public List<Button> Buttons { get => buttons; set => buttons = value; }

        // CONSTRUCTORS
        public MyView()
        {

        }
        // METHODS
        public void AddButton(Button button) => buttons.Add(button);
        public void AddLabel(Label label) => Label = label;
        public void LinkWithUser(User user) => User = user;

        public void SetButtonText(int price, int index)
        {
            buttons[index].Content = price;
        }

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
