using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class figura
    {
        public virtual decimal area(decimal fBase,decimal Altura)
        {
            return fBase * Altura/2;
        }
    }
}
