using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlariumArcade.Model.DB;
using PlariumArcade.ViewModel.GraphicControllers;

namespace PlariumArcade.ViewModel.Initialization
{
  public class EventsController
    {
        public GameController gameController { get; set; }
        public MainGameScreen Screen { get; set; }

        public EventsController(GameController gameController, MainGameScreen Screen)
        {
            this.gameController = gameController;
            this.Screen = Screen;
        }

        public void GoLeft() {
            if (WorldData.Spaceship.Coordinates.X != 0)
            {
                WorldData.Spaceship.Coordinates
                = new System.Drawing.Point(
                   WorldData.Spaceship.Coordinates.X - 1,
                   WorldData.Spaceship.Coordinates.Y
                    );
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
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
                    ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
                }
            }
        public void GoUp() 
        {
            if(WorldData.Spaceship.Coordinates.Y != 0)
            {
                WorldData.Spaceship.Coordinates
                           = new System.Drawing.Point(
                              WorldData.Spaceship.Coordinates.X,
                               WorldData.Spaceship.Coordinates.Y - 1
                               );
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
            }
        }
        public void GoDown()
        {
            if (WorldData.Spaceship.Coordinates.Y != WorldData.WorldMap.GetLength(1)-1)
            {
                WorldData.Spaceship.Coordinates
                           = new System.Drawing.Point(
                              WorldData.Spaceship.Coordinates.X,
                              WorldData.Spaceship.Coordinates.Y + 1
                              );
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
            }
        }
    }
}
