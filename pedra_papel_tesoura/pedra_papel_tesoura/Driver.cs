using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.pedra_papel_tesoura
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                Console.WriteLine("Digite sua escolha: 1- Pedra, 2- Papel, 3- Tesoura");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Play.Run(qsim)).Result;
            }
        }
    }
}