using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class BasicAttackBehavior : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("Basic attack!");
        }
    }
}
