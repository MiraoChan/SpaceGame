using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlariumArcade.Model.Entities.BaseEntities
{
    /// <summary>
    /// OrbitalStation- one of the main objects in a game.
    /// Characterized by Tile. Allows sell ore 
    /// and buy energy on it.
    /// Always appears in a middle of a world map.
    /// </summary>
    class OrbitalStation : ITileAble
    {
        /// <summary>
        /// Image of an orbital station
        /// </summary>
        public Image Tile { get; set; }

        /// <summary>
        /// Initializes a station image.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">throws if an image is null.</exception>
        /// <param name="img">initial image</param>
        public OrbitalStation(Image img) 
        {
            Tile = img ?? throw new ArgumentNullException("img"); 
        }
    }
}
