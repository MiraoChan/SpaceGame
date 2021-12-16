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
    public partial class MenuScreen : Form
    {
        public Label MainLabel { get {return mainLabel; } set {mainLabel=value; } }
        public Button StartButton { get { return startButton; } set { startButton = value; } }
        public Button ExitButton  { get { return exitButton; } set { exitButton = value; } }
        
        public MenuScreen()
        {
            InitializeComponent();

            new FontInstaller().SetMenuFont(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MVtStat_Click(object sender, EventArgs e)
        {
            this.Hide();
          //var gameScreen = 
                new MainGameScreen();
        }
    }
}
