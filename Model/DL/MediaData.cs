using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlariumTestGame.Model.Entities.ShipModules;

namespace PlariumArcade.Model.DL
{
  public static class MediaData
    {

        #region Images
        public static List<Image> ImagePlanet { get; set; }
        public static List<Image> ImageAsteroid { get; set; }
        public static List<Image> ImageSpaceShip { get; set; }
        public static List<Image> ImagePlanets { get; set; }
        public static Dictionary<ShipModule, Image> ImageModules { get; set; }


        #endregion
    }
}
