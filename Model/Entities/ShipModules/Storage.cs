namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of storage module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Storage : ShipModule
    {
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
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = 20;
                        OreLimit = 2000000;
                        break;
                    }
                case 3:
                    {
                        Price = 500;
                        Durability = 30;
                        OreLimit = 3000000;
                        break;
                    }

                default:
                    break;
            }
        }
        public Storage(int level) : base(level)
        {
            Level = level;
        }
    }
}
