using System;
using System.Linq;
using PlariumArcade.Model.DL;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of storage module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Storage : ShipModuleFactory
    {
        /// <summary>
        /// Limit of ore containing
        /// </summary>
        public int OreLimit { get; set; }

        /// <summary>
        /// Changes all properties depends on current level.
        /// </summary>
        public override void PropertiesChange()
        {
            switch (Level)
            {
                case 1:
                    {
                        Price = 50;
                        Durability = 10;
                        OreLimit = 2000;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = 20;
                        OreLimit = 2000000;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 3:
                    {
                        Price = 500;
                        Durability = 30;
                        OreLimit = 3000000;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }

                default:
                    break;
            }
        }
          /// <summary>
          /// Constructor. Initializes level and checks its correctness
          /// </summary>
          /// <exception cref="System.ArgumentException">Throws when init level is wrong.</exception>
          /// <param name="level">init level</param>
        public Storage(int level) : base(level)
        {
            if (level > 3 || level < 1) throw new ArgumentException("wrong level data");
            Level = level;
            PropertiesChange();
        }
    }
}
