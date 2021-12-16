using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.DB;
using PlariumArcade.ViewModel.Events;
using PlariumArcade.ViewModel.GraphicControllers;
using PlariumArcade.ViewModel.Initialization;

namespace PlariumArcade
{
    /// <summary>
    /// This form is a display of the interior of the ship
    /// with a representation of the location of the modules
    /// and all characteristics
    /// </summary>
    public partial class ShipModulesMenu : Form
    {
        /// <summary>
        /// Current screen
        /// </summary>
        public MainGameScreen Screen { get; set; }
        /// <summary>
        /// Main game controller
        /// </summary>
        public GameController Controller { get; set; }

        #region Properties
        /// <summary>
        /// Strength display
        /// </summary>
        public Button Strength { get { return strength; } }
        /// <summary>
        /// Damage display
        /// </summary>
        public Button Damage { get { return damage; } }
        /// <summary>
        /// Energy display
        /// </summary>
        public Button Energy { get { return energy; } }
        /// <summary>
        /// Ore display
        /// </summary>
        public Button Ore { get { return ore; } }
        /// <summary>
        /// Collect volume display
        /// </summary>
        public Button CollectVolume { get { return collectVolume; } }
        /// <summary>
        /// Frames limit display
        /// </summary>
        public Button FramesLimit { get { return framesLimit; } }
        /// <summary>
        /// AmountOrePer1MBt display
        /// </summary>
        public Button AmountOrePer1MBt { get { return amountOrePer1MBt; } }
        /// <summary>
        ///  ConsumePerFight display
        /// </summary>
        public Button ConsumePerFight { get { return consumePerFight; } }
        /// <summary>
        ///  ConsumePer100km display
        /// </summary>
        public Button ConsumePer100km { get { return consumePer100km; } }
        /// <summary>
        ///  AmountMBtPer100km display
        /// </summary>
        public Button AmountMBtPer100km { get { return amountMBtPer100km; } }
        /// <summary>
        /// Efficiency display
        /// </summary>
        public Button Efficiency { get { return efficiency; } }

        #endregion
        #region valueSetters
        /// <summary>
        /// Sets Strenght display value
        /// </summary>
        /// <param name="val">maxStr</param>
        /// <param name="val1">minStr</param>
        public void SetStrength(int val, int val1)
        {
            Strength.Text ="Strength : "+ val+"/"+val1;
            Strength.Refresh();
       
        }
        /// <summary>
        /// Sets Damage display value
        /// </summary>
        /// <param name="val">damage</param>
        public void SetDamage(int val)
        {
            Damage.Text ="Damage : " + val;
            Damage.Refresh();

        }
        /// <summary>
        /// Sets Energy display value
        /// </summary>
        /// <param name="val">currEnergy</param>
        /// <param name="val1">maxEnergy</param>
        public void SetEnergy(int val, int val1)
        {
            Energy.Text = " Energy : " + val + "/" + val1;
            Energy.Refresh();

        }
        /// <summary>
        /// Sets Ore display value
        /// </summary>
        /// <param name="val">currOre</param>
        /// <param name="val1">maxOre</param>
        public void SetOre(int val, int val1)
        {
            Ore.Text = "Ore : " + val + "/" + val1; 
            Ore.Refresh();

        }
        /// <summary>
        /// Sets CollectVolume display value
        /// </summary>
        /// <param name="val">volume</param>
        public void SetCollectVolume(int val)
        {
            CollectVolume.Text = "Collect volume : " + val ;
            CollectVolume.Refresh();

        }
        /// <summary>
        /// Sets Frames limit display value
        /// </summary>
        /// <param name="val">maxframes</param>
        public void SetFramesLimit(int val)
        {
            FramesLimit.Text = "Frames limit : " + val;
            FramesLimit.Refresh();

        }
        /// <summary>
        /// Sets AmountOrePer1MBt display value
        /// </summary>
        /// <param name="val">amountOre</param>
        public void SetAmountOrePer1MBt(int val)
        {
            AmountOrePer1MBt.Text = "Amount ore per 1 MBt : " + val;
            AmountOrePer1MBt.Refresh();

        }
        /// <summary>
        /// Sets ConsumePerFight display value
        /// </summary>
        /// <param name="val">ConsumePerFight</param>
        public void SetConsumePerFight(int val)
        {
            ConsumePerFight.Text = "Consume per fight : " + val;
            ConsumePerFight.Refresh();

        }
        /// <summary>
        /// Sets ConsumePer100km display value
        /// </summary>
        /// <param name="val">ConsumePer100km</param>
        public void SetConsumePer100km(int val)
        {
            ConsumePer100km.Text = "Consume per 100 km : " + val;
            ConsumePer100km.Refresh();

        }
        /// <summary>
        /// Sets AmountMBtPer100km display value
        /// </summary>
        /// <param name="val">AmountMBtPer100km</param>
        public void SetAmountMBtPer100km(int val)
        {
            AmountMBtPer100km.Text = "Amount MBt per 100 km : " + val;
            AmountMBtPer100km.Refresh();

        }
        /// <summary>
        /// Sets Efficiencydisplay value
        /// </summary>
        /// <param name="val">Efficiency</param>
        public void SetEfficiency(int val)
        {
            Efficiency.Text = "Efficiency : " + val;
            Efficiency.Refresh();

        }

        #endregion

        /// <summary>
        /// Constructor.Initializes all form components.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws when one of params is null</exception>
        /// <param name="screen"></param>
        /// <param name="controller"></param>
        public ShipModulesMenu(MainGameScreen screen, GameController controller)
        {
            Controller = controller ?? throw new System.ArgumentNullException(nameof(controller));
            Screen = screen ?? throw new System.ArgumentNullException(nameof(screen));
            InitializeComponent();
            this.Hide();
        }
        private void Exit_Click(object sender, EventArgs e)
        {         
            this.Hide();
        }
    
    }
}
