using System.Drawing;
using PlariumArcade.Model.Entities.BaseEntities;
using System;
namespace PlariumTestGame.Model.Entities.CoreEntities
{
    /// <summary>
    /// Planet- one of the main objects in a game.
    /// Characterized by unique name and a tile(image).
    /// Allows dig an ore from it.
    /// Has endless ore reserves.
    /// </summary>
    public class Planet: ITileAble
    {
        /// <summary>
        /// Planet name. Generates from satellites of the planets names.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Planet image.
        /// </summary>
        public Image Tile { get; set; }
        /// <summary>
        /// Constructor inicializes a planet image.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws when an image is null.</exception>
        /// <param name="img">initial image</param>
        public Planet(Image img) 
        {
            Name = NameGenerator.GenerateName(this);
            Tile = img ?? throw new ArgumentNullException("img");
        }

    }
}
