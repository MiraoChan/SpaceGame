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
    /// <summary>
    /// This form is a display of the operation of the 
    /// orbital station with the ability to buy / sell resources
    /// </summary>
    public partial class OrbitalStationMenu : Form
    {
        #region Properties
        /// <summary>
        /// Current game screen
        /// </summary>
        public MainGameScreen Screen { get; set; }
        /// <summary>
        /// Energy input field
        /// </summary>
        public TextBox EnergyAmount { get { return energyAmount; } set { energyAmount = value; } }
        /// <summary>
        /// Ore input field
        /// </summary>
        public TextBox OreAmount { get { return oreAmount; } set { oreAmount = value; } }
        /// <summary>
        /// Local flag for delivery
        /// </summary>
        public bool Delivery { get; set; }

        #endregion
        /// <summary>
        /// Constrictor.Initializes its components
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws if screen is null</exception>
        /// <param name="screen">current screen</param>
        /// <param name="delivery">delivery flag</param>
        public OrbitalStationMenu(MainGameScreen screen,bool delivery)
        {
            Delivery = delivery;
            Screen = screen ?? throw new System.ArgumentNullException(nameof(screen));
            Screen.Enabled = false;
            InitializeComponent();
            this.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Screen.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void BuyButton_Click(object sender, EventArgs e)
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

        private void SellButton_Click(object sender, EventArgs e)
        {
            if (new ActionController().SellOre(oreAmount.Text))
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
