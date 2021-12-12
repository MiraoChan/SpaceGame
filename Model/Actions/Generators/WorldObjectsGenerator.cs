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

    public class WorldObjectsGenerator
    {
        /// <summary>
        /// size of a map
        /// </summary>
        public int Xsize{ get; set; }
        public int Ysize { get; set; }

        public WorldObjectsGenerator() 
        {
           Xsize= WorldData.WorldMap.GetLength(0);
           Ysize = WorldData.WorldMap.GetLength(1);
        }
        public Point PointGenerator() 
        {
            bool empty = false;
            foreach (var i in WorldData.WorldMap) { if (i == null) { empty = true; } }
            if (!empty) { throw new ArgumentException("World is full"); }
            while (true) 
            {
                int randX = new Random().Next(8);
                int randY = new Random().Next(5);
                if (WorldData.WorldMap[randX, randY] == null)
                {                 
                    return new Point(randX, randY);
                }
            }                         
         }
        public Image ImageGenerator(List<Image> img) { return img[new Random().Next(img.Count)]; }
        public void GenerateNewWorld(int amount_planets,int amount_asteroids,int amount_orbitalStation) {
            
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

        public void GenerateNewObjects(ITileAble tileAble) { }
        public void DeleteWorldObject() { }

    }
}
