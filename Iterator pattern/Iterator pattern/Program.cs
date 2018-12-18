using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection[0] = new Item("0");
            collection[1] = new Item("1");
            collection[2] = new Item("2");
            collection[3] = new Item("3");
            collection[4] = new Item("4");
            collection[5] = new Item("5");
            collection[6] = new Item("6");
            collection[7] = new Item("7");
            collection[8] = new Item("8");

            Iterator iterator = collection.CreateIterator();

            iterator.Step = 2;
            
            Item item = iterator.First();

            while(!iterator.IsDone)
            {
                Console.WriteLine(item.Name);
                item = iterator.Next();
            }
            
            Console.ReadKey();
        }
    }
}
