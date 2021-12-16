using System;
using System.Linq;
using PlariumArcade.Model.DL;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of frame module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Frame : ShipModuleFactory
    {

        /// <summary>
        /// Changes all properties depends on current level.
        /// </summary>
        public override void PropertiesChange()
        {
            switch (Level)
            {
                case 1:
                    {
                        Price = 100;
                        Durability = 100;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 2:
                    {
                        Price = 250;
                        Durability = 200;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 3:
                    {
                        Price = 625;
                        Durability = 300;
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
        public Frame(int level) : base(level)
        {
            if (level > 3 || level < 1) throw new ArgumentException("wrong level data");
            Level = level;
            PropertiesChange();
        }
    }
}
