namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of converter module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Converter : ShipModule
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
                        break;
                    }
                case 2:
                    {
                        Price = 270;
                        Durability = -3;
                        AmountOrePer1MBt = 4;
                        break;
                    }
                case 3:
                    {
                        Price = 365;
                        Durability = 0;
                        AmountOrePer1MBt = 3;
                        break;
                    }

                default:
                    break;
            }
        }
        public Converter(int level) : base(level)
        {
            Level = level;
        }
    }
}
