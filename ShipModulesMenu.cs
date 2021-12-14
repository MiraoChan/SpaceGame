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
    public partial class ShipModulesMenu : Form
    {
        public MainGameScreen Screen { get; set; }
        #region Properties
        public Button Strength { get { return strength; } }
        public Button Damage { get { return damage; } }
        public Button Energy { get { return energy; } }
        public Button Ore { get { return ore; } }
        public Button CollectVolume { get { return collectVolume; } }
        public Button FramesLimit { get { return framesLimit; } }
        public Button AmountOrePer1MBt { get { return amountOrePer1MBt; } }
        public Button ConsumePerFight { get { return consumePerFight; } }
        public Button ConsumePer100km { get { return consumePer100km; } }
        public Button AmountMBtPer100km { get { return amountMBtPer100km; } }
        public Button Efficiency { get { return efficiency; } }

        #endregion
        #region valueSetters

        public void SetStrength(int val, int val1)
        {
            Strength.Text = SetValue(Strength.Text, val,val1);
            Strength.Refresh();
       
        }
        public void SetDamage(int val)
        {
            Damage.Text = SetValue(Damage.Text, val);
            Damage.Refresh();

        }
        public void SetEnergy(int val, int val1)
        {
            Energy.Text = SetValue(Energy.Text, val,val1);
            Energy.Refresh();

        }
        public void SetOre(int val, int val1)
        {
            Ore.Text = SetValue(Ore.Text, val,val1);
            Ore.Refresh();

        }
        public void SetCollectVolume(int val)
        {
            CollectVolume.Text = SetValue(CollectVolume.Text, val);
            CollectVolume.Refresh();

        }
        public void SetFramesLimit(int val)
        {
            FramesLimit.Text = SetValue(FramesLimit.Text, val);
            FramesLimit.Refresh();

        }
        public void SetAmountOrePer1MBt(int val)
        {
            AmountOrePer1MBt.Text = SetValue(AmountOrePer1MBt.Text, val);
            AmountOrePer1MBt.Refresh();

        }
        public void SetConsumePerFight(int val)
        {
            ConsumePerFight.Text = SetValue(ConsumePerFight.Text, val);
            ConsumePerFight.Refresh();

        }
        public void SetConsumePer100km(int val)
        {
            ConsumePer100km.Text = SetValue(ConsumePer100km.Text, val);
            ConsumePer100km.Refresh();

        }
        public void SetAmountMBtPer100km(int val)
        {
            AmountMBtPer100km.Text = SetValue(AmountMBtPer100km.Text, val);
            AmountMBtPer100km.Refresh();

        }
        public void SetEfficiency(int val)
        {
            Efficiency.Text = SetValue(Efficiency.Text, val);
            Efficiency.Refresh();

        }

        private string SetValue(string str, int val)
        {
            string[] subStr = str.Split(':');
            string newStr = subStr[0] + val;
            return newStr;
        }
        private string SetValue(string str, int val, int val1)
        {
            string[] subStr = str.Split(':');
            string newStr = subStr[0] + val + "/" + val1;
            return newStr;
        }

        #endregion

        public ShipModulesMenu(MainGameScreen screen)
        {
            Screen = screen;
            InitializeComponent();
            this.Hide();
        }



        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
