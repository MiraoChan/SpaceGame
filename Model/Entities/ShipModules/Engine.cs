namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of command center module.
    /// Inherits from model of basic ship module
    /// </summary>
    public class Engine : ShipModule
    {
        public int ConsumePerFight { get; set; }
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
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = -8;
                        ConsumePerFight = 8;
                        ConsumePer100km = 48;
                        break;
                    }
                case 3:
                    {
                        Price = 450;
                        Durability = -5;
                        ConsumePerFight = 6;
                        ConsumePer100km = 45;
                        break;
                    }

                default:
                    break;
            }
        }
        public Engine(int level) : base(level)
        {
            Level = level;
        }
    }
}
