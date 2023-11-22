using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Exercise
{
    public class PermanentCardDamage : CardGame
    {
        public PermanentCardDamage(Creature[] creatures) : base(creatures)
        {
        }

        protected override void Hit(Creature attacker, Creature other)
        {
            other.Health -= attacker.Attack;
        }
    }

}
