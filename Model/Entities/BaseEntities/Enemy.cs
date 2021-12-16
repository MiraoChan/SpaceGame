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
        /// <summary>
        /// Enemy current strength
        /// </summary>
        public int Strength { get; set; }
        /// <summary>
        /// Enemy Max Strength
        /// </summary>
        public int MaxStrength { get; set; }
        /// <summary>
        /// Enemy Damage
        /// </summary>
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
