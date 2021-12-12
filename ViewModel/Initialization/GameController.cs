using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlariumArcade.Model.DB;
using PlariumArcade.Model.Entities.Generators;
using PlariumArcade.Model.Interfaces;
using PlariumArcade.ViewModel.GraphicControllers;
using PlariumTestGame.Model.Entities.CoreEntities;

namespace PlariumArcade.ViewModel.Initialization
{
  public class GameController: IViewSubscriber
    {
        public MainGameScreen Screen { get; set; }
        public WorldData WorldData { get; set; }
        public EventsController EvController { get; set; }

        /// <summary>
        /// Update views due to player's data changes
        /// </summary>
        public void RenewInfo()
        {
            Screen.SetMoneyStat(WorldData.Spaceship.Cryptocurrency);
            Screen.SetOreStat(WorldData.Spaceship.Ore);
            Screen.SetMVtStat(WorldData.Spaceship.Energy);
            Screen.SetDamageStat(WorldData.Spaceship.Damage);
            Screen.SetStrengthStat(WorldData.Spaceship.Strength, WorldData.Spaceship.MaxStrength);
        }



        public GameController(MainGameScreen screen) 
        {
            //Загрузка данных
            Screen = screen;
            WorldData = new WorldData();
          
            //Генерация мира
            WorldData.Spaceship = new Spaceship(cryptocurrency: 2500, energy: 5000000);
            WorldData.Spaceship.Subscribers.Add(this);
            GenerateNewWorld();
            //Подключение контроллеров


            EvController = new EventsController(this,Screen);
           
            //отображение графики
            RenewInfo();          
            ShowGraphics();
        }

        public void ShowGraphics() {
            MapDrawingController.DrawMap(Screen);
            ShipDrawingController.DrawObject(Screen, image: WorldData.Spaceship.Tile, WorldData.Spaceship.Coordinates);
        }

        public void GenerateNewWorld()  
        {
            WorldData.WorldMap[4, 2] = new Planet(Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/Planet1.png"));
            new WorldObjectsGenerator().GenerateNewWorld(amount_planets: 2,amount_asteroids: 0,amount_orbitalStation: 1);
        }



    }
}
