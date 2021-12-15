using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.Actions;
using PlariumArcade.Model.DataControllers;
using PlariumArcade.Model.DB;
using PlariumArcade.Model.DL;
using PlariumArcade.Model.Entities.Generators;
using PlariumArcade.ViewModel.GraphicControllers;
using PlariumTestGame.Model.Entities.CoreEntities;

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
                        Asteroid_Action(Screen, box);
                        break;
                    }
                    //object is Planet
                    else if (MediaData.ImagePlanet.Contains(box.Image) && box.Location == ShipDrawingController.Picture.Location)
                    {
                        Planet_Action(Screen,box);
                        break;
                    }
                    //object is Station
                    else if (MediaData.ImageOrbitalStation.Contains(box.Image) && box.Location == ShipDrawingController.Picture.Location)
                    {
                        OrbitalStation_Action(Screen);
                        break;
                    }
                }
            }          
        }

        #region Events
        private void Asteroid_Action(MainGameScreen Screen,PictureBox box)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to collect ore?"+"Amount:"+ ((Asteroid)WorldData.WorldMap[box.Location.X / 80, box.Location.Y / 80]).AmountOfOre,
                ((Asteroid)WorldData.WorldMap[box.Location.X / 80, box.Location.Y / 80]).Name, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (new ActionController().CollectOre(((Asteroid)WorldData.WorldMap[box.Location.X / 80, box.Location.Y / 80])))
                {
                    Screen.Controller.RenewInfo();
                    Screen.Controller.RenewModulesInfo();
                    MessageBox.Show("Ore was collected successfully", ((Asteroid)WorldData.WorldMap[box.Location.X / 80, box.Location.Y / 80]).Name, MessageBoxButtons.OK);                 
                }
                else
                {
                    Screen.Controller.RenewInfo();
                    Screen.Controller.RenewModulesInfo();
                    MessageBox.Show("Ore collecting failed", ((Asteroid)WorldData.WorldMap[box.Location.X / 80, box.Location.Y / 80]).Name, MessageBoxButtons.OK);
                }
            }
        }
        private void Planet_Action(MainGameScreen Screen, PictureBox box)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to collect ore?", ((Planet)WorldData.WorldMap[box.Location.X/80, box.Location.Y/80]).Name, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (new ActionController().CollectOre())
                {
                    Screen.Controller.RenewInfo();
                    Screen.Controller.RenewModulesInfo();
                   MessageBox.Show("Ore was collected successfully", ((Planet)WorldData.WorldMap[box.Location.X / 80, box.Location.Y / 80]).Name, MessageBoxButtons.OK);
                    CheckOreCollecting(Screen);
                   
                }
                else
                {
                    Screen.Controller.RenewInfo();
                    Screen.Controller.RenewModulesInfo();
                    MessageBox.Show("Ore collecting failed", ((Planet)WorldData.WorldMap[box.Location.X / 80, box.Location.Y / 80]).Name, MessageBoxButtons.OK);
                }
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

        private void CheckOreCollecting(MainGameScreen Screen)
        {

            if (new Random().Next(0, 100) <= 40 ) 
            {
               _= new FightEvent();
              
            }
            if (WorldData.WinsCounter == 3) {
                new WorldObjectsGenerator().GenerateAsteroid();
                Screen.Controller.ShowGraphics();
                MessageBox.Show("Asteroid appeared", "Planet", MessageBoxButtons.OK);
            }
        
        }
        #endregion
    }
}
