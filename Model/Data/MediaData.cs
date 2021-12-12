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
        public static List<Image> ImagePlanet { get; set; } =
          new List<Image>()
          {
             Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Planet1.png"),
             Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Planet2.png")
          };
        public static List<Image> ImageAsteroid { get; set; } =
          new List<Image>()
          {
              Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Asteroid.png")
          };

        public static List<Image> ImageSpaceShip { get; set; } =
          new List<Image>()
          {
          Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/SpaceShip.png")
          };
        public static List<Image> ImageOrbitalStation { get; set; } =
          new List<Image>()
          {
              Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Station.png")

          };
        public static Dictionary<ShipModule, Image> ImageModules { get; set; }

        #endregion
    }
}
