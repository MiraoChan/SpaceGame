using System;
using System.Linq;
using PlariumArcade.Model.DL;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of command center module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Engine : ShipModuleFactory
    {
        /// <summary>
        /// Energy consumption per 1 fight
        /// </summary>
        public int ConsumePerFight { get; set; }
        /// <summary>
        /// Energy consumption per 100km of flight.
        /// </summary>
        public int ConsumePer100km { get; set; }

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
                        Durability = -10;
                        ConsumePerFight = 10;
                        ConsumePer100km = 50;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = -8;
                        ConsumePerFight = 8;
                        ConsumePer100km = 48;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 3:
                    {
                        Price = 450;
                        Durability = -5;
                        ConsumePerFight = 6;
                        ConsumePer100km = 45;
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
        public Engine(int level) : base(level)
        {
            if (level > 3 || level < 1) throw new ArgumentException("wrong level data");
            Level = level;
            PropertiesChange();
        }
    }
}
