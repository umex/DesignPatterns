using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Exercise
{
    public class Game
    {
        public IList<Creature> Creatures = new List<Creature>();
    }

}
