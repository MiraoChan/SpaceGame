using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.ViewModel.Initialization;

namespace PlariumArcade
{
    public partial class MainGameScreen : Form
    {

        #region Properties
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
        }
        public void SetOreStat(int val)
        {
            oreStat.Text = SetValue(oreStat.Text, val);
        }
        public void SetMVtStat(int val)
        {
            mVtStat.Text = SetValue(mVtStat.Text, val);
        }
        public void SetDamageStat(int val)
        {
            damageStat.Text = SetValue(damageStat.Text, val);
        }
        public void SetStrengthStat(int val)
        {
            strengthStat.Text = SetValue(strengthStat.Text, val);
        }      
        private string SetValue(string str,int val) 
        { 
            string[] subStr = str.Split(':');
            string newStr = subStr[0] + val;
            return newStr;
        }
        #endregion


        public MainGameScreen()
        {                 
            InitializeComponent();
            new FontInstaller().SetGameScreenFont(this);
            this.Show();
            new Initialization(this);
        }

        

       
    }
}
