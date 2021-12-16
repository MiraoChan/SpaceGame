using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.Actions;
using PlariumArcade.ViewModel.Events;

namespace PlariumArcade
{
    public partial class OrbitalStationMenu : Form
    {
        #region Properties
        public MainGameScreen Screen { get; set; }
        public TextBox EnergyAmount { get { return energyAmount; } set { energyAmount = value; } }
        public TextBox OreAmount { get { return oreAmount; } set { oreAmount = value; } }
        public bool Delivery { get; set; }

        #endregion
        public OrbitalStationMenu(MainGameScreen screen,bool delivery)
        {
            Delivery = delivery;
            Screen = screen;
            Screen.Enabled = false;
            InitializeComponent();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Screen.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
         
            if (new ActionController().BuyEnergy(energyAmount.Text, Delivery))
            {
                MessageBox.Show("Purchase was successful.", "Buy energy", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Purchase was failed.", "Buy energy", MessageBoxButtons.OK);
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (new ActionController().SellOre(oreAmount.Text, Delivery))
            {
                MessageBox.Show("Sale was successful.", "Sell ore", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Sale was failed.", "Sell ore", MessageBoxButtons.OK);
            }
        }
    }
}
