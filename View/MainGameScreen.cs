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
    public partial class MainGameScreen : Form
    {

        #region Properties
        public GameController Controller { get; set; }

        public FlowLayoutPanel GetMainMapPanel() { return MainMapPanel; }
        public Button MoneyStat { get{ return moneyStat; } }
        public Button OreStat { get { return oreStat; } }
        public Button MVtStat { get { return mVtStat; } }
        public Button DamageStat { get { return damageStat; } }
        public Button StrengthStat { get { return strengthStat; } }
        public Button ExitButton { get { return exitButton; } }
        #endregion

        #region ValueSetters
        public void SetMoneyStat(double val) 
        {
            moneyStat.Text = "$ : " + val;
            moneyStat.Refresh();
            this.Show();
        }
        public void SetOreStat(int val,int val1)
        {
            oreStat.Text = "Ore : "+val+"/"+val1;           
            this.Show();
        }
        public void SetMVtStat(int val, int val1)
        {
            mVtStat.Text = "MVt : " + val+"/"+val1;
            this.Show();
        }
        public void SetDamageStat(int val)
        {
            damageStat.Text = "Damage : " + val;
            this.Show();
        }
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
