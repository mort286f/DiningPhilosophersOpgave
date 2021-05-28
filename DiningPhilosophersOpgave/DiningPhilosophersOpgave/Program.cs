using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DiningPhilosophersOpgave
{
    class Program
    {

        static void Main(string[] args)
        {

            Philosopher p1 = new Philosopher(0);
            Philosopher p2 = new Philosopher(1);
            Philosopher p3 = new Philosopher(2);
            Philosopher p4 = new Philosopher(3);
            Philosopher p5 = new Philosopher(4);

            //Thread instances for each philosopher at the dining table
            Thread philo1 = new Thread(p1.DoStuff);
            Thread philo2 = new Thread(p2.DoStuff);
            Thread philo3 = new Thread(p3.DoStuff);
            Thread philo4 = new Thread(p4.DoStuff);
            Thread philo5 = new Thread(p5.DoStuff);

            philo1.Start();
            philo2.Start();
            philo3.Start();
            philo4.Start();
            philo5.Start();

            Console.Read();
        }
    }
}
