﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Saibaba";

            Console.WriteLine(conta.saldo);
            conta.Sacar(50);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}