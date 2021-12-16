using System;
using System.Windows.Forms;
using PlariumArcade.Model.DB;
using PlariumTestGame.Model.Entities.CoreEntities;

namespace PlariumArcade.Model.Actions
{
    public class ActionController
    {
        /// <summary>
        /// Change amount of energy according to consuming per 100km and changing 
        /// location of a spaceship.
        /// </summary>
        /// <returns>false in a case of out of an energy
        ///  true in a case of a successful energy intake </returns>
        public bool ChangeLocation()
        {
            WorldData.Spaceship.Energy -= WorldData.Spaceship.ConsumePer100km*10;
            if (WorldData.Spaceship.Energy <= 0)
            {
                return false;
            }
            return true;
        }

        #region StationInteraction

        /// <summary>
        /// Implements the purchase of energy. The price is adjusted
        /// depending on the amount of purchased energy and 
        /// the availability of delivery.
        /// </summary>
        /// <exception cref="System.ArgumentException">Throws in a case of illegal entered data</exception>
        /// <param name="amount">amount of energy to buy</param>
        /// <param name="delivery">availability of delivery</param>
        /// <returns>true if the purchase was successfylly done.
        /// false if there's not enough money for purchase 
        /// or there's no place to keep bought energy.</returns>
        public bool BuyEnergy(string amount,bool delivery) 
        {
          
            if (!int.TryParse(amount, out int res))
            {
                throw new ArgumentException("amount");
            }
            else 
            {
                if (!delivery)
                {
                    if (1 < res && res < 100)         
                    { 
                        return Buy(res, 0.5); 
                    }
                    else if (100 <= res && res < 500)  
                    {
                        return Buy(res, 0.4); 
                    }
                    else if (500 <= res && res < 1500) 
                    { 
                        return Buy(res, 0.3); 
                    }
                    else if (1500 <= res)              
                    {
                        return Buy(res, 0.1); 
                    }
                }
                else 
                {
                     if (500 <= res && res < 1500) 
                    {
                        if (Buy(res, 0.4))
                        {
                            MessageBox.Show("Energy was successfully delivered by the shuttle.",
                                            "Buy energy", 
                                            MessageBoxButtons.OK);
                            return true;
                        }
                        else return false; 
                    }
                    else if (1500 <= res) 
                    {
                        if (Buy(res, 0.3))
                        {
                            MessageBox.Show("Energy was successfully delivered by the shuttle.", 
                                            "Buy energy",
                                            MessageBoxButtons.OK);
                            return true;
                        }
                        else return false; 
                    }
                }           
            }                                
            return false; 
        }

        /// <summary>
        /// Implements interaction with Ship data.
        /// Takes away fixed amount of money for purchasing
        /// Adds purchased energy.
        /// </summary>
        /// <param name="amount">amount of energy</param>
        /// <param name="coefficient">purchasing coefficient</param>
        /// <returns>true if the data change was successfylly done.
        /// false if there's no place to keep bought energy.</returns>
        public bool Buy(int amount, double coefficient)
        {

            if (WorldData.Spaceship.Cryptocurrency - amount * coefficient >= 0)
            {
                if (WorldData.Spaceship.Energy + amount <= WorldData.Spaceship.LimitEnergy)
                {
                    WorldData.Spaceship.Energy += amount;
                    WorldData.Spaceship.Cryptocurrency -= amount * coefficient;
                    return true;
                }
                else return false; 
            }
            else return false; 
        }
        /// <summary>
        /// Implements selling collected ore.The price is adjusted
        /// depending on the amount of selling ore.
        /// </summary>
        /// <exception cref="System.ArgumentException">Throws in a case of illegal entered data</exception>
        /// <param name="amount">amount of selling ore.</param>
        /// <returns>true if operation done successfully.</returns>
        public bool SellOre(string amount)
        {
            if (!int.TryParse(amount, out int res))
            {
                throw new ArgumentException("amount");
            }
            else
            {
                if (1 < res && res < 100)
                {  
                    return Sell(res, 0.12);
                }
                    else if (100 <= res && res < 500) 
                {
                    return Sell(res, 0.1);
                }
                    else if (500 <= res && res < 1500)
                { 
                    return Sell(res, 0.08);
                }
                    else if (1500 <= res)
                {
                    return Sell(res, 0.06);
                }
              
            }
            return false;
        }
        /// <summary>
        /// Implements interaction with Ship data.
        /// Takes away fixed amount of ore for selling
        /// Adds earned money.
        /// </summary>
        /// <param name="amount">amount of ore</param>
        /// <param name="coefficient">purchasing coefficient</param>
        /// <returns></returns>
        public bool Sell(int amount,double coefficient) 
        {
            if (amount <= WorldData.Spaceship.Ore) 
            {
                WorldData.Spaceship.Ore -= amount;
                WorldData.Spaceship.Cryptocurrency += amount * coefficient;
                return true;
            }
            return false;
        }

