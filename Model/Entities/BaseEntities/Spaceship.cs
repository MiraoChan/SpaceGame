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
        public int Cryptocurrency { get; set; }
        public int MaxStrength { get; set; }
        public int Strength { get; set; }
        public int Damage { get; set; }
        public int Energy { get; set; }

        /// <summary>
        /// Array of possible locations for modules of a ship
        /// </summary>
        public ShipModule[,] Mas { get; set; }
        public Point Coordinates { get; set; }
        public Image Tile { get; set; }

        public Spaceship() { Mas = new ShipModule[40, 40]; }
    }
}
