using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlariumArcade.Model.DB;
using PlariumTestGame.Model.Entities.CoreEntities;
using PlariumTestGame.Model.Entities.ShipModules;

namespace PlariumArcade.Model.DataControllers
{
  public  class ModulesController
    {
       public Spaceship Ship { get; set; }

        public ModulesController() { Ship = WorldData.Spaceship; }
        public void RefreshShipData() 
        {
            foreach (var module in WorldData.Spaceship.ShipModules) 
            {
                if (module != null) {
                    switch (module.GetType().ToString().Split('.').Last())                   
                    {
                        case "Accumulator":
                            {
                                WorldData.Spaceship.LimitEnergy += ((Accumulator)module).LimitEnergy;
                                WorldData.Spaceship.MaxStrength += ((Accumulator)module).Durability;
                                break; 
                            }
                        case "Collector": 
                            {
                                WorldData.Spaceship.CollectVolume+= ((Collector)module).CollectVolume;
                                WorldData.Spaceship.MaxStrength += ((Collector)module).Durability;
                                break;
                            }
                        case "CommandCenter": 
                            {                              
                                WorldData.Spaceship.FramesLimit += ((CommandCenter)module).FramesLimit;
                                WorldData.Spaceship.MaxStrength += ((CommandCenter)module).Durability;
                                break;
                            }
                        case "Converter": 
                            {
                                
                                WorldData.Spaceship.AmountOrePer1MBt += ((Converter)module).AmountOrePer1MBt;
                                WorldData.Spaceship.MaxStrength += ((Converter)module).Durability;
                                break;
                            }
                        case "Engine":
                            {
                                WorldData.Spaceship.ConsumePerFight += ((Engine)module).ConsumePerFight;
                                WorldData.Spaceship.ConsumePer100km += ((Engine)module).ConsumePer100km;
                                WorldData.Spaceship.MaxStrength += ((Engine)module).Durability;
                                break;
                            }
                        case "Frame": 
                            {
                                WorldData.Spaceship.MaxStrength += ((Frame)module).Durability;
                                break; 
                            }
                        case "Generator": 
                            {                              
                                WorldData.Spaceship.AmountMBtPer100km += ((Generator)module).AmountMBtPer100km;
                                WorldData.Spaceship.MaxStrength += ((Generator)module).Durability;
                                break;
                            }
                        case "Gun":
                            {                               
                                WorldData.Spaceship.Damage += ((Gun)module).Damage;
                                WorldData.Spaceship.MaxStrength += ((Gun)module).Durability;
                                break; 
                            }
                        case "Repairer": 
                            {
                                WorldData.Spaceship.Efficiency += ((Repairer)module).Efficiency;
                                WorldData.Spaceship.MaxStrength += ((Repairer)module).Durability;
                                break;
                            }
                        case "Storage":
                            {                            
                                 WorldData.Spaceship.OreLimit += ((Storage)module).OreLimit;
                                WorldData.Spaceship.MaxStrength += ((Storage)module).Durability;
                                break; 
                            }
                    }


                }
            }
        
        }
    }
}
