using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.DataControllers;
using PlariumArcade.Model.DL;
using PlariumArcade.ViewModel.GraphicControllers;

namespace PlariumArcade.ViewModel.Events
{
   public class WorldEvents
    {
        public void CheckCollision(MainGameScreen Screen) 
        {       
            foreach (var pictureBox in Screen.Controls)
            {
                if (pictureBox is PictureBox box) {
                    //object is Asteroid
                    if (MediaData.ImageAsteroid.Contains(box.Image)&&box.Location==ShipDrawingController.Picture.Location)
                    {
                        Asteroid_Action();
                    }
                    //object is Planet
                    else if (MediaData.ImagePlanet.Contains(box.Image) && box.Location == ShipDrawingController.Picture.Location)
                    {
                        Planet_Action(Screen);
                    }
                    //object is Station
                    else if (MediaData.ImageOrbitalStation.Contains(box.Image) && box.Location == ShipDrawingController.Picture.Location)
                    {
                        OrbitalStation_Action(Screen);
                    }
                }
            }          
        }

        #region Events
        private void Asteroid_Action()
        {
           
        }
        private void Planet_Action(MainGameScreen Screen)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to collect ore?", "Planet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new ShipModulesMenu(Screen);
            }
        }
        private void OrbitalStation_Action(MainGameScreen Screen)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to enter orbital station?", "Orbital station", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OrbitalStationMenu menu = new OrbitalStationMenu(Screen);
                menu.Show();            
            }
        }
        #endregion
    }
}
