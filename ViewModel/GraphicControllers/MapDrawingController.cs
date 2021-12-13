using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using PlariumArcade.Model.DB;

namespace PlariumArcade.ViewModel.GraphicControllers
{
    public static class MapDrawingController
    {
        public static PictureBox[,] MapObjects { get; set; } = new PictureBox[6, 9];
        /// <summary>
        /// primary rendering of all map elements and adding controllers to the matrix
        /// </summary>
        /// <param name="screen">main game screen</param>
        public static void DrawMap(MainGameScreen screen)
        {
            foreach (var obj in WorldData.WorldMap)
            {
                if (obj != null)
                {
                    PictureBox currPB= CreatePictureBox(obj.GetType().ToString().Split('.').Last(),
                        obj.Tile, WorldData.GetPoint(obj));
                    DrawObjects(screen,currPB);
                }                                            
            }
        }
        /// <summary>
        /// Checks the correspondence of elements in the matrix of controllers and in the matrix of world objects.
        /// If a mismatch is found, replaces the element in the controller matrix
        /// </summary>
        /// <param name="screen">main game screen</param>
        public static void ReDrawMap(MainGameScreen screen) {
            for (int x = 0; x < MapObjects.GetLength(0); ++x)
            {
                for (int y = 0; y < MapObjects.GetLength(1); ++y)
                {
                    if (WorldData.WorldMap[x, y].Tile != MapObjects[x, y].Image) //mismatch is found
                    {
                        MapObjects[x, y] = CreatePictureBox(WorldData.WorldMap[x, y].GetType().ToString().Split('.').Last(),
                                                                WorldData.WorldMap[x, y].Tile,
                                                              WorldData.GetPoint(WorldData.WorldMap[x, y]));
                        MapObjects[x, y].BackColor = Color.Transparent;
                        MapObjects[x, y].BringToFront();
                    }
                }           
            }
        }
        /// <summary>
        /// Adds controller to form and adjusts its position
        /// </summary>
        /// <param name="screen">main game screen</param>
        /// <param name="pic">current PictureBox</param>
        public static void DrawObjects(MainGameScreen screen,PictureBox pic) {
            if (pic == null) { throw new ArgumentNullException("pic"); }
            pic.BackColor = Color.Transparent;
            screen.Controls.Add(pic);
            pic.BringToFront();
        }
        /// <summary>
        /// Creates a new PictureBox due to world object
        /// </summary>
        /// <param name="image">object image</param>
        /// <param name="p">object location(point)</param>
        /// <returns>new PictureBox</returns>
        public static PictureBox CreatePictureBox(String name,Image image, Point p) 
        {
            return new PictureBox
            {
                Name = name,
                Location = new Point(80 * p.X, 80 * p.Y),
                Size = new Size(80, 80),
                Image = image
            };
          
        }
    }
}
