using System.Linq;
using PlariumArcade.Model.DL;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of converter module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Converter : ShipModuleFactory
    {
        public int AmountOrePer1MBt { get; set; }

        /// <summary>
        /// Changes all properties depends on current level.
        /// </summary>
        public override void PropertiesChange()
        {
            switch (Level)
            {
                case 1:
                    {
                        Price = 200;
                        Durability = -5;
                        AmountOrePer1MBt = 5;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 2:
                    {
                        Price = 270;
                        Durability = -3;
                        AmountOrePer1MBt = 4;
                        Tile = MediaData.ImageModules2lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 3:
                    {
                        Price = 365;
                        Durability = 0;
                        AmountOrePer1MBt = 3;
                        Tile = MediaData.ImageModules3lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }

                default:
                    break;
            }
        }
        public Converter(int level) : base(level)
        {
            Level = level;
            PropertiesChange();
        }
    }
}
