using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.Interfaces;
using PlariumArcade.ViewModel.Initialization;

namespace PlariumArcade
{
    /// <summary>
    /// This form represents the display of 
    /// the entire main playing field with
    /// the ability to exit the game
    /// </summary>
    public partial class MainGameScreen : Form
    {

        #region Properties
        /// <summary>
        /// Main game controller
        /// </summary>
        public GameController Controller { get; set; }
        /// <summary>
        /// Cryptocurrency display
        /// </summary>
        public Button MoneyStat { get{ return moneyStat; } }
        /// <summary>
        /// Ore display
        /// </summary>
        public Button OreStat { get { return oreStat; } }
        /// <summary>
        /// MVt display
        /// </summary>
        public Button MVtStat { get { return mVtStat; } }
        /// <summary>
        /// Damage display
        /// </summary>
        public Button DamageStat { get { return damageStat; } }
        /// <summary>
        /// Strength display
        /// </summary>
        public Button StrengthStat { get { return strengthStat; } }

        #endregion

        #region ValueSetters
        /// <summary>
        /// Money display setter
        /// </summary>
        /// <param name="val">current value</param>
        public void SetMoneyStat(double val) 
        {
            moneyStat.Text = "$ : " + val;
            moneyStat.Refresh();
            this.Show();
        }
        /// <summary>
        /// Ore display setter
        /// </summary>
        /// <param name="val">currOre</param>
        /// <param name="val1">MaxOre</param>
        public void SetOreStat(int val,int val1)
        {
            oreStat.Text = "Ore : "+val+"/"+val1;           
            this.Show();
        }
        /// <summary>
        /// MVt display setter
        /// </summary>
        /// <param name="val">currenergy</param>
        /// <param name="val1">maxEnergy</param>
        public void SetMVtStat(int val, int val1)
        {
            mVtStat.Text = "MVt : " + val+"/"+val1;
            this.Show();
        }
        /// <summary>
        /// Damage display setter
        /// </summary>
        /// <param name="val">current value</param>
        public void SetDamageStat(int val)
        {
            damageStat.Text = "Damage : " + val;
            this.Show();
        }
        /// <summary>
        /// Strength display setter
        /// </summary>
        /// <param name="curStrenght">current value</param>
        ///  /// <param name="maxStrenght">max value</param>
        public void SetStrengthStat(int curStrenght,int maxStrenght)
        {
            strengthStat.Text = "Strength : " + curStrenght + "/" + maxStrenght;
            this.Show();
        }      
  
        #endregion

        #region Events
        private void MainGameScreen_KeyDown(object sender, KeyEventArgs e)
        {         
            if (e.KeyData == Keys.Left  || e.KeyData == Keys.A) { Thread.Sleep(500); Controller.EvController.GoLeft();  }
            if (e.KeyData == Keys.Right || e.KeyData == Keys.D) { Thread.Sleep(500); Controller.EvController.GoRight();  }
            if (e.KeyData == Keys.Up || e.KeyData == Keys.W) { Thread.Sleep(500); Controller.EvController.GoUp(); }
            if (e.KeyData == Keys.Down || e.KeyData == Keys.S) { Thread.Sleep(500); Controller.EvController.GoDown();  }
        }

        #endregion

        /// <summary>
        /// Controller.Initialixes all graphic screen elements.
        /// </summary>
        public MainGameScreen()
        {         
            InitializeComponent();
            Controller = new GameController(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        
       
    }
}
