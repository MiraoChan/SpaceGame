using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using PlariumArcade.Model.Entities.BaseEntities;

namespace PlariumTestGame.Model.Entities.ShipModules
{
    /// <summary>
    /// Abstract model of basic ship module for futher inheritance
    /// </summary>
    public abstract class ShipModule: ITileAble
    {
        private int level;

        public int Level
        {
            get => level;
            set
            {
                level = value <= 3 && value >= 1 ? value : throw new ArgumentException("");
                PropertiesChange();
            }
        }
        public void ChangeLevel()
        {
            if (Level < 3)
            {
                Level++;
            }
            PropertiesChange();
        }
        public int Price { get; set; }
        public int Durability
        {
            get; set;
        }
        public Image Tile { get; set; }

        public abstract void PropertiesChange();

        protected ShipModule(int level)
        {
            Level = level;

        }

    }
}
