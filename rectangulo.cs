using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class rectangulo:figura
    {
        //Se aplica el polimorfismo y sobrescribe el metodo de la clase base
        public override decimal area(decimal fBase, decimal Altura)
        {
            return fBase * Altura;
        }
    }
}
