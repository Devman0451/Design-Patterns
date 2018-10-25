using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class BossPathFindingBehavior: IPathFindingBehavior
    {
        public void Move()
        {
            Console.WriteLine("Boss enemy movement");
        }
    }
}
