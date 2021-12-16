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
    /// <summary>
    /// This form is a display of the game
    /// menu with the ability to start the game
    /// </summary>
    public partial class MenuScreen : Form
    { 
     /// <summary>
     /// Form constructor
     /// </summary>
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MVtStat_Click(object sender, EventArgs e)
        {
            this.Hide();
         
             _= new MainGameScreen();
        }
    }
}
