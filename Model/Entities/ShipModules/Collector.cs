using System.Linq;
using PlariumArcade.Model.DL;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of collector module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Collector : ShipModule
    {
        public int CollectVolume { get; set; }

        /// <summary>
        /// Changes all properties depends on current level.
        /// </summary>
        public override void PropertiesChange()
        {
            switch (Level)
            {
                case 1:
                    {
                        Price = 75;
                        Durability = 10;
                        CollectVolume = 20;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 2:
                    {
                        Price = 131;
                        Durability = 12;
                        CollectVolume = 30;
                        Tile = MediaData.ImageModules2lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 3:
                    {
                        Price = 230;
                        Durability = 15;
                        CollectVolume = 40;
                        Tile = MediaData.ImageModules3lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }

                default:
                    break;
            }
        }
        public Collector(int level) : base(level)
        {
            Level = level;
            PropertiesChange();
        }
      
    }
}
