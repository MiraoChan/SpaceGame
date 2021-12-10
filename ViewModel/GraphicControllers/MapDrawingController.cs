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
    public class MapDrawingController:IDraw
    {
        public  void ReDrawMap(MainGameScreen screen, WorldObjects db)
        {
            screen.GetMainMapPanel().Controls.Clear();           //Clear all map
            foreach (var obj in db.WorldMap)
            {
                if (obj != null)
                {
                    DrawObject(screen, obj.Tile, db.GetPoint(obj));
                }                                                //Redraw elements
            }
        }
        public void DrawObject(MainGameScreen screen,Image image, Point p) 
        {          
            PictureBox pic = new PictureBox
            {
                Location = new Point(80 * p.X, 80 * p.Y),
                Size = new Size(80, 80),
                Image = image
            };
            pic.BackColor = Color.Transparent;
            screen.GetMainMapPanel().Controls.Add(pic);

        }
    }
}
