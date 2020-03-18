using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.PedraPapelETesoura
{
    class Driver
    {
        static void ShowChoice(int a)
        {
            switch (a)
            {
                case 0:
                    Console.WriteLine("Pedra");
                    break;
                case 1:
                    Console.WriteLine("Papel");
                    break;
                case 2:
                    Console.WriteLine("Tesoura");
                    break;
            }
        }

        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                Console.WriteLine("Digite sua escolha (0 = Pedra, 1 = Papel, 2 = Tesoura):");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Play.Run(qsim).Result);

                Console.WriteLine("Você: ");
                ShowChoice(a);
                Console.WriteLine("Computador: ");
                ShowChoice(b);

                int c = a - b;

                if (c == -2 || c == 1)
                {
                    Console.WriteLine("Você ganhou!");
                }
                else if (c == 0)
                {
                    Console.WriteLine("Você empatou!");
                }
                else if (c == -1 || c == 2)
                {
                    Console.WriteLine("Você perdeu!");
                }
            }
        }
    }
}