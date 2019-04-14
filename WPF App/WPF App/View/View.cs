using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPF_App.Model;

namespace WPF_App.View
{
    public class MyView
    {
        Button button = new Button();
        public Button Button { get => button; set => button = value; }

        // CONSTRUCTORS
        public MyView(Button button) => Button = button;
        // METHODS
        public void SetStartingPrice(int price)
        {
            Button.Content = price;
        }
    }
}
