using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlariumArcade.Model.Entities.BaseEntities
{
   public class Enemy
    {
        public int Strength { get; set; }
        public int MaxStrength { get; set; }
        public int Damage { get; set; }

        public Enemy() {
            Strength = MaxStrength = new Random().Next(10, 200);
            Damage = new Random().Next(25 , 50);
        }
    }
}
