using System.Linq;
using System.Windows.Forms;
using PlariumArcade.Model.Actions;
using PlariumArcade.Model.DB;
using PlariumArcade.Model.DL;
using PlariumArcade.ViewModel.Events;
using PlariumArcade.ViewModel.GraphicControllers;

namespace PlariumArcade.ViewModel.Initialization
{
    /// <summary>
    /// This class is responsible for the main actions 
    /// on the map. Implements the movement of the ship on the map,
    /// </summary>
    public class EventsController
    {
        /// <summary>
        /// Main game controller
        /// </summary>
        public GameController GameController { get; set; }
        /// <summary>
        /// Game screen
        /// </summary>
        public MainGameScreen Screen { get; set; }
        /// <summary>
        /// Local flag
        /// </summary>
        public bool PictureData { get; private set; }

        /// <summary>
        /// Constructor. Initializes controller,screen and adds new events.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws if one of params is null</exception>
        /// <param name="gameController">main game controller</param>
        /// <param name="Screen">current screen</param>
        public EventsController(GameController gameController, MainGameScreen Screen)
        {
            this.GameController = gameController ?? throw new System.ArgumentNullException(nameof(gameController));
            this.Screen = Screen ?? throw new System.ArgumentNullException(nameof(Screen));
            ShipDrawingController.Picture.MouseClick += new MouseEventHandler((o, a) => { OpenShipModules(); });
            MapDrawingController.ReDrawMap();
          
        }

        #region ObjectsClicks
        /// <summary>
        /// This method adds action to an orbital station
        /// </summary>
        public void AddOrbitalStationAction() 
        {
            MapDrawingController.MapObjects.Cast<PictureBox>().Last(t => MediaData.ImageOrbitalStation[0]==t.Image).MouseClick
                                  += new MouseEventHandler((o, a) => { OrbitalStation_Click(); });
        }
        /// <summary>
        /// Event of an orbital station clicking.Opens a station screen.
        /// </summary>
        public void OrbitalStation_Click() 
        {       
            DialogResult dialogResult = MessageBox.Show("Do you want to enter delivery orbital station?", "Orbital station", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                new OrbitalStationMenu(Screen, true).Show();
            }
        }
        /// <summary>
        /// Opens a ship modules menu.
        /// </summary>
        public void OpenShipModules() 
        {
            ModulesDrawingController.DrawModules(GameController.ModulesMenu);
            GameController.ModulesMenu.Show();
        }
        #endregion

        #region MoveActions
        /// <summary>
        /// Move a ship to the left cell in a world matrix. Renew all info. 
        /// </summary>
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
        /// <summary>
        /// Move a ship to the right cell in a world matrix. Renew all info. 
        /// </summary>
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
        /// <summary>
        /// Move a ship to the up cell in a world matrix. Renew all info. 
        /// </summary>
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
        /// <summary>
        /// Move a ship to the down cell in a world matrix. Renew all info. 
        /// </summary>
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
        /// <summary>
        /// Checks amount of a ship energy.If its end, it ends the game.
        /// </summary>
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
