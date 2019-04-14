using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_App.Model;

namespace WPF_App.Controller
{
    public class MyController
    {
        private User _user = new User();
        private BasicImprovement _basicImprovement = new BasicImprovement();

        public User User { get => _user; set => _user = value; }
        public BasicImprovement BasicImprovement { get => _basicImprovement; set => _basicImprovement = value; }

        // CONSTRUCTOR
        public MyController()
        {

        }
        public MyController(BasicImprovement basicImprovement) => BasicImprovement = basicImprovement;
    }
}
