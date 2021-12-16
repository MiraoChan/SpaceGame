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
    public partial class FightScreen : Form
    {
        public PictureBox PirateAttack { get { return pirateAttack; }set { pirateAttack = value; } }
        public PictureBox ShipAttack { get { return shipAttack; } set { shipAttack = value; } }
        public ProgressBar ShipStrength { get { return shipStrength; } set { shipStrength = value; } }
        public ProgressBar EnemyStrength { get { return enemyStrength; } set { enemyStrength = value; } }
        public FightScreen()
        {
            InitializeComponent();
        }
    }
}
