using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App
{
    class GameSaver
    {
        private double score = 0;
        private double pointsPerSecond = 0;
        private int basicImprovement1Level = 0;
        private int basicImprovement2Level = 0;
        private int basicImprovement3Level = 0;
        private int basicImprovement4Level = 0;
        private int basicImprovement5Level = 0;
        private int basicImprovement6Level = 0;
        private int bonusImprovement1Level = 0;
        private int bonusImprovement2Level = 0;

        public void sendBasicData(double score, double pointsPerSecond)
        {
            this.score = score;
            this.pointsPerSecond = pointsPerSecond;
        }
        public void sendImprovementsData(int lvl1, int lvl2, int lvl3, int lvl4, int lvl5, int lvl6,
            int bonuslvl1, int bonuslvl2)
        {
            this.basicImprovement1Level = lvl1;
            this.basicImprovement2Level = lvl2;
            this.basicImprovement3Level = lvl3;
            this.basicImprovement4Level = lvl4;
            this.basicImprovement5Level = lvl5;
            this.basicImprovement6Level = lvl6;
            this.bonusImprovement1Level = bonuslvl1;
            this.bonusImprovement2Level = bonuslvl2;
        }
        public void SaveData(string path) // save.txt
        {
            string data = score + " "
                + pointsPerSecond + " "
                + basicImprovement1Level + " "
                + basicImprovement2Level + " "
                + basicImprovement3Level + " "
                + basicImprovement4Level + " "
                + basicImprovement5Level + " "
                + basicImprovement6Level + " "
                + bonusImprovement1Level + " "
                + bonusImprovement2Level + " ";

            System.IO.File.WriteAllText(path, data);
        }
    }
}
