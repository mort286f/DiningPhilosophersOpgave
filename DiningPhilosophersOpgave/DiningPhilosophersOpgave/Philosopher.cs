using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophersOpgave
{
    public class Philosopher
    {
        Fork _fork = new Fork();

        int philNumber;
        int fork1;
        int fork2;

        public Philosopher(int x)
        {
            this.philNumber = x;
            fork1 = Math.Min(x, (x + 1) % 5);
            fork2 = Math.Max(x, (x + 1) % 5);
        }

        public void Eat()
        {
            if (Fork.forks[fork1] == false && Fork.forks[fork2] == false)
            {
                lock (Fork._forkLock)
                {

                    try
                    {
                        //Monitor.Enter(Fork._forkLock);
                        Fork.forks[fork1] = true;
                        Fork.forks[fork2] = true;
                        Console.WriteLine("Philosopher " + philNumber + " eats..");
                        Thread.Sleep(2000);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        Fork.forks[fork1] = false;
                        Fork.forks[fork2] = false;
                        Monitor.PulseAll(Fork._forkLock);
                        //Monitor.Exit(Fork._forkLock);
                    }
                }
            }
        }

        public void Think()
        {
            Console.WriteLine("Philosopher " + philNumber + " thinks");
            Thread.Sleep(2000);
        }

        public void DoStuff()
        {
            while (true)
            {
                Eat();
                Think();
            }
        }
    }
}
