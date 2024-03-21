using System;
using System.Collections;

namespace Lista4
{
    class Lista4
    {
        static void Main(string[] args)
        {
            Lista4 l = new Lista4();
            l.choose();
            
        }

        Ex1 ex1 = new Ex1();
        Ex2 ex2 = new Ex2();
        Ex3 ex3 = new Ex3();
        Ex4 ex4 = new Ex4();
        int choice;

        void choose()
        {
            Console.WriteLine("Selecione o exercicio\n | 1 | 2 | 3 | 4 |");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: ex1.executeEx1(); break;

                case 2: ex2.executeEx2(); break;

                case 3: ex3.executeEx3(); break;

                case 4: ex4.executeEx4(); break;

                
            }

        }
    }
}