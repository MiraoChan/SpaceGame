using System.Linq;
using PlariumArcade.Model.DL;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of gun module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Gun : ShipModuleFactory
    {
        public int Damage { get; set; }

        /// <summary>
        /// Changes all properties depends on current level.
        /// </summary>
        public override void PropertiesChange()
        {
            switch (Level)
            {
                case 1:
                    {
                        Price = 150;
                        Durability = -5;
                        Damage = 50;
                        Tile = MediaData.ImageModules1lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 2:
                    {
                        Price = 270;
                        Durability = -3;
                        Damage = 60;
                        Tile = MediaData.ImageModules2lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }
                case 3:
                    {
                        Price = 486;
                        Durability = -1;
                        Damage = 70;
                        Tile = MediaData.ImageModules3lvl[this.GetType().ToString().Split('.').Last()];
                        break;
                    }

                default:
                    break;
            }
        }
        public Gun(int level) : base(level)
        {
            Level = level;
            PropertiesChange();
        }
    }
}
