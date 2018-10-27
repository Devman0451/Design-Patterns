using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // Simulates a game engine. 
    // Notifies players who are subsribed to Events that occur in the engine
    class GameServerObservable : IObservable
    {
        private List<IObserver> observers;

        public GameServerObservable() {
            observers = new List<IObserver>();
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
            PlayerJoined();
        }

        public void Notify()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            Player player = (Player)observer;
            observers = observers.Where(o => ((Player)o).getID() != player.getID()).ToList();

            if(observers.Count > 0)
            {
                PlayerExited();
            }
        }


        // Simulate Events in Engine
        public void PlayerJoined()
        {
            Console.WriteLine("Player Joined Game");
            Notify();
        }

        public void PlayerExited()
        {
            Console.WriteLine("Player Left Game");
            Notify();
        }

        public void PlayerKilled()
        {
            Console.WriteLine("Player Killed");
            Notify();
        }

        // Allow observers to get updated data
        // Normally return data and return it conditionally, but this is just a simulation

        public void GetData()
        {
            Console.WriteLine("DATA REQUESTED...\n");
        }
    }
}
