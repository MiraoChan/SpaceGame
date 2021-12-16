using System;

namespace PlariumArcade.Model.Entities.BaseEntities
{
    /// <summary>
    /// Enemy- one of the main objects in a game.
    /// Characterized by Strength, MaxStrength and 
    /// Damage. Attacks a ship in a case of fighting.
    /// In a case of having 0 amount of strength 
    /// deletes itself.
    /// </summary>
    public class Enemy
    {

        public int Strength { get; set; }
        public int MaxStrength { get; set; }
        public int Damage { get; set; }

        /// <summary>
        /// Constructor generates random strength netween 10 and 200
        /// ans a random enemy damage.
        /// </summary>
        public Enemy() {
            Strength = MaxStrength = new Random().Next(10, 200);
            Damage = new Random().Next(25 , 50);
        }
    }
}
