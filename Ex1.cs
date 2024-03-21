using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Ex1
    {
        public void executeEx1()
        {
            getVal();
            calcBhaskara();
            Console.WriteLine("X1 = " + x1 + "\nX2 = " + x2);
        }

        public double a, b, c, delta, x1, x2;
        void getVal()
        {
            
            Console.WriteLine("Insira o valor de a: "); 
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de c: ");
            c = int.Parse(Console.ReadLine());

        }

        void calcBhaskara()
        {
            delta = (b * b) * (4 * a * c); 

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta))/(2*a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            else
            {
                Console.WriteLine("Não ha raizes reais!");
            }
            
        }
    }
}
