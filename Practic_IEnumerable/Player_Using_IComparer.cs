using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_IEnumerable
{

    public class Player
    {
        private int runs;
        private string name;
        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public int Runs
        {
            get { return runs; }
        }
        public override string ToString()
        {
            return $"{runs} -> {name}";
        }
    }

    public class CheckRuns : IComparer
    {
        public int Compare(object x, object y)
        {
            Player p1 = (Player)x;// sachin
            Player p2 = (Player)y; // virat

            if (p1.Runs > p2.Runs)
            {
                return 1;
            }
            else if (p1.Runs < p2.Runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class Player_Using_IComparer
    {
        static void Main(string[] args)
        {
            Player sachin = new Player(7000, "Sachin");
            Player virat = new Player(7000, "Virat");
            CheckRuns c1 = new CheckRuns();
            int result = c1.Compare(sachin, virat);
            // int result=sachin.CompareTo(virat);
            if (result == 1)
            {
                Console.WriteLine("Sachin has more runs than virat");
            }
            else if (result == -1)
            {
                Console.WriteLine("Sachin has less runs than virat");
            }
            else
            {
                Console.WriteLine("Sachin & virat has equal runs");
            }
        }
    }


}























