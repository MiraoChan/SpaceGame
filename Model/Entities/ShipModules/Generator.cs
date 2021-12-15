using System.Linq;
using PlariumArcade.Model.DL;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of generator module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Generator : ShipModuleFactory
    {
        public int AmountMBtPer100km { get; set; }

        /// <summary>
        /// Changes all properties depends on current level.
        /// </summary>
        public override void PropertiesChange()
        {
            switch (Level)
            {
                case 1:
                    {
                        Price = 250;
                        Durability = 5;
                        AmountMBtPer100km = 2;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 2:
                    {
                        Price = 388;
                        Durability = 8;
                        AmountMBtPer100km = 4;
                        Tile = MediaData.ImageModules2lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 3:
                    {
                        Price = 547;
                        Durability = 10;
                        AmountMBtPer100km = 6;
                        Tile = MediaData.ImageModules3lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }

                default:
                    break;
            }
        }
        public Generator(int level) : base(level)
        {
            Level = level;
            PropertiesChange();
        }
    }
}
