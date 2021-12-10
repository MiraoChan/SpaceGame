namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of gun module.
    /// Inherits from model of basic ship module
    /// </summary>
    public class Gun : ShipModule
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
                        break;
                    }
                case 2:
                    {
                        Price = 270;
                        Durability = -3;
                        Damage = 60;
                        break;
                    }
                case 3:
                    {
                        Price = 486;
                        Durability = -1;
                        Damage = 70;
                        break;
                    }

                default:
                    break;
            }
        }
        public Gun(int level) : base(level)
        {
            Level = level;
        }
    }
}
