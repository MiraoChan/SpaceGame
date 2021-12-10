using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlariumArcade.Model.Entities.BaseEntities;
using PlariumTestGame.Model.Entities.CoreEntities;
namespace PlariumArcade.Model.DB
{
   
    public class WorldObjects
    {
        public ITileAble[,] WorldMap { get; set; } = new ITileAble[6, 9];
        public Spaceship Spaceship { get; set; }
        /// <summary>
        /// Getting point of an object due to its position in matrix(map)
        /// If it don't find it, returns default point.
        /// </summary>
        /// <param name="value">Needed object</param>
        /// <returns>position of an obj</returns>
        public Point GetPoint(ITileAble value) {
            for (int x = 0; x < WorldMap.GetLength(0); ++x)
            {
                for (int y = 0; y < WorldMap.GetLength(1); ++y)
                {
                    if (WorldMap[x, y].Equals(value))
                        return new Point(x,y);
                }
            }
            return new Point(0, 0);
        }

    }
}
