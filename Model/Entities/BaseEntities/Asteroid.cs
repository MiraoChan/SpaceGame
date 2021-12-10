using System;
using System.Drawing;
using PlariumArcade.Model.Entities.BaseEntities;

namespace PlariumTestGame.Model.Entities.CoreEntities
{
    public class Asteroid : Planet
    {     
        public int AmountOfOre { get; set; } 
        public Asteroid()
        {
            Name = new NameGenerator().GenerateName(this);
            AmountOfOre = new Random().Next(100, 1000);
        }

    }
}
