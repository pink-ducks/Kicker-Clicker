using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App
{
    public class User
    {
        private static int _points = 0;
        public int Points { get => _points; set => _points = value; }
        private static int _speedOfAddingPoints = 0;
        public int SpeedOfAddingPoints { get => _speedOfAddingPoints; set => _speedOfAddingPoints = value; }

        // constructor
        public User()
        {
        }
        // methods

    }
}
