using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App.Model
{
    public class User
    {
        private static int _points;
        private static int _speedOfAddingPoints;
        private static int _level;

        public int Points { get => _points; set => _points = value; }
        public int SpeedOfAddingPoints { get => _speedOfAddingPoints; set => _speedOfAddingPoints = value; }
        public int Level { get => _level; set => _level = value; }

        // CONSTRUCTORS 
        public User()
        {

        }
        public User(int lvl) => Level = lvl;
        // METHODS

    }
}
