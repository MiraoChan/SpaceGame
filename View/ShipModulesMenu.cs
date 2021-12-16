using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.DB;
using PlariumArcade.ViewModel.Events;
using PlariumArcade.ViewModel.GraphicControllers;
using PlariumArcade.ViewModel.Initialization;

namespace PlariumArcade
{
    public partial class ShipModulesMenu : Form
    {
        public MainGameScreen Screen { get; set; }
        public GameController Controller { get; set; }

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
            Strength.Text ="Strength : "+ val+"/"+val1;
            Strength.Refresh();
       
        }
        public void SetDamage(int val)
        {
            Damage.Text ="Damage : " + val;
            Damage.Refresh();

        }
        public void SetEnergy(int val, int val1)
        {
            Energy.Text = " Energy : " + val + "/" + val1;
            Energy.Refresh();

        }
        public void SetOre(int val, int val1)
        {
            Ore.Text = "Ore : " + val + "/" + val1; 
            Ore.Refresh();

        }
        public void SetCollectVolume(int val)
        {
            CollectVolume.Text = "Collect volume : " + val ;
            CollectVolume.Refresh();

        }
        public void SetFramesLimit(int val)
        {
            FramesLimit.Text = "Frames limit : " + val;
            FramesLimit.Refresh();

        }
        public void SetAmountOrePer1MBt(int val)
        {
            AmountOrePer1MBt.Text = "Amount ore per 1 MBt : " + val;
            AmountOrePer1MBt.Refresh();

        }
        public void SetConsumePerFight(int val)
        {
            ConsumePerFight.Text = "Consume per fight : " + val;
            ConsumePerFight.Refresh();

        }
        public void SetConsumePer100km(int val)
        {
            ConsumePer100km.Text = "Consume per 100 km : " + val;
            ConsumePer100km.Refresh();

        }
        public void SetAmountMBtPer100km(int val)
        {
            AmountMBtPer100km.Text = "Amount MBt per 100 km : " + val;
            AmountMBtPer100km.Refresh();

        }
        public void SetEfficiency(int val)
        {
            Efficiency.Text = "Efficiency : " + val;
            Efficiency.Refresh();

        }

        #endregion

        public ShipModulesMenu(MainGameScreen screen, GameController controller)
        {
            Controller = controller;
            Screen = screen;
            InitializeComponent();
            this.Hide();
        }
        private void Exit_Click(object sender, EventArgs e)
        {         
            this.Hide();
        }
    
    }
}
