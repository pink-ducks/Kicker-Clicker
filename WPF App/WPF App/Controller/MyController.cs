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
        // METHODS
        public void AddBasicImprovement(BasicImprovement basicImprovement) => BasicImprovement = basicImprovement;
        public void AddUser(User user) => User = user;
        public void ChargeUser(double points) => User.Points -= points;
        public void AddPointsToUser(double points) => User.Points += points;
        public void IncreaseUserAdditionSpeed(double speed) => User.SpeedOfAddingPoints += speed;
        public void UpgradeBasicImprovement()
        {
            BasicImprovement.Upgrade();
        }
    }
}
