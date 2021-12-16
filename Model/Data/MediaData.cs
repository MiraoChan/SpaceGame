using System.Collections.Generic;
using System.Drawing;

namespace PlariumArcade.Model.DL
{
    /// <summary>
    /// Class MediaData provides concise access
    /// to media from code eliminating the need
    /// to use file paths inside the main game logic.
    /// Contains different lists of images depending on
    /// the type of object
    /// </summary>
    public static class MediaData
    {

        #region Images
        /// <summary>
        /// Collection of possible planet images
        /// </summary>
        public static List<Image> ImagePlanet { get; set; } =
          new List<Image>()
          {
             Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Planet1.png"),
             Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Planet2.png")
          };
        /// <summary>
        /// Collection of possible asteroid images
        /// </summary>
        public static List<Image> ImageAsteroid { get; set; } =
          new List<Image>()
          {
              Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Asteroid.png")
          };
        /// <summary>
        /// Collection of possible backgrounds
        /// </summary>
        public static List<Image> ImageSpaceShip { get; set; } =
          new List<Image>()
          {
          Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/SpaceShip.png")
          };
        /// <summary>
        /// Collection of possible orbital stations images
        /// </summary>
        public static List<Image> ImageOrbitalStation { get; set; } =
          new List<Image>()
          {
              Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Station.png")

          };
        #region ModulesImages
        /// <summary>
        /// Collections of possible modules images
        /// </summary>
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
      
        #endregion

        #endregion
    }
}