        #endregion

        /// <summary>
        /// Collects ore from a planet
        /// adds ore and takes away ship energy
        /// </summary>
        /// <returns>result of an action(success/failed)</returns>
        public bool CollectOre()
        {
            //enough space for a full ore shipment
            if ((WorldData.Spaceship.Ore + WorldData.Spaceship.CollectVolume) < WorldData.Spaceship.OreLimit)
            {
                //enough energy for collecting
                if (WorldData.Spaceship.Energy - WorldData.Spaceship.CollectVolume >= 0)
                {
                    WorldData.Spaceship.Ore += WorldData.Spaceship.CollectVolume;
                    WorldData.Spaceship.Energy -= WorldData.Spaceship.CollectVolume;
                    return true;
                }
                else  return false; 
            }
            //not enough space for a full ore shipment
            if ((WorldData.Spaceship.Ore + WorldData.Spaceship.CollectVolume) >= WorldData.Spaceship.OreLimit)
            {
                //Enough energy for collecting => collect.
                if (WorldData.Spaceship.Energy - WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore >= 0)
                {
                    WorldData.Spaceship.Ore += WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore;
                    WorldData.Spaceship.Energy -= WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore;                   
                    return true;
                }
                //Not enough energy for collecting => stop.
                else   return false; 
            }
            return false;
            }

        /// <summary>
        /// collects ore from asteroid 
        /// adds ore and tales away energy
        /// takes away asteroid ore or deletes asteroid
        /// </summary>
        /// <param name="asteroid">current asteroid</param>
        /// <returns>result of an action(success/failed)</returns>
        public bool CollectOre(Asteroid asteroid)
        {
            //enough space for a full ore shipment
            if ((WorldData.Spaceship.Ore + WorldData.Spaceship.CollectVolume) < WorldData.Spaceship.OreLimit)
            {

                //enough asteroid ore  for a full ore shipment =>collect.
                if (WorldData.Spaceship.CollectVolume < ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre)
                {
                    //Enough energy for collecting => collect.
                    if (WorldData.Spaceship.Energy - WorldData.Spaceship.CollectVolume >= 0)
                    {

                        WorldData.Spaceship.Ore += WorldData.Spaceship.CollectVolume;
                        WorldData.Spaceship.Energy -= WorldData.Spaceship.CollectVolume;
                        ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre
                            -= WorldData.Spaceship.CollectVolume;
                        return true;
                    }
                    //Nor enough energy for collecting => stop.
                    else { return false; }


                }

                //Not enough asteroid ore  for a full ore shipment =>collect all asteroid ore and delete it.
                if (WorldData.Spaceship.CollectVolume >= ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre)
                {
                    if (WorldData.Spaceship.Energy - ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre >= 0)
                    {
                        WorldData.Spaceship.Ore += ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre;
                        WorldData.Spaceship.Energy -= ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre;
                        WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y] = null;
                        return true;

                    }
                    else { return false; }


                }


            }
            //not enough space =>trim shipment
            if ((WorldData.Spaceship.Ore + WorldData.Spaceship.CollectVolume) >= WorldData.Spaceship.OreLimit)
            {
                //enough asteroid ore  for a trim shipment =>collect trim shipment.
                if (WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore < ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre)
                {
                    //Enough energy for collecting => collect.
                    if (WorldData.Spaceship.Energy - WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore >= 0)
                    {
                        WorldData.Spaceship.Ore += WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore;
                        WorldData.Spaceship.Energy -= WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore;
                        ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre
                            -= WorldData.Spaceship.OreLimit - WorldData.Spaceship.Ore;
                        return true;
                    }
                    //Not enough energy for collecting => stop.
                    else return false; 
                }
                //Not enough asteroid ore  for a trim shipment =>collect all asteroid ore and delete it.
                if (WorldData.Spaceship.OreLimit - WorldData.Spaceship.CollectVolume >= ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre)
                {
                    //Enough energy for collecting => collect.
                    if (WorldData.Spaceship.Energy - ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre >= 0)
                    {
                        WorldData.Spaceship.Ore += ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre;
                        WorldData.Spaceship.Energy -= ((Asteroid)WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y]).AmountOfOre;
                        WorldData.WorldMap[WorldData.GetPoint(asteroid).X, WorldData.GetPoint(asteroid).Y] = null;
                        return true;
                    }
                    //Not enough energy for collecting => stop.
                    else  return false; 
                }
            }
            return false;
        }
    }
}
