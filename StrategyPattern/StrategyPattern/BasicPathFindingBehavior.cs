using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class BasicPathFindingBehavior: IPathFindingBehavior
    {
        public void Move()
        {
            Console.WriteLine("Basic enemy movement");
        }
    }
}
