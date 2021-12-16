using System;
using System.Linq;
using PlariumArcade.Model.DL;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of repairer module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Repairer : ShipModuleFactory
    {
        /// <summary>
        /// KPD of repair per 10 minutes
        /// </summary>
        public int Efficiency { get; set; }

        /// <summary>
        /// Changes all properties depends on current level.
        /// </summary>
        public override void PropertiesChange()
        {
            switch (Level)
            {
                case 1:
                    {
                        Price = 350;
                        Durability = 10;
                        Efficiency = 20;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = 15;
                        Efficiency = 25;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 3:
                    {
                        Price = 500;
                        Durability = 20;
                        Efficiency = 30;
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
        public Repairer(int level) : base(level)
        {
            if (level > 3 || level < 1) throw new ArgumentException("wrong level data");
            Level = level;
            PropertiesChange();
        }
    }
}
