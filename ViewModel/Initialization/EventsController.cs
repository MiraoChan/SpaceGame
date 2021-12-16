using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.Actions;
using PlariumArcade.Model.DB;
using PlariumArcade.Model.DL;
using PlariumArcade.Model.Entities.BaseEntities;
using PlariumArcade.ViewModel.Events;
using PlariumArcade.ViewModel.GraphicControllers;

namespace PlariumArcade.ViewModel.Initialization
{
  public class EventsController
    {
        public GameController GameController { get; set; }
        public MainGameScreen Screen { get; set; }
        public bool PictureData { get; private set; }

        public EventsController(GameController gameController, MainGameScreen Screen)
        {
            this.GameController = gameController;
            this.Screen = Screen;
            ShipDrawingController.Picture.MouseClick += new MouseEventHandler((o, a) => { OpenShipModules(); });
            MapDrawingController.ReDrawMap();
          
        }

        #region ObjectsClicks
        public void AddOrbitalStationAction() 
        {
            MapDrawingController.MapObjects.Cast<PictureBox>().Last(t => MediaData.ImageOrbitalStation[0]==t.Image).MouseClick
                                  += new MouseEventHandler((o, a) => { OrbitalStation_Click(); });
        }
        public void OrbitalStation_Click() 
        {       
            DialogResult dialogResult = MessageBox.Show("Do you want to enter delivery orbital station?", "Orbital station", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new OrbitalStationMenu(Screen, true).Show();
            }
        }
        public void OpenShipModules() 
        {
            ModulesDrawingController.DrawModules(GameController.ModulesMenu);
            GameController.ModulesMenu.Show();
        }
        #endregion

        #region MoveActions
        public void GoLeft() 
        {
            if (WorldData.Spaceship.Coordinates.X != 0)
            {
                WorldData.Spaceship.Coordinates
                = new System.Drawing.Point
                (
                   WorldData.Spaceship.Coordinates.X - 1,
                   WorldData.Spaceship.Coordinates.Y
                );
                CheckEnergy();
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
                GameController.RenewInfo();
                GameController.RenewModulesInfo();
                new WorldEvents().CheckCollision(Screen);
            }
        }
        public void GoRight() 
        {
                if (WorldData.Spaceship.Coordinates.X != WorldData.WorldMap.GetLength(0)-1)
                {
                    WorldData.Spaceship.Coordinates
                    = new System.Drawing.Point(
                        WorldData.Spaceship.Coordinates.X + 1,
                       WorldData.Spaceship.Coordinates.Y
                        );
                    CheckEnergy();
                    ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
                    GameController.RenewInfo();
                     GameController.RenewModulesInfo();
                    new WorldEvents().CheckCollision(Screen);
                }
        }
        public void GoUp() 
        {
            if(WorldData.Spaceship.Coordinates.Y != 0)
            {
                WorldData.Spaceship.Coordinates
                           = new System.Drawing.Point
                           (
                              WorldData.Spaceship.Coordinates.X,
                               WorldData.Spaceship.Coordinates.Y - 1
                            );
                CheckEnergy();
                
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
                GameController.RenewInfo();
                GameController.RenewModulesInfo();
                new WorldEvents().CheckCollision(Screen);
            }
        }
        public void GoDown()
        {
            if (WorldData.Spaceship.Coordinates.Y != WorldData.WorldMap.GetLength(1)-1)
            {
                WorldData.Spaceship.Coordinates
                           = new System.Drawing.Point
                           (
                              WorldData.Spaceship.Coordinates.X,
                              WorldData.Spaceship.Coordinates.Y + 1
                            );
                CheckEnergy();
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
                GameController.RenewInfo();
                GameController.RenewModulesInfo();
                new WorldEvents().CheckCollision(Screen);
            }
        }
        public void CheckEnergy()
        {
            if (!new ActionController().ChangeLocation())
            {
                MessageBox.Show("You are out of energy. End of a game.", "End", MessageBoxButtons.OK);
                Application.Exit();
            }

        }

        #endregion

    }
}
