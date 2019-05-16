using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.BellsTest_Qsharp
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                Result[] init = new Result[] { Result.Zero, Result.One };
                var res = Bells.Run(qsim, 1000).Result;
                var (z, o) = res;
                Console.WriteLine("Valores O: " + z);
                Console.WriteLine("Valores 1: " + o);
            }
        }
    }
}