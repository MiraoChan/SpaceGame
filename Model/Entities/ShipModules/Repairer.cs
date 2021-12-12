namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of repairer module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Repairer : ShipModule
    {
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
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = 15;
                        Efficiency = 25;
                        break;
                    }
                case 3:
                    {
                        Price = 500;
                        Durability = 20;
                        Efficiency = 30;
                        break;
                    }

                default:
                    break;
            }
        }
        public Repairer(int level) : base(level)
        {
            Level = level;
        }
    }
}
