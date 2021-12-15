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

            if (Fight()) 
            {
                CollectReward();
                WorldData.WinsCounter++;
                MessageBox.Show("Win! Reward : 1000 ore, 100 MVt", "Win", MessageBoxButtons.OK);
                Screen.Dispose();
            } 
            else 
            {
                MessageBox.Show("Losing! End of a game.", "Losing", MessageBoxButtons.OK);
                Application.Exit();
            }
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
        public bool Fight()
        {
            while (true)
            {
                if (!EnemyAttack()) { return false; }
                Thread.Sleep(3000);
                if (ShipAttack()) { return true; }
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
            if (Enemy.Strength <= 0) { return true; }
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
            if (WorldData.Spaceship.Strength <= 0) { return false; }
            return true;
        }

    }
}
