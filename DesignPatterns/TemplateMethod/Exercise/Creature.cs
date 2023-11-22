using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Exercise
{
    public class Creature
    {
        public int Attack, Health;

        public Creature(int attack, int health)
        {
            Attack = attack;
            Health = health;
        }
    }

}
