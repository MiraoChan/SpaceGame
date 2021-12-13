namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of command center module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class CommandCenter : ShipModule
    {
        public int FramesLimit { get; set; }

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
                        Durability = 10;
                        FramesLimit = 4;
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = 20;
                        FramesLimit = 8;
                        break;
                    }
                case 3:
                    {
                        Price = 500;
                        Durability = 30;
                        FramesLimit = 12;
                        break;
                    }

                default:
                    break;
            }
        }
        public CommandCenter(int level) : base(level)
        {
            Level = level;
            PropertiesChange();
        }
       
    }
}
