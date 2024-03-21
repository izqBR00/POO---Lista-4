using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Ex3
    {
        public void executeEx3()
        {
            getData();
            calc();
            Console.WriteLine("Numero do matricula: {0}", numero);
            Console.WriteLine("Salario do mes: R${0:F2}", salario);
        }

        int numero;
        float horas, valorHora, salario;
        void getData()
        {
            Console.WriteLine("Insira o numero de matricula do funcionario: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de horas trabalhadas: ");
            horas = float.Parse(Console.ReadLine());

            Console.Write("Insira quanto o funcionario recebe por hora: \nR$");
            valorHora = float.Parse(Console.ReadLine());
        }

        void calc()
        {
            salario = valorHora * horas;
        }

    }
}
