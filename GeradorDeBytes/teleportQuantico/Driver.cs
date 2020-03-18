using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.GeradorDeBytes
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                int bitCount = 16;

                var res = BinaryGen.Run(qsim, bitCount).Result;

                int finalBits = 0;
                Console.Write("Bits gerados: ");
                for (int i = bitCount-1; i >= 0; i--)
                {
                    finalBits += (int)(Math.Pow(2, i) * res[i]);
                    Console.Write(res[i]);
                }
                Console.WriteLine("\nNúmero gerado: " + finalBits + "\nTamanho: " + bitCount + " bit(s) [" + bitCount/8 + " byte(s)].");
            }
        }
    }
}