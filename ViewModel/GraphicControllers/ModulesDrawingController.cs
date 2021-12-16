using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.DB;
using PlariumArcade.ViewModel.Events;

namespace PlariumArcade.ViewModel.GraphicControllers
{
    /// <summary>
    /// This class is responsible for updating \ rendering 
    /// the graphical representation of the ship modules
    /// </summary>
    public static class ModulesDrawingController
    {
        /// <summary>
        /// Matrix of images of ship modules
        /// </summary>
        public static PictureBox[,] ModuleObjects { get; set; } = new PictureBox[6, 9];
        /// <summary>
        /// Current modules menu screen
        /// </summary>
        public static ShipModulesMenu Screen{ get; set; }
    /// <summary>
    /// render modules of a ship on a ShipModulesMenu screen
    /// </summary>
    /// <param name="screen">main game screen</param>
    public static void DrawModules(ShipModulesMenu screen)
        {
            Screen = screen;
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
            Screen = screen;
            if (screen is null)
            {
                throw new ArgumentNullException(nameof(screen));
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (WorldData.WorldMap[x,y] != null)
                    {
                        var picBox = screen.Controls.OfType<PictureBox>().Last(t => t.Image != WorldData.WorldMap[x, y].Tile&&t.Location.X/40==x&& t.Location.Y / 40 == y);
                        if (picBox!=null) //mismatch is found
                        {
                            ModuleObjects[x, y] = CreatePictureBox(WorldData.Spaceship.ShipModules[x, y].GetType().ToString().Split('.').Last(),
                                                                   WorldData.Spaceship.ShipModules[x, y].Tile,
                                                                  WorldData.GetModulePoint(WorldData.Spaceship.ShipModules[x, y]));
                            ModuleObjects[x, y].Click += new EventHandler(Module_Click);
                            ModuleObjects[x, y].BackColor = Color.Transparent;
                            ModuleObjects[x, y].BringToFront();
                        }
                    }
                }
            }
        }

        private static void Module_Click(object sender, EventArgs e)
        {
            int X = Cursor.Position.X - Screen.Location.X;
            Console.WriteLine(X);
            int Y = Cursor.Position.Y - Screen.Location.Y;
            Console.WriteLine(Y);
            for (int i = 0; i < WorldData.Spaceship.ShipModules.GetLength(0)-1; i++)
            {
        
                for (int j = 0; j < WorldData.Spaceship.ShipModules.GetLength(1)-1; j++)
                {
          
                    if (X > i*40 && X < i*40 + 40 && Y > j*40 && Y < j*40 + 40)
                    {
                       
                        ModuleEvents.UpdateLevel(new Point(i, j), Screen);
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
            pic.Click += new EventHandler(Module_Click);
            pic.BringToFront();
        }
        /// <summary>
        /// Creates a new PictureBox due to module
        /// </summary>
        /// <param name="name">name of a module</param>
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
