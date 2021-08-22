using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ContaCorrente contaDoDjenole = new ContaCorrente();
            contaDoDjenole.titular = "Djenole";
            contaDoDjenole.numero = 666;
            contaDoDjenole.saldo = 1323;
            contaDoDjenole.agencia = 34;
            Console.WriteLine(contaDoDjenole.titular);
            Console.WriteLine(contaDoDjenole.numero);
            Console.WriteLine(contaDoDjenole.agencia);
            Console.WriteLine(contaDoDjenole.saldo);
            Console.ReadLine();
           
        }
    }
}
