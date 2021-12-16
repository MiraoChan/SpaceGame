using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using PlariumArcade.Model.DB;
using PlariumArcade.Model.Entities.BaseEntities;

namespace PlariumArcade.ViewModel.Events
{
    public class FightEvent
    {
        public Enemy Enemy { get; set; }
        public bool FightResult { get; set; }
        public FightScreen Screen { get; set; }
        public FightEvent() {

            #region initialization
            Screen = new FightScreen();
            Screen.Show();
            Enemy = new Enemy();
            Screen.ShipStrength.Maximum = WorldData.Spaceship.Strength;
            Screen.ShipStrength.Value = WorldData.Spaceship.Strength;
            Screen.EnemyStrength.Maximum = Enemy.MaxStrength;
            Screen.EnemyStrength.Value = Enemy.MaxStrength;
            Screen.Refresh();
            #endregion

            //Search for the last fight number
            int numberFight;
            string res = Directory.GetFiles("C:/Users/user/Desktop/SpaceGameRep/bin/Debug")                                 
                                  .Last(t => t.Contains("log"));       
            if (res != null)
            {
                var resInt = res.ToCharArray()
                          .Where(t => Char.IsDigit(t))
                          .Select(t => t)
                          .ToList();
                StringBuilder str = new StringBuilder();
                foreach (var i in resInt)
                {
                    str.Append(i);
                }
                numberFight=  int.Parse(str.ToString());
            }
            else 
            {
               numberFight = 0;
            }
            using (StreamWriter writer = File.AppendText("log"+ (numberFight+1) + ".txt"))
            {
                Log("Start fighting : ",writer);
                if (Fight(writer))
                {
                    CollectReward();
                    WorldData.WinsCounter++;
                    Log("End fighting : ", writer);
                    writer.Close();
                    MessageBox.Show("Win! Reward : 1000 ore, 100 MVt", "Win", MessageBoxButtons.OK);                   
                    Screen.Dispose();                 
                }
                else
                {
                    Log("End fighting : ", writer);
                    writer.Close();
                    MessageBox.Show("Losing! End of a game.", "Losing", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }

        public void LogFight(string fighter,string damage, TextWriter writer)
        {
            writer.WriteLine(fighter+" attack -> ");
            writer.WriteLine($"Damage : "+damage);
            writer.WriteLine($"SpaceShip strenght:  {WorldData.Spaceship.Strength}/{WorldData.Spaceship.MaxStrength}");
            writer.WriteLine($"Enemy strenght  : {this.Enemy.Strength}/{this.Enemy.MaxStrength}");
            writer.WriteLine("---------------");
        }
        public void Log(string str, TextWriter writer)
        {
            writer.Write(str);
            writer.WriteLine($"SpaceShip strenght:  {WorldData.Spaceship.Strength}/{WorldData.Spaceship.MaxStrength}");
            writer.WriteLine($"SpaceShip damage:  {WorldData.Spaceship.Damage}");
            writer.WriteLine($"Enemy strenght  : {this.Enemy.Strength}/{this.Enemy.MaxStrength}");
            writer.WriteLine($"Enemy damage:  {this.Enemy.Damage}");
            writer.WriteLine("---------------");
        }
        public void CollectReward() 
        {

            if (WorldData.Spaceship.Ore + 1000 <= WorldData.Spaceship.OreLimit)
            {
                WorldData.Spaceship.Ore += 1000;
            }
            else
            {
                WorldData.Spaceship.Ore += WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore;
            }
            if (WorldData.Spaceship.Energy + 100 <= WorldData.Spaceship.LimitEnergy)
            {
                WorldData.Spaceship.Energy += 100;
            }
            else
            {
                WorldData.Spaceship.Energy += WorldData.Spaceship.LimitEnergy - WorldData.Spaceship.Energy;
            }
        }
        public bool Fight(StreamWriter writer)
        {
            while (true)
            {
                if (!EnemyAttack()) { LogFight("Enemy",this.Enemy.Damage.ToString(),writer); return false; }
                LogFight("Enemy", this.Enemy.Damage.ToString(), writer);
                Thread.Sleep(3000);
                if (ShipAttack()) { LogFight("Ship", WorldData.Spaceship.Damage.ToString(), writer); return true; }
                LogFight("Ship", WorldData.Spaceship.Damage.ToString(), writer);
                Thread.Sleep(3000);
            }
         }
        public bool ShipAttack() {
            Screen.PirateAttack.Hide();
            Screen.ShipAttack.Show();
            Screen.Focus();
            Screen.Refresh();
            Enemy.Strength -= WorldData.Spaceship.Damage;
            if (Enemy.Strength <= 0)
            {
                Screen.EnemyStrength.Value = 0;
            }
            else
            {
                Screen.EnemyStrength.Value = Enemy.Strength;
            }
            Screen.Refresh();
            if (Enemy.Strength <= 0)return true;
            return false;
        }
        public bool EnemyAttack()
        {
            Screen.PirateAttack.Show();
            Screen.ShipAttack.Hide();
            Screen.Refresh();
            WorldData.Spaceship.Strength -= Enemy.Damage;
            if (WorldData.Spaceship.Strength <= 0)
            {
                Screen.ShipStrength.Value = 0;
            }
            else
            {
                Screen.ShipStrength.Value = WorldData.Spaceship.Strength;
            }
            Screen.Refresh();
            if (WorldData.Spaceship.Strength <= 0)return false; 
            return true;
        }

    }
}
