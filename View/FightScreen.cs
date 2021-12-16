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
    /// <summary>
    /// This form is a display of the processes
    /// of the battle between the player and the pirate
    /// </summary>
    public partial class FightScreen : Form
    {
        /// <summary>
        /// Pirate attack display
        /// </summary>
        public PictureBox PirateAttack { get { return pirateAttack; }set { pirateAttack = value; } }
        /// <summary>
        /// Ship attack display
        /// </summary>
        public PictureBox ShipAttack { get { return shipAttack; } set { shipAttack = value; } }
        /// <summary>
        /// Value of Ship strength
        /// </summary>
        public ProgressBar ShipStrength { get { return shipStrength; } set { shipStrength = value; } }
        /// <summary>
        /// Value of Enemy strength
        /// </summary>
        public ProgressBar EnemyStrength { get { return enemyStrength; } set { enemyStrength = value; } }
        /// <summary>
        /// Constructor of a form.
        /// </summary>
        public FightScreen()
        {
            InitializeComponent();
        }
    }
}
