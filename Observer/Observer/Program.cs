using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            GameServerObservable gameServer = new GameServerObservable();
            Player p1 = new Player(gameServer);
            Player p2 = new Player(gameServer);
            Player p3 = new Player(gameServer);
            Player p4 = new Player(gameServer);

            gameServer.Add(p1);
            gameServer.Add(p2);
            gameServer.Add(p3);
            gameServer.Add(p4);

            gameServer.Remove(p3);

            gameServer.PlayerKilled();

            Console.ReadLine();
        }
    }
}
