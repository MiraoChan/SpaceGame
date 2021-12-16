using System;
using System.Drawing;

namespace PlariumTestGame.Model.Entities.CoreEntities
{
    /// <summary>
    /// Asteroid- one of the main objects in a game.
    /// Characterized by unique name, tile(image) and 
    /// amount of ore. Allows dig an ore from it.
    /// In a case of having 0 amount of ore
    /// deletes itself.Inherits from a Planet.
    /// </summary>
    public class Asteroid : Planet
    {
        /// <summary>
        /// Amount of available ore to collect.
        /// </summary>
        public int AmountOfOre { get; set; } 
        /// <summary>
        /// Constructor initialize an amount of ore
        /// by a random value between 100 and 1000,
        /// generates a random name and set an image.
        /// </summary>
        /// <param name="img">initial image</param>
        public Asteroid(Image img):base(img)
        {
            Tile = img;
            Name = NameGenerator.GenerateName(this);
            AmountOfOre = new Random().Next(100, 1000);
        }

    }
}
