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
        public ShipModulesMenu(MainGameScreen screen)
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
    }
}
