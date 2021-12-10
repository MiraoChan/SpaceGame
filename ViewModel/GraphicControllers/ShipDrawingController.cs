using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlariumArcade.ViewModel.GraphicControllers
{
    class ShipDrawingController : IDraw
    {
        public void DrawObject(MainGameScreen screen, Image image, Point p)
        {
            PictureBox pic = new PictureBox
            {
                Location = new Point(80 * p.X, 80 * p.Y),
                Size = new Size(80, 80),
                Image = image
            };
            screen.GetMainMapPanel().Controls.Add(pic);        
        }
    }
}
