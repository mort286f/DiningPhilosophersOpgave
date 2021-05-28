using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningPhilosophersOpgave
{
    public class Fork
    {
        public static object _forkLock = new object();
        public static bool[] forks = new bool[5];

        public Fork()
        {

        }
    }
}
