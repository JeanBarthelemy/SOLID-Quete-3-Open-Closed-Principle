using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Open_Closed_Principle_Quete_4
{
    public class Production
    {
        public IEnumerable<Craftable> Craftables { get; set; }

        public Production(IEnumerable<Craftable> craftables)
        {
            Craftables = craftables;
        }

        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (Craftable craftables in Craftables)
            {
                description += "\t" + craftables.Type;
            }
            return description;
        }
    }
}
