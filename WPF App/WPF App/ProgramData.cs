using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_App.Controller;
using WPF_App.Model;
using WPF_App.View;

namespace WPF_App
{
    class ProgramData
    {
        User user = new User(); // MODEL
        BasicImprovement BI1 = new BasicImprovement(15, 0.1); // MODEL
        BasicImprovement BI2 = new BasicImprovement(100, 1); // MODEL
        BasicImprovement BI3 = new BasicImprovement(1100, 8); // MODEL
        BasicImprovement BI4 = new BasicImprovement(12000, 47); // MODEL
        BasicImprovement BI5 = new BasicImprovement(130000, 260); // MODEL
        BasicImprovement BI6 = new BasicImprovement(1400000, 1400); // MODEL
        public ProgramData()
        {

        }
        public void SendData(UserController c, MyView v)
        {
            // link
            c.LinkView(v);
            // main click
            c.AddBasicImprovements(BI1, BI2, BI3, BI4, BI5, BI6);
            //
            c.AddUser(user);
        }
    }
}
