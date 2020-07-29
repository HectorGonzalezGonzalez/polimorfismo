using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal fBase = 5;
            Decimal altura = 7;
            Decimal areaRectangulo=new rectangulo().area(fBase,altura);//usa el polimosfismo
            Decimal areaTriangulo = new Triangulo().area(fBase, altura);//no aplica el polimosfismo pero utiliza el metodo heredado
            Console.WriteLine($"Area del rectangulo:{areaRectangulo}");
            Console.WriteLine($"Area del triangulo:{areaTriangulo}");
            Console.ReadKey();
        }
    }
}
