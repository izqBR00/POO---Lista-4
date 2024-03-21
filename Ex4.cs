using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Ex4
    {
        public void executeEx4()
        {
            getData();
            choice();
        }
        double A, B, C;
        int escolha;
        void getData()
        {
            Console.WriteLine("Seja bem vindo! Insira os valores:");
            Console.Write("A = ");
            A = double.Parse(Console.ReadLine());            
            Console.Write("B = ");
            B = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            C = double.Parse(Console.ReadLine());
        }

        void choice()
        {
            int n = 0;
            while (n == 0)
            {
                Console.WriteLine("Escolha o calculo que deseja realizar:\n[1] a area do triangulo retangulo com base A e altura C\n[2] a area do circulo de raio C\n[3] a area do trapezio que tem base maior A, menor B e altura C\n[4] a area do quadrado de lado B\n[5] a area do retangulo de base A e altura B\n[6] sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1: Console.WriteLine("\nArea do triangulo = " + calcTriangle() + "\n"); break;

                    case 2: Console.WriteLine("\nArea do circulo = " + calcCircle() + "\n"); break;

                    case 3: Console.WriteLine("\nArea do trapezio = " + calcTrapeze() + "\n"); break;

                    case 4: Console.WriteLine("\nArea do quadrado = " + calcSquare() + "\n"); break;

                    case 5: Console.WriteLine("\nArea do retangulo = " + calcRectangle() + "\n"); break;

                    case 6: n = 1; break;

                    default: Console.WriteLine("Insira uma opção válida"); break;
                }
            }
            
            
        }

        public double calcTriangle()
        {
            return (A * C) / 2;
        }

        public double calcCircle()
        {
            return 3.14 * C * C;
        }

        public double calcTrapeze()
        {
            return ((A + B) * C) / 2; 
        }

        public double calcSquare()
        {
            return B * B;
        }

        public double calcRectangle()
        {
            return A * B;
        }
    }
}
