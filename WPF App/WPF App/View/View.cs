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
        public Button Button { get => button; set => button = value; }
        public Label Label { get => label; set => label = value; }

        // CONSTRUCTORS
        public MyView()
        {

        }
        // METHODS
        public void AddButton(Button button) => Button = button;
        public void AddLabel(Label label) => Label = label;

        public void SetButtonText(int price) => Button.Content = price;
        public void SetLabelText(int price) => label.Content = price;
    }
}
