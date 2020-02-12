using System;
using System.Collections.Generic;

namespace SOLID_Open_Closed_Principle_Quete_4
{
    public class Program
    {
        public static void Main()
        {
            Factory factory = new Factory();

            IEnumerable<Craftable> craftables = new List<Craftable>
            {
                new Wood(),
                new Metal()
            };

            Production production = factory.Craft(craftables);

            Console.WriteLine(production);
        }
    }
}
