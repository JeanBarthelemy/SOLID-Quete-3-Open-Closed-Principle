using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Open_Closed_Principle_Quete_4
{
    public class Metal : Craftable
    {
        public override string Type
        {
            get
            {
                return "Metal";
            }
        }
    }
}
