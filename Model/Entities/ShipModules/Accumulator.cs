namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of accumulator module.
    /// Inherits from model of basic ship module
    /// </summary>
    public class Accumulator : ShipModule
    {
        public int Limit { get; set; }

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
                        Durability = 10;
                        Limit = 1000000;
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = 15;
                        Limit = 2000000;
                        break;
                    }
                case 3:
                    {
                        Price = 450;
                        Durability = 20;
                        Limit = 3000000;
                        break;
                    }

                default:
                    break;
            }
        }
        public Accumulator(int level) : base(level)
        {
            Level = level;
        }
    }
}
