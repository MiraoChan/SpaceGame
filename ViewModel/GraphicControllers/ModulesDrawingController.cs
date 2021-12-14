using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.DB;

namespace PlariumArcade.ViewModel.GraphicControllers
{
    public class ModulesDrawingController
    {
        public static PictureBox[,] ModuleObjects { get; set; } = new PictureBox[6, 9];
        /// <summary>
        /// render modules of a ship on a ShipModulesMenu screen
        /// </summary>
        /// <param name="screen">main game screen</param>
        public static void DrawModules(ShipModulesMenu screen)
        {
            foreach (var obj in WorldData.Spaceship.ShipModules)
            {
                if (obj != null)
                {
                    PictureBox currPB = CreatePictureBox(obj.GetType().ToString().Split('.').Last(),
                        obj.Tile, WorldData.GetModulePoint(obj));
                    DrawModule(screen, currPB);
                }
            }
        }
        /// <summary>
        /// Checks the correspondence of elements in the matrix of ship modules and in the matrix of modules.
        /// If a mismatch is found, replaces the element in the controller matrix
        /// </summary>
        /// <param name="screen">ship modules screen</param>
        public static void ReDrawModule(ShipModulesMenu screen)
        {
            if (screen is null)
            {
                throw new ArgumentNullException(nameof(screen));
            }

            for (int x = 0; x < ModuleObjects.GetLength(0); ++x)
            {
                for (int y = 0; y < ModuleObjects.GetLength(1); ++y)
                {
                    if (WorldData.WorldMap[x, y].Tile != ModuleObjects[x, y].Image) //mismatch is found
                    {
                        ModuleObjects[x, y] = CreatePictureBox(WorldData.Spaceship.ShipModules[x, y].GetType().ToString().Split('.').Last(),
                                                               WorldData.Spaceship.ShipModules[x, y].Tile,
                                                              WorldData.GetModulePoint(WorldData.Spaceship.ShipModules[x, y]));
                        ModuleObjects[x, y].BackColor = Color.Transparent;
                        ModuleObjects[x, y].BringToFront();
                    }
                }
            }
        }
        /// <summary>
        /// Adds controller to form and adjusts its position
        /// </summary>
        /// <param name="screen">main game screen</param>
        /// <param name="pic">current PictureBox</param>
        public static void DrawModule(ShipModulesMenu screen, PictureBox pic)
        {
            if (pic == null) { throw new ArgumentNullException("pic"); }
            pic.BackColor = Color.Transparent;
            screen.Controls.Add(pic);
            pic.BringToFront();
        }
        /// <summary>
        /// Creates a new PictureBox due to module
        /// </summary>
        /// <param name="image">object image</param>
        /// <param name="p">object location(point)</param>
        /// <returns>new PictureBox</returns>
        public static PictureBox CreatePictureBox(String name, Image image, Point p)
        {
            return new PictureBox
            {
                Name = name,
                Location = new Point(40 * p.X, 40 * p.Y),
                Size = new Size(40, 40),
                Image = image
            };

        }


    }
}
