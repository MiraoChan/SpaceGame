using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.DataControllers;
using PlariumArcade.Model.DB;
using PlariumArcade.Model.Entities.Generators;
using PlariumArcade.Model.Interfaces;
using PlariumArcade.ViewModel.Events;
using PlariumArcade.ViewModel.GraphicControllers;
using PlariumTestGame.Model.Entities.CoreEntities;

namespace PlariumArcade.ViewModel.Initialization
{
  public class GameController: IViewSubscriber
    {
        public MainGameScreen Screen { get; set; }
        public ShipModulesMenu ModulesMenu { get; set; }
        public WorldData WorldData { get; set; }
        public EventsController EvController { get; set; }

        /// <summary>
        /// Update views due to player's data changes
        /// </summary>
        public void RenewInfo()
        {
            Screen.SetMoneyStat(WorldData.Spaceship.Cryptocurrency);
            Screen.SetOreStat(WorldData.Spaceship.Ore, WorldData.Spaceship.OreLimit);
            Screen.SetMVtStat(WorldData.Spaceship.Energy, WorldData.Spaceship.LimitEnergy);
            Screen.SetDamageStat(WorldData.Spaceship.Damage);
            Screen.SetStrengthStat(WorldData.Spaceship.Strength, WorldData.Spaceship.MaxStrength);
        }

        public void RenewModulesInfo() {

            ModulesMenu.SetStrength(WorldData.Spaceship.Strength,WorldData.Spaceship.MaxStrength);
            ModulesMenu.SetDamage(WorldData.Spaceship.Damage);
            ModulesMenu.SetEnergy(WorldData.Spaceship.Energy, WorldData.Spaceship.LimitEnergy);
            ModulesMenu.SetOre(WorldData.Spaceship.Ore, WorldData.Spaceship.OreLimit);
            ModulesMenu.SetDamage(WorldData.Spaceship.Damage);
            ModulesMenu.SetCollectVolume(WorldData.Spaceship.CollectVolume);
            ModulesMenu.SetFramesLimit(WorldData.Spaceship.FramesLimit);
            ModulesMenu.SetAmountOrePer1MBt(WorldData.Spaceship.AmountOrePer1MBt);
            ModulesMenu.SetConsumePerFight(WorldData.Spaceship.ConsumePerFight);
            ModulesMenu.SetAmountMBtPer100km(WorldData.Spaceship.AmountMBtPer100km);
            ModulesMenu.SetEfficiency(WorldData.Spaceship.Efficiency);

        }

        public GameController(MainGameScreen screen) 
        {
            //Загрузка данных
            Screen = screen;
            ModulesMenu = new ShipModulesMenu(Screen);
            WorldData = new WorldData();
           
            //Генерация мира
            WorldData.Spaceship = new Spaceship(cryptocurrency: 2500, energy: 500000);
            new ModulesController().RefreshShipData();
            WorldData.Spaceship.Strength = WorldData.Spaceship.MaxStrength;
            WorldData.Spaceship.Subscribers.Add(this);
            GenerateNewWorld();
                      
           
            //отображение графики
            RenewInfo();          
            RenewModulesInfo();       
            ShowGraphics();
            ShowModulesGraphics();



            //Подключение контроллеров
            EvController = new EventsController(this, Screen);
            new WorldEvents().CheckCollision(screen);

            //Регулярное обновление контента

        }
        public void ShowModulesGraphics() {
            ModulesDrawingController.DrawModules(ModulesMenu);
        }
        public void ShowGraphics() {
            MapDrawingController.DrawMap(Screen);
            ShipDrawingController.DrawObject(Screen, image: WorldData.Spaceship.Tile, WorldData.Spaceship.Coordinates);
        }

        public void GenerateNewWorld()  
        {
            WorldData.WorldMap[4, 2] = new Planet(Image.FromFile("C:/Users/user/Desktop/SpaceGameRep/Content/Images/Tiles/BaseTiles/Planet1.png"));
            new WorldObjectsGenerator().GenerateNewWorld(amount_planets: 2,amount_asteroids: 0,amount_orbitalStation: 1);
        }



    }
}
