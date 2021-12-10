using System.Drawing;
using PlariumArcade.Model.Entities.BaseEntities;
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
        #region Resources
        public int Cryptocurrency { get; set; }
        public int MaxStrength { get; set; }
        public int Strength { get; set; }
        public int Damage { get; set; }
        public int Energy { get; set; }
        public int Ore { get; set; }

        #endregion

        /// <summary>
        /// Array of possible locations for modules of a ship
        /// </summary>
        public ShipModule[,] Mas { get; set; }

        public Point Coordinates { get; set; }
        public Image Tile { get; set; }

        public Spaceship(int cryptocurrency, int energy) 
        { 
            Mas = new ShipModule[40, 40];
            Cryptocurrency = cryptocurrency;
            Energy = energy;
            MaxStrength = 0;
            Strength = 0;
            Damage = 0;
            Ore = 0;
            Coordinates = new Point(3,3);
            Tile = Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/SpaceShip.png");
        }
    }
}
