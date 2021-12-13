using System;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Class of accumulator module.
    /// Inherits from model of basic ship module
    /// </summary>
    public sealed class Accumulator : ShipModule
    {
        private int limitEnergy;

        public int LimitEnergy 
        {
            get => limitEnergy;
            set => limitEnergy = limitEnergy < 0  ? throw new ArgumentException("illegal value") : value;
        }

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
                        LimitEnergy = 1000000;
                        break;
                    }
                case 2:
                    {
                        Price = 300;
                        Durability = 15;
                        LimitEnergy = 2000000;
                        break;
                    }
                case 3:
                    {
                        Price = 450;
                        Durability = 20;
                        LimitEnergy = 3000000;
                        break;
                    }

                default:
                    break;
            }
        }
        public Accumulator(int level) : base(level)
        {
            if (level > 3 || level < 1) { throw new ArgumentException("wrong level data"); }
            Level = level;
            PropertiesChange();
        }
      
    }
}
