using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_IEnumerable
{

    public class product:IComparable
    {
        private int price;
        private string name;

        public product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            product p =(product) obj;

            if(this.price > p.price) 
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
    internal class Product_Using_IComparable
    {
        static void Main(string[] args)
        {
            product laptop = new product  (4000, "Dell");
            product bag    = new product  (699, "HP Bag");

           int result = laptop.CompareTo(bag);

            if(result == 1)
            {
                Console.WriteLine("Dell Laptop price is more than HP Bag ");
            }
            else if (result == -1)
            {
                Console.WriteLine("Dell Laptop price is less than HP Bag ");
            }
            else
            {
                Console.WriteLine("Dell Laptop &  HP Bag equal price");

            }

        }
    }
}

