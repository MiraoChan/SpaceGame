﻿using System.Drawing;
using PlariumArcade.Model.Entities.BaseEntities;

namespace PlariumTestGame.Model.Entities.CoreEntities
{
    public class Planet: ITileAble
    {
        public string Name { get; set; }
        public Image Tile { get; set; }

        public Planet(Image img) { 
            Name = NameGenerator.GenerateName(this);
            Tile = img;
        }

    }
}
