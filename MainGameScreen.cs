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
        public FlowLayoutPanel GetMainMapPanel() { return MainMapPanel; }

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
    }
}
