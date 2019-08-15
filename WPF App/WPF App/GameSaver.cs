using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_App.Controller;

namespace WPF_App
{
    class GameSaver
    {
        private double score = 0;
        private int basicImprovement1Level = 0;
        private int basicImprovement2Level = 0;
        private int basicImprovement3Level = 0;
        private int basicImprovement4Level = 0;
        private int basicImprovement5Level = 0;
        private int basicImprovement6Level = 0;
        private int bonusImprovement1Level = 0;
        private int bonusImprovement2Level = 0;
        private string dataToSave;

        private void mergeData()
        {
            dataToSave =
              basicImprovement1Level + " "
            + basicImprovement2Level + " "
            + basicImprovement3Level + " "
            + basicImprovement4Level + " "
            + basicImprovement5Level + " "
            + basicImprovement6Level + " "
            + bonusImprovement1Level + " "
            + bonusImprovement2Level + " "
            + score;
        }
        public void SaveData(UserController c)
        {
            this.basicImprovement1Level = c.BasicImprovements[0].NumberOfUpgrades;
            this.basicImprovement2Level = c.BasicImprovements[1].NumberOfUpgrades;
            this.basicImprovement3Level = c.BasicImprovements[2].NumberOfUpgrades;
            this.basicImprovement4Level = c.BasicImprovements[3].NumberOfUpgrades;
            this.basicImprovement5Level = c.BasicImprovements[4].NumberOfUpgrades;
            this.basicImprovement6Level = c.BasicImprovements[5].NumberOfUpgrades;
            this.bonusImprovement1Level = c.DoubleClicker.NumberOfUpgrades;
            this.bonusImprovement2Level = c.DoublePointer.NumberOfUpgrades;
            this.score = c.User.Points;

            mergeData();
            System.IO.File.WriteAllText("../../save.txt", dataToSave); 
        }

        public string[] LoadData(string path) // ../../save.txt
        {
            if(System.IO.File.Exists(path))
            {
                string gameData = System.IO.File.ReadAllText(path);
                if (gameData != null)
                {
                    string[] words = gameData.Split(' ');
                    return words;
                }
            }
            return null;
        }

        public void LoadScoreAndImprovements(UserController c)
        {
            string[] gameData = LoadData("../../save.txt");
            if(gameData != null && gameData.Length == 9)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < int.Parse(gameData[i]); j++)
                    {
                        c.upgradeImprovement(i);
                    }
                }
                // double clicker
                for (int i = 0; i < int.Parse(gameData[6]); i++)
                {
                    c.UpgradeDoubleClicker();
                }
                // double pointer
                for (int i = 0; i < int.Parse(gameData[7]); i++)
                {
                    c.UpgradeDoublePointer();
                }
                // score
                c.User.Points = double.Parse(gameData[8]);
            }
        }
    }
}
