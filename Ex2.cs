using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    internal class Ex2
    {
        public void executeEx2()
        {
            getData();
            calc();
            Console.WriteLine(mensagem);
        }
        string s, primeiro, segundo, hora, gen, mensagem;
        int genero, inthora;

        
        void getData()
        {
            Console.WriteLine("Insira seu nome: ");
            s = Console.ReadLine();
            string[] n = s.Split(" ");
            primeiro = n[0];
            segundo = n[1];

            Console.WriteLine("Insira seu genero [1] para Masculino e [2] para Feminino");
            genero = int.Parse(Console.ReadLine());

            Console.WriteLine("Horario de entrada (hh:mm): ");
            hora = Console.ReadLine();
        }

        void calc()
        {
            DateTime.TryParseExact(hora, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime horas);
            inthora = horas.Hour;

            if (inthora < 12 && inthora > 00)
            {
                mensagem = "Bom dia";
            }
            else if (inthora >= 12 && inthora < 18)
            {
                mensagem = "Boa tarde";
            }
            else
            {
                mensagem = "Boa noite";
            }

            if (genero == 1)
            {
                gen = "Sr.";                
            }
            else if (genero == 2) 
            {
                gen = "Sra.";         
            }

            mensagem = mensagem + " " + gen + " " + primeiro + " " + segundo;



        }
    }
}
