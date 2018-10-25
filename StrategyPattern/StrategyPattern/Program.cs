using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic
            BasicAttackBehavior basicAttack = new BasicAttackBehavior();
            BasicPathFindingBehavior basicMove = new BasicPathFindingBehavior();

            Enemy basicEnemy = new Enemy(basicAttack, basicMove, 10, 2);

            basicEnemy.Attack();
            basicEnemy.Move();

            //Boss
            BossAttackBehavior bossAttack = new BossAttackBehavior();
            BossPathFindingBehavior bossMove = new BossPathFindingBehavior();

            Enemy bossEnemy = new Enemy(bossAttack, bossMove, 30, 6);

            bossEnemy.Attack();
            bossEnemy.Move();

            //Flying
            FlyingAttackBehavior flyingAttack = new FlyingAttackBehavior();
            FlyingPathFindingBehavior flyingMove = new FlyingPathFindingBehavior();

            Enemy flyingEnemy = new Enemy(flyingAttack, flyingMove, 30, 6);

            flyingEnemy.Attack();
            flyingEnemy.Move();

            Console.ReadLine();
        }
    }
}
