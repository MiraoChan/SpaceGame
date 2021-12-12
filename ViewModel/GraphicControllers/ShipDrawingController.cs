using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlariumArcade.ViewModel.GraphicControllers
{
   public static class ShipDrawingController
    {
        public static PictureBox Picture { get; set; }
        public static void ReDrawObject(Point p) 
        {
            Picture.Location = new Point(80 * p.X, 80 * p.Y);
            Picture.Refresh();
        }
        public static void DrawObject(MainGameScreen screen, Image image, Point p)
        {

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
