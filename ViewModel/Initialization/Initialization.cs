using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlariumArcade.Model.DB;
using PlariumArcade.ViewModel.GraphicControllers;
using PlariumTestGame.Model.Entities.CoreEntities;

namespace PlariumArcade.ViewModel.Initialization
{
  public class Initialization
    {
        public MainGameScreen Screen { get; set; }
        public WorldObjects WorldData { get; set; }
        public Initialization(MainGameScreen screen) 
        {
            Screen = screen;
            WorldData = new WorldObjects
            {
                Spaceship = new Spaceship(0, 0)
            };
            new ShipDrawingController().DrawObject(screen, WorldData.Spaceship.Tile, WorldData.Spaceship.Coordinates);
            GenerateNewWorld();
        }

        public void ShowGraphics() {
        
        
        }

        public void GenerateNewWorld()  
        {
        //Fill DB with objects;
        
        
        
        }



    }
}
