using System;
using System.Drawing;
using PlariumArcade.Model.Entities.BaseEntities;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Abstract model of basic ship module for futher inheritance
    /// Implements 
    /// </summary>
    public abstract class ShipModuleFactory: ITileAble
    {
        private int level;

        /// <summary>
        /// Implements a check for the correctness of establishing a new level
        /// </summary>
        public int Level
        {
            get => level;
            set
            {
                level = value <= 3 && value >= 1 ? value : throw new ArgumentException("");
                PropertiesChange();
            }
        }
        /// <summary>
        /// Price of a module
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Module durability
        /// </summary>
        public int Durability
        {
            get; set;
        }
        /// <summary>
        /// Image of a module
        /// </summary>
        public Image Tile { get; set; }

        /// <summary>
        /// Implements a check for establishing a new 
        /// level and updating all characteristics of the module.
        /// </summary>
        public void ChangeLevel()
        {
            if (Level < 3)
            {
                Level++;
            }
            PropertiesChange();
        }
        /// <summary>
        /// An abstract method for subsequent implementation 
        /// in child classes in order to establish specific 
        /// changes in the values ​​of characteristics
        /// </summary>
        public abstract void PropertiesChange();

        /// <summary>
        /// Constructor.Init a module level
        /// </summary>
        /// <param name="level">init level</param>
        protected ShipModuleFactory(int level)
        {
            Level = level;
        }
    }
}
