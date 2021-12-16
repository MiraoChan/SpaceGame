using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlariumArcade.ViewModel.GraphicControllers
{
    /// <summary>
    /// This class is responsible for updating \ rendering 
    /// the graphical representation of the spaceship
    /// </summary>
    public static class ShipDrawingController
    {
        /// <summary>
        /// Graphical representation of the ship on the map
        /// </summary>
        public static PictureBox Picture { get; set; }
        /// <summary>
        /// Redraws the image of the ship in a different coordinate
        /// </summary>
        /// <param name="p">a different coordinate</param>
        public static void ReDrawObject(Point p) 
        {
            Picture.Location = new Point(80 * p.X, 80 * p.Y);
            Picture.Refresh();
        }
        /// <summary>
        /// This method creates a new graphical 
        /// representation of the ship and displays 
        /// it on the screen.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws when params are\is null</exception>
        /// <param name="screen"></param>
        /// <param name="image"></param>
        /// <param name="p"></param>
        public static void DrawObject(MainGameScreen screen, Image image, Point p)
        {
            if (screen is null || image is null)
            {
                throw new ArgumentNullException(nameof(screen));
            }      

            Picture = new PictureBox
            {
                Location = new Point(80 * p.X, 80 * p.Y),
                Size = new Size(80, 80),
                Image = image
            };
            if (!screen.Controls.Contains(Picture))
            {
                screen.Controls.Add(Picture);
            }
 
            Picture.BringToFront();
            Picture.BackColor = Color.Transparent;
            Picture.Refresh();

        }
        
    }
}
