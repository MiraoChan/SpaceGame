using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlariumArcade
{
    public partial class MainGameScreen : Form
    {

        #region Properties
        public FlowLayoutPanel GetMainMapPanel() { return MainMapPanel; }
        public Button MoneyStat { get{ return moneyStat; } }
        public Button OreStat { get { return oreStat; } }
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
        public string SetValue(string str,int val) 
        { 
            string[] subStr = str.Split(':');
            string newStr = subStr[0] + val;
            return newStr;
        }
        #endregion


        public MainGameScreen()
        {
                  
            InitializeComponent();
            this.Show();
          
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MoveControl(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('w')) { }
            //чота делаем
        }

        private void MainMapPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
