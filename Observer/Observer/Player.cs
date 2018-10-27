using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Player : IObserver
    {
        IObservable Server { get; set; }

        //Simulates ID generation
        private static int count = 0;
        readonly int ID;

        public Player(IObservable server)
        {
            Server = server;
            count++;
            ID = count;
        }

        public void Update()
        {
            Console.WriteLine("Player {0}: Updated...", ID);
            ((GameServerObservable)Server).GetData();
        }

        public int getID()
        {
            return ID;
        }
    }
}
