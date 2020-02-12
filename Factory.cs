using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Open_Closed_Principle_Quete_4
{
    public sealed class Factory
    {
        public Production Craft(IEnumerable<Craftable> craftables)
        {
            Production newProduction = new Production(craftables);
            return newProduction;
        }
    }
}
