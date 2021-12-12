namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of generator module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Generator : ShipModule
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
                        break;
                    }
                case 2:
                    {
                        Price = 388;
                        Durability = 8;
                        AmountMBtPer100km = 4;
                        break;
                    }
                case 3:
                    {
                        Price = 547;
                        Durability = 10;
                        AmountMBtPer100km = 6;
                        break;
                    }

                default:
                    break;
            }
        }
        public Generator(int level) : base(level)
        {
            Level = level;
        }
    }
}
