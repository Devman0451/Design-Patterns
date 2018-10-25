using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Enemy
    {
        private IAttackBehavior AttackBehavior;
        private IPathFindingBehavior PathFindingBehavior;
        private double HitPoints { get; set; }
        private double AttackPower { get; set; }

        public Enemy(IAttackBehavior AttackBehavior, IPathFindingBehavior PathFindingBehavior, double HitPoints = 1, double AttackPower = 1)
        {
            this.AttackBehavior = AttackBehavior;
            this.PathFindingBehavior = PathFindingBehavior;
            this.HitPoints = HitPoints;
            this.AttackPower = AttackPower;
        }

        public void Attack()
        {
            AttackBehavior.Attack();
        }

        public void Move()
        {
            PathFindingBehavior.Move();
        }
    }
}
