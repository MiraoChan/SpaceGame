namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of frame module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Frame : ShipModule
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
                        break;
                    }
                case 2:
                    {
                        Price = 250;
                        Durability = 200;
                        break;
                    }
                case 3:
                    {
                        Price = 625;
                        Durability = 300;
                        break;
                    }

                default:
                    break;
            }
        }
        public Frame(int level) : base(level)
        {
            Level = level;
        }
    }
}
