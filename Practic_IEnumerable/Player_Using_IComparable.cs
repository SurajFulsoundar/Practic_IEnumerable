using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_IEnumerable
{
    public class Player_Using_IComparable : IComparable
    {
        private int runs;
        private string name;

        public Player_Using_IComparable(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            // convert object to player class

            Player_Using_IComparable p = (Player_Using_IComparable)obj; //  p hold info of virat

            // this --> sachin, p --> virat

            if (this.runs > p.runs)
            {
                return 1;
            }
            else if (this.runs < p.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"{runs} --> {name}";
        }
       

    }
    internal class player_Compair
    {
        static void Main(string[] args)
        {
            Player_Using_IComparable sachin = new Player_Using_IComparable(8000, "Sachin");
            Player_Using_IComparable virat = new Player_Using_IComparable(10000, "Virat");

            int result = sachin.CompareTo(virat);

            if (result == 1)
            {
                Console.WriteLine("Sachin has more runs than Virat");
            }
            else if (result == -1)
            {
                Console.WriteLine("Sachin has less runs than Virat");

            }
            else
            {
                Console.WriteLine("Sachin & Virat equal runs");

            }

        }
    }


}


