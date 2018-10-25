using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FlyingAttackBehavior: IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("Flying attack!");
        }
    }
}
