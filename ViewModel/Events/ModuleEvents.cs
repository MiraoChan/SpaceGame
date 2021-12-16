using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlariumArcade.Model.DataControllers;
using PlariumArcade.Model.DB;
using PlariumArcade.ViewModel.GraphicControllers;

namespace PlariumArcade.ViewModel.Events
{
    public static class ModuleEvents
    {
        public static bool UpdateLevel(Point point,ShipModulesMenu screen)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to upgrade module?",
               WorldData.Spaceship.ShipModules[point.X, point.Y].GetType().Name, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (WorldData.Spaceship.ShipModules[point.X, point.Y].Level == 3)
                {
                    MessageBox.Show("This module already has the max level", WorldData.Spaceship.ShipModules[point.X, point.Y].GetType().Name, MessageBoxButtons.OK);
                    return false;
                }
                WorldData.Spaceship.ShipModules[point.X, point.Y].ChangeLevel();
                
                WorldData.Spaceship.Cryptocurrency -= WorldData.Spaceship.ShipModules[point.X, point.Y].Price;
                new ModulesController().RefreshShipData();
                screen.Controller.RenewInfo();
                screen.Controller.RenewModulesInfo();
                return true;
            }
            return false;
        }
         
    }
}
