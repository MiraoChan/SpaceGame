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
    /// <summary>
    /// This class implements an increase in the level of 
    /// a certain module with the subsequent update of the
    /// characteristics of the ship and the GUI.
    /// </summary>
    public static class ModuleEvents
    {
        /// <summary>
        /// This method implements raising the module level,
        /// checking the current level value and updating information.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Throws if screen is null</exception>
        /// <param name="point">localization of the required module</param>
        /// <param name="screen">current ShipModulesMenu screen</param>
        /// <returns>result of increasing</returns>
        public static bool UpdateLevel(Point point,ShipModulesMenu screen)
        {
            if ( screen == null) throw new ArgumentNullException("screen");
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
