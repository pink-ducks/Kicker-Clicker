using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App.Model
{
    public class User
    {
        private static int points;
        private static int speedOfAddingPoints;
        private static int level;

        public int Points { get => points; set => points = value; }
        public int SpeedOfAddingPoints { get => speedOfAddingPoints; set => speedOfAddingPoints = value; }
        public int Level { get => level; set => level = value; }

        // CONSTRUCTORS 
        public User()
        {

        }
        public User(int lvl) => Level = lvl;
        // METHODS

    }
}
