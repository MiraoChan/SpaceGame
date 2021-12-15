using System.Collections.Generic;
using System.Drawing;
using PlariumArcade.Model.DataControllers;
using PlariumArcade.Model.Entities.BaseEntities;
using PlariumArcade.Model.Interfaces;
using PlariumTestGame.Model.Entities.ShipModules;

namespace PlariumTestGame.Model.Entities.CoreEntities
{
    public class Spaceship: ITileAble
    {
        /// <summary>
        /// enum of possible spaceship states
        /// </summary>
        public enum State
        {
            STATE_STANDING,
            STATE_GOING,
            STATE_DIGGING,
            STATE_FIGHTING,
            STATE_BUYING,
            STATE_LISTENING
        }

        #region Fields

        private ShipModuleFactory[,] shipModules;
        private Point coordinates;
        private Image tile;
        private double cryptocurrency;

        #region ModulesFields

        private int maxStrength;
        private int strength;
      
        private int energy;
        private int ore;

        private int limitEnergy;
        private int collectVolume;
        private int framesLimit;
        private int amountOrePer1MBt;
        private int consumePerFight;
        private int consumePer100km;
        private int amountMBtPer100km;
        private int damage;
        private int efficiency;
        private int oreLimit;
        #endregion

        #endregion

        #region Properties

        #region ModulesProperties
        public int MaxStrength { get { return maxStrength; } set { maxStrength = value; NotifyParamChanges(); } }
        public int Strength { get { return strength; } set { strength = value; NotifyParamChanges(); } }
        public int Damage { get { return damage; } set { damage = value; NotifyParamChanges(); } }
        public int Energy { get { return energy; } set { energy = value; NotifyParamChanges(); } }
        public int Ore { get { return ore; } set { ore = value; NotifyParamChanges(); } }
        public int CollectVolume {get { return collectVolume; }set { collectVolume = value; }}
        public int LimitEnergy { get { return limitEnergy; } set { limitEnergy = value; } }
        public int FramesLimit { get { return framesLimit; } set { framesLimit = value; } }
        public int AmountOrePer1MBt { get { return amountOrePer1MBt; } set { amountOrePer1MBt = value; } }
        public int ConsumePerFight { get { return consumePerFight; } set { consumePerFight = value; } }
        public int ConsumePer100km { get { return consumePer100km; } set { consumePer100km = value; } }
        public int AmountMBtPer100km { get { return amountMBtPer100km; } set { amountMBtPer100km = value; } }
        public int Efficiency { get { return efficiency; } set { efficiency = value; } }
        public int OreLimit { get { return oreLimit; } set { oreLimit = value; } }

        #endregion

        public double Cryptocurrency { get { return cryptocurrency; } set { cryptocurrency = value; NotifyParamChanges(); } }
        public ShipModuleFactory[,] ShipModules { get { return shipModules; } set { shipModules = value; } }
        public Point Coordinates { get { return coordinates; } set { coordinates = value; } }
        public Image Tile { get { return tile; } set { tile = value; } }
        #endregion

        #region Observer
        /// <summary>
        /// Observer realization
        /// To renew info in views
        /// </summary>
        public List<IViewSubscriber> Subscribers { get; set; }
        public void NotifyParamChanges()
        {
            foreach (var sub in Subscribers)
            {
                sub.RenewInfo();
            }
        }
        #endregion

        public Spaceship(double cryptocurrency, int energy) 
        {
            Subscribers = new List<IViewSubscriber>();
            shipModules = new ShipModuleFactory[40, 40];
            shipModules[5, 5] = new Frame(1);
            shipModules[6, 5] = new Engine(1);
            shipModules[4, 5] = new CommandCenter(1);
            shipModules[5, 4] = new Accumulator(1);
            shipModules[5, 3] = new Collector(1);
            shipModules[5, 2] = new Storage(1);
            shipModules[5, 1] = new Gun(1);
            shipModules[5, 6] = new Gun(1);
            
            this.cryptocurrency = cryptocurrency;
            this.energy = energy;
            coordinates = new Point(3,3);
            
            tile = Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/SpaceShip.png");
        }
    }
}
