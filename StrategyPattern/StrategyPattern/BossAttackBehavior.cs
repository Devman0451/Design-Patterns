using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class BossAttackBehavior: IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("Boss attack!");
        }
    }
}
