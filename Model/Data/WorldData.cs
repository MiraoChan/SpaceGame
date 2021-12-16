using System;
using System.Drawing;
using PlariumArcade.Model.Entities.BaseEntities;
using PlariumTestGame.Model.Entities.CoreEntities;

namespace PlariumArcade.Model.DB
{
    /// <summary>
    /// Class WorldData acts as a single in-game data 
    /// store (map, counter and ship object) with
    /// the ability to access from the ViewModel layer.
    /// </summary>
    public class WorldData
    {
        /// <summary>
        /// Game map which contains all game objects, excluding a spaceship.
        /// </summary>
        public static ITileAble[,] WorldMap { get; set; } = new ITileAble[9, 6];
        /// <summary>
        /// Main game object. Plays the role of the main player
        /// </summary>
        public static Spaceship Spaceship { get; set; }
        /// <summary>
        /// Counter of ship victories over pirates
        /// </summary>
        public static int WinsCounter { get; set; }

        /// <summary>
        /// Getting point of an object due to its position in matrix(map)
        /// If it don't find it, returns default point.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws when object is null</exception>
        /// <param name="value">Needed object</param>
        /// <returns>position of an obj</returns>
        public static Point GetPoint(ITileAble value)
        {
            if (value == null) { throw new ArgumentNullException("value"); }
            for (int x = 0; x < WorldMap.GetLength(0); ++x)
            {
                for (int y = 0; y < WorldMap.GetLength(1); ++y)
                {
                    if (WorldMap[x, y] == value)
                    {
                      
                        return new Point(x, y);
                    }
                }
            }          
            return new Point(0, 0);
        }


        /// <summary>
        /// Getting point of an object due to its position in 
        /// ship module matrix inside a ship object. 
        /// If it don't find it, returns default point.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws when object is null</exception>
        /// <param name="value">needed module</param>
        /// <returns>point of a needed module on a modules map.</returns>
        public static Point GetModulePoint(ITileAble value)
        {
            if (value == null) { throw new ArgumentNullException("value"); }
            for (int x = 0; x < Spaceship.ShipModules.GetLength(0); ++x)
            {
                for (int y = 0; y < Spaceship.ShipModules.GetLength(1); ++y)
                {
                    if (Spaceship.ShipModules[x, y] == value)
                    {                  
                        return new Point(x, y);
                    }
                }
            }
            return new Point(0, 0);
        }

        /// <summary>
        /// WorldData constructor. Initializes all game map with nulls and a counter.
        /// </summary>
        public WorldData()
        {
            for (int x = 0; x < WorldMap.GetLength(0); ++x)
            {
                for (int y = 0; y < WorldMap.GetLength(1); ++y)
                {
                    WorldMap[x, y] = null;
                }
            }
            WinsCounter = 0;

        }
    }
}

