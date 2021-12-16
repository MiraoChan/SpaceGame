﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.Actions;
using PlariumArcade.Model.DB;
using PlariumArcade.ViewModel.Events;
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
            ShipDrawingController.Picture.MouseClick += new MouseEventHandler((o, a) => { OpenShipModules(); });
        }

        public void OpenShipModules() {
            ModulesDrawingController.DrawModules(gameController.ModulesMenu);
            gameController.ModulesMenu.Show();
        }

        public void GoLeft() {
            if (WorldData.Spaceship.Coordinates.X != 0)
            {
                WorldData.Spaceship.Coordinates
                = new System.Drawing.Point(
                   WorldData.Spaceship.Coordinates.X - 1,
                   WorldData.Spaceship.Coordinates.Y
                    );
                CheckEnergy();
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
                gameController.RenewInfo();
                gameController.RenewModulesInfo();
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
                gameController.RenewInfo();
                gameController.RenewModulesInfo();
                new WorldEvents().CheckCollision(Screen);
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
                CheckEnergy();
                
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
                gameController.RenewInfo();
                gameController.RenewModulesInfo();
                new WorldEvents().CheckCollision(Screen);
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
                CheckEnergy();
                ShipDrawingController.ReDrawObject(WorldData.Spaceship.Coordinates);
                gameController.RenewInfo();
                gameController.RenewModulesInfo();
                new WorldEvents().CheckCollision(Screen);
            }
        }
        public void CheckEnergy() {
            if (!new ActionController().ChangeLocation())
            {
                MessageBox.Show("You are out of energy. End of a game.", "End", MessageBoxButtons.OK);
                Application.Exit();
            }

        }
    }
}
