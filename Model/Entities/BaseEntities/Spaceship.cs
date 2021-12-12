using System.Collections.Generic;
using System.Drawing;
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

        private ShipModule[,] shipModules;
        private Point coordinates;
        private Image tile;

        private int cryptocurrency;
        private int maxStrength;
        private int strength;
        private int damage;
        private int energy;
        private int ore;

        #endregion

        #region Properties
        public int Cryptocurrency { get {return cryptocurrency; } set { cryptocurrency = value; NotifyParamChanges(); } }
        public int MaxStrength { get { return maxStrength; } set { maxStrength = value; NotifyParamChanges(); } }
        public int Strength { get { return strength; } set { strength = value; NotifyParamChanges(); } }
        public int Damage { get { return damage; } set { damage = value; NotifyParamChanges(); } }
        public int Energy { get { return energy; } set { energy = value; NotifyParamChanges(); } }
        public int Ore { get { return ore; } set { ore = value; NotifyParamChanges(); } }
        public ShipModule[,] ShipModules { get { return shipModules; } set { shipModules = value; } }// Array of possible locations for modules of a ship
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

        public Spaceship(int cryptocurrency, int energy) 
        {
            Subscribers = new List<IViewSubscriber>();
            shipModules = new ShipModule[40, 40];
            this.cryptocurrency = cryptocurrency;
            this.energy = energy;
            maxStrength = 0;
            strength = 0;
            damage = 0;
            ore = 0;
            coordinates = new Point(3,3);
            tile = Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/SpaceShip.png");
        }
    }
}
