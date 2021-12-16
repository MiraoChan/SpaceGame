using System;
using System.Collections.Generic;
using System.Drawing;
using PlariumArcade.Model.DataControllers;
using PlariumArcade.Model.Entities.BaseEntities;
using PlariumArcade.Model.Interfaces;
using PlariumTestGame.Model.Entities.ShipModules;

namespace PlariumTestGame.Model.Entities.CoreEntities
{
    /// <summary>
    /// The core object in a game. Controls by a user.
    /// Characterized by a big amount of characteristics, 
    /// including a matrix of ship modules, current
    /// position(coordinates), amount of cryptocurrency,
    /// image and so on. 
    /// Implements an observer pattern with the aim of
    /// future ViewModel layer notifying. 
    /// </summary>
    public class Spaceship: ITileAble
    {

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
        /// <summary>
        /// MaxStrength property
        /// </summary>
        public int MaxStrength { get { return maxStrength; } set { maxStrength = value; NotifyParamChanges(); } }
        /// <summary>
        /// Strength property
        /// </summary>
        public int Strength { get { return strength; } set { strength = value; NotifyParamChanges(); } }
        /// <summary>
        /// Damage property
        /// </summary>
        public int Damage { get { return damage; } set { damage = value; NotifyParamChanges(); } }
        /// <summary>
        /// Energy property
        /// </summary>
        public int Energy { get { return energy; } set { energy = value; NotifyParamChanges(); } }
        /// <summary>
        /// Ore property
        /// </summary>
        public int Ore { get { return ore; } set { ore = value; NotifyParamChanges(); } }
        /// <summary>
        /// Collect ore property
        /// </summary>
        public int CollectVolume {get { return collectVolume; }set { collectVolume = value; }}
        /// <summary>
        /// Limit energy property
        /// </summary>
        public int LimitEnergy { get { return limitEnergy; } set { limitEnergy = value; } }
        /// <summary>
        /// Frames limit property
        /// </summary>
        public int FramesLimit { get { return framesLimit; } set { framesLimit = value; } }
        /// <summary>
        /// Amount ore per 1 MBt property
        /// </summary>
        public int AmountOrePer1MBt { get { return amountOrePer1MBt; } set { amountOrePer1MBt = value; } }
        /// <summary>
        /// Consume per fight property
        /// </summary>
        public int ConsumePerFight { get { return consumePerFight; } set { consumePerFight = value; } }
        /// <summary>
        /// Consume per 100 km property
        /// </summary>
        public int ConsumePer100km { get { return consumePer100km; } set { consumePer100km = value; } }
        /// <summary>
        /// Amount MVt per 100km property
        /// </summary>
        public int AmountMBtPer100km { get { return amountMBtPer100km; } set { amountMBtPer100km = value; } }
        /// <summary>
        /// Efficiency property
        /// </summary>
        public int Efficiency { get { return efficiency; } set { efficiency = value; } }
        /// <summary>
        /// Ore limit property
        /// </summary>
        public int OreLimit { get { return oreLimit; } set { oreLimit = value; } }

        #endregion
        /// <summary>
        /// Money property
        /// </summary>
        public double Cryptocurrency { get { return cryptocurrency; } set { cryptocurrency = value; NotifyParamChanges(); } }
        /// <summary>
        /// Ship modules property
        /// </summary>
        public ShipModuleFactory[,] ShipModules { get { return shipModules; } set { shipModules = value; } }
        /// <summary>
        /// Location property
        /// </summary>
        public Point Coordinates { get { return coordinates; } set { coordinates = value; } }
        /// <summary>
        /// Image property
        /// </summary>
        public Image Tile { get { return tile; } set { tile = value; } }
        #endregion

        #region Observer
        /// <summary>
        /// Observer realization
        /// To renew info in views
        /// </summary>
        public List<IViewSubscriber> Subscribers { get; set; }
        /// <summary>
        /// Notifying subs about changes
        /// </summary>
        public void NotifyParamChanges()
        {
            foreach (var sub in Subscribers) sub.RenewInfo();
            
        }
        #endregion
        /// <summary>
        /// Constructor implements base params initialization
        /// and image\point setting.
        /// </summary>
        /// <exception cref="System.ArgumentException">Throws when initial money or energy is wrong. </exception>
        /// <param name="cryptocurrency">start money amount</param>
        /// <param name="energy">start energy amount</param>
        public Spaceship(double cryptocurrency, int energy) 
        {
            if (cryptocurrency < 0 || energy < 0)  throw new ArgumentException("cryptocurrency"); 
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
