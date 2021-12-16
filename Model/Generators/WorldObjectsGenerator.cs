using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlariumArcade.Model.DB;
using PlariumArcade.Model.DL;
using PlariumArcade.Model.Entities.BaseEntities;
using PlariumTestGame.Model.Entities.CoreEntities;

namespace PlariumArcade.Model.Entities.Generators
{
    /// <summary>
    /// Class WorldObjectsGenerator is responsible for
    /// generating objects on the game map based on the 
    /// size of the map. Used for initial initialization
    /// </summary>
    public class WorldObjectsGenerator
    {
        /// <summary>
        /// Playing field length
        /// </summary>
        public int Xsize{ get; set; }
        /// <summary>
        /// Playing field width
        /// </summary>
        public int Ysize { get; set; }

        /// <summary>
        /// Class constructor. Initializes the dimensions
        /// of the map based on an existing map in the WorldData class
        /// </summary>
        public WorldObjectsGenerator() 
        {
           Xsize= WorldData.WorldMap.GetLength(0);
           Ysize = WorldData.WorldMap.GetLength(1);
        }
        /// <summary>
        /// Generates a point free of other objects on the map 
        /// </summary>
        /// <exception cref="System.ArgumentException">Throws when all possible points are full </exception>
        /// <returns>A free point</returns>
        public Point PointGenerator() 
        {
            bool empty = false;
            foreach (var i in WorldData.WorldMap) { if (i == null) { empty = true; } }
            if (!empty) { throw new ArgumentException("World is full"); }
            while (true) 
            {
                int randX = new Random().Next(1,8);
                int randY = new Random().Next(1,5);
                if (WorldData.WorldMap[randX, randY] == null)
                {                 
                    return new Point(randX, randY);
                }
            }                         
         }
        /// <summary>
        /// Selects a random picture from the list
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws when initial list is null</exception>
        /// <param name="img">random image</param>
        /// <returns></returns>
        public Image ImageGenerator(List<Image> img) {
            if (img == null) { throw new ArgumentNullException("img"); }
            return img[new Random().Next(img.Count)]; }

        /// <summary>
        /// Generate new objects onto a game map according to indicated parameters
        /// (amount of each object )
        /// </summary>
        /// <remarks>There can be only one orbital station.</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">Throws when one of parameters has an illegal value.</exception>
        /// <param name="amount_planets">amount of planets to generate</param>
        /// <param name="amount_asteroids">amount ofasteroids to generate</param>
        /// <param name="amount_orbitalStation">amount of orbital stations to generate</param>
        public void GenerateNewWorld(int amount_planets,int amount_asteroids,int amount_orbitalStation) {

            if (amount_planets < 0 || amount_asteroids < 0 || amount_orbitalStation > 1 || amount_orbitalStation < 0) 
            { 
                throw new ArgumentOutOfRangeException("amount_planets"); 
            }
            
            Array.Clear(WorldData.WorldMap,0,WorldData.WorldMap.Length);

            //OrbitalStation
            for (int orbitalStation = 0; orbitalStation < amount_orbitalStation; orbitalStation++)
            {
                WorldData.WorldMap[WorldData.WorldMap.GetLength(0) / 2, 
                                   WorldData.WorldMap.GetLength(1) / 2]
                                   = new OrbitalStation(ImageGenerator(MediaData.ImageOrbitalStation));
            }

            //Planets
            for (int planets = 0; planets < amount_planets; planets++) 
            {
                Point randXY = PointGenerator();
                WorldData.WorldMap[randXY.X, randXY.Y] = new Planet(ImageGenerator(MediaData.ImagePlanet));                                               
            }

            //Asteroids
            for (int asteroids = 0; asteroids < amount_asteroids; asteroids++)
            {
                Point randXY = PointGenerator();
                WorldData.WorldMap[randXY.X, randXY.Y] = new Asteroid(ImageGenerator(MediaData.ImageAsteroid));
            }           
        }
        /// <summary>
        /// Generates a new asteroid onto the map.
        /// </summary>
        public void GenerateAsteroid() {
            Point point= PointGenerator();
            WorldData.WorldMap[point.X, point.Y] = new Asteroid(ImageGenerator(MediaData.ImageAsteroid));

        }
    }
}
