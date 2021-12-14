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
             Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Planet1.png"),
             Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Planet2.png")
          };
        public static List<Image> ImageAsteroid { get; set; } =
          new List<Image>()
          {
              Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Asteroid.png")
          };

        public static List<Image> ImageSpaceShip { get; set; } =
          new List<Image>()
          {
          Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/SpaceShip.png")
          };
        public static List<Image> ImageOrbitalStation { get; set; } =
          new List<Image>()
          {
              Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Station.png")

          };
        #region ModulesImages
        public static Dictionary<string, Image> ImageModules1lvl { get; set; } =
          new Dictionary<string, Image>()
          {
              {"Accumulator", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Accumulator1.png")},
              {"Collector", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Collector1.png")},
              {"CommandCenter", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/CommandCenter1.png")},
              {"Converter", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Converter1.png")},
              {"Engine", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Engine1.png")},
              {"Frame", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Frame1.png")},
              {"Generator", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Generator1.png")},
              {"Gun", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Gun1.png")},
              {"Repairer", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Repairer1.png")},
              {"Storage", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/1lvl/Storage1.png")},
          };
        public static Dictionary<string, Image> ImageModules2lvl { get; set; } =
          new Dictionary<string, Image>()
          {
              {"Accumulator", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Accumulator2.png")},
              {"Collector", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Collector2.png")},
              {"CommandCenter", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/CommandCenter2.png")},
              {"Converter", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Converter2.png")},
              {"Engine", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Engine2.png")},
              {"Frame", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Frame2.png")},
              {"Generator", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Generator2.png")},
              {"Gun", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Gun2.png")},
              {"Repairer", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Repairer2.png")},
              {"Storage", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/2lvl/Storage2.png")},
          };
        public static Dictionary<string, Image> ImageModules3lvl { get; set; } =
          new Dictionary<string, Image>()
          {
              {"Accumulator", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Accumulator3.png")},
              {"Collector", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Collector3.png")},
              {"CommandCenter", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/CommandCenter3.png")},
              {"Converter", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Converter3.png")},
              {"Engine", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Engine3.png")},
              {"Frame", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Frame3.png")},
              {"Generator", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Generator3.png")},
              {"Gun", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Gun3.png")},
              {"Repairer", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Repairer3.png")},
              {"Storage", Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Modules/3lvl/Storage3.png")},
          };
        #endregion


        #endregion
    }
}
