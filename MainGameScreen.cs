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
        public void SetMoneyStat(int val) 
        {
            moneyStat.Text = SetValue(moneyStat.Text, val);
            moneyStat.Refresh();
            this.Show();
        }
        public void SetOreStat(int val)
        {
            oreStat.Text = SetValue(oreStat.Text, val);
            this.Show();
        }
        public void SetMVtStat(int val)
        {
            mVtStat.Text = SetValue(mVtStat.Text, val);
            this.Show();
        }
        public void SetDamageStat(int val)
        {
            damageStat.Text = SetValue(damageStat.Text, val);
            this.Show();
        }
        public void SetStrengthStat(int curStrenght,int maxStrenght)
        {
            strengthStat.Text = SetValue(strengthStat.Text, curStrenght, maxStrenght);
            this.Show();
        }      
        private string SetValue(string str,int val) 
        { 
            string[] subStr = str.Split(':');
            string newStr = subStr[0] + val;
            return newStr;
        }
        private string SetValue(string str, int val,int val1)
        {
            string[] subStr = str.Split(':');
            string newStr = subStr[0] + val+"/"+val1;
            return newStr;
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
         
           // this.Show();
            Console.WriteLine("");


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        
       
    }
}
