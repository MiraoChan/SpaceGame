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
    /// <summary>
    /// the class characterizes the event of a sudden battle with
    /// the enemy when collecting ore from the planet.
    /// It also logs all battle events into a separate file
    /// </summary>
    public class FightEvent
    {
        /// <summary>
        /// Created enemy
        /// </summary>
        public Enemy Enemy { get; set; }
        /// <summary>
        /// Result of the fight(lose\win)
        /// </summary>
        public bool FightResult { get; set; }
        /// <summary>
        /// GUI of a fight
        /// </summary>
        public FightScreen Screen { get; set; }

        /// <summary>
        /// Contains all the logic of the passage of the battle. 
        /// If you win, it provides a reward, if you lose, it ends the game 
        /// </summary>
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
            //Creates a new log file.
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

        /// <summary>
        /// Loggs an attack of an object.
        /// </summary>
        /// <param name="fighter">Who fight</param>
        /// <param name="damage">damage done</param>
        /// <param name="writer">TextWriter</param>
        public void LogFight(string fighter,string damage, TextWriter writer)
        {
            writer.WriteLine(fighter+" attack -> ");
            writer.WriteLine($"Damage : "+damage);
            writer.WriteLine($"SpaceShip strenght:  {WorldData.Spaceship.Strength}/{WorldData.Spaceship.MaxStrength}");
            writer.WriteLine($"Enemy strenght  : {this.Enemy.Strength}/{this.Enemy.MaxStrength}");
            writer.WriteLine("---------------");
        }
        /// <summary>
        /// Loggs a step of a fight.
        /// </summary>
        /// <param name="str">Step name</param>
        /// <param name="writer">TextWriter</param>
        public void Log(string str, TextWriter writer)
        {
            writer.Write(str);
            writer.WriteLine($"SpaceShip strenght:  {WorldData.Spaceship.Strength}/{WorldData.Spaceship.MaxStrength}");
            writer.WriteLine($"SpaceShip damage:  {WorldData.Spaceship.Damage}");
            writer.WriteLine($"Enemy strenght  : {this.Enemy.Strength}/{this.Enemy.MaxStrength}");
            writer.WriteLine($"Enemy damage:  {this.Enemy.Damage}");
            writer.WriteLine("---------------");
        }
        /// <summary>
        /// Adds a reward due to fight result 
        /// </summary>
        public void CollectReward() 
        {

            if (WorldData.Spaceship.Ore + 1000 <= WorldData.Spaceship.OreLimit)
            {
                WorldData.Spaceship.Ore += 1000;
            }
            
            else  //Not enough space for collect ore
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
        /// <summary>
        /// Main fight loop.Works with GUI and fight data simultaneously.
        /// Pirates always attackes first.
        /// </summary>
        /// <param name="writer">StreamWriter</param>
        /// <returns>result of a fight.</returns>
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
        /// <summary>
        /// Ship attack action. 
        /// Lowers the opponent's health
        /// </summary>
        /// <returns>true if enemy is dead
        /// false if he's still alive </returns>
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
        /// <summary>
        /// Enemy attack action. 
        /// Lowers the opponent's health
        /// </summary>
        /// <returns>true if ship is alive
        /// false if he's dead </returns>
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
