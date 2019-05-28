using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QApplication
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                Console.WriteLine("Digite a mensagem que quer mandar (1 ou 0):");
                int msg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mensagem Teleportada: " + Convert.ToInt32(SendMessage.Run(qsim, msg).Result));
            }
        }
    }
}