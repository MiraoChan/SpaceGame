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
    public partial class OrbitalStationMenu : Form
    {
        #region Properties
        public MainGameScreen Screen { get; set; }
        public TextBox EnergyAmount { get { return energyAmount; } set { energyAmount = value; } }
        public TextBox OreAmount { get { return oreAmount; } set { oreAmount = value; } }

        #endregion
        public OrbitalStationMenu(MainGameScreen screen)
        {
            Screen = screen;
            InitializeComponent();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
