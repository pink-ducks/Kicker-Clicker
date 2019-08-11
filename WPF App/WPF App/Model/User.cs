using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App.Model
{
    public class User
    {
        private static double _points;
        private static double _pointsPerClick = 1;
        private static double _speedOfAddingPoints;

        public double Points { get => _points; set => _points = value; }
        public double PointsPerClick { get => _pointsPerClick; set => _pointsPerClick = value; }
        public double SpeedOfAddingPoints { get => _speedOfAddingPoints; set => _speedOfAddingPoints = value; }
        // CONSTRUCTORS 
        public User()
        {
        }
        // METHODS

    }
}
