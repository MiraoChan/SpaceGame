using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlariumArcade
{
    public partial class MainGameScreen : Form
    {

        private void exitButton_Click(object sender, EventArgs e)
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