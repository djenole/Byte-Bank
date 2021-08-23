using System;
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
            

            bool resultadoSaque = conta.Sacar(50);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(resultadoSaque);

            conta.Depositar(500);
            Console.WriteLine(conta.saldo);

            ContaCorrente novaConta = new ContaCorrente();
            novaConta.titular = "um novo cliente";

            conta.Transferir(200, novaConta);

            Console.WriteLine("saldo da conta bruno: " + conta.saldo);
            Console.WriteLine("saldo da nova conta djenole: " + novaConta.saldo);
            bool resultadoTransferencia = conta.Transferir(200, novaConta);
            Console.WriteLine("valor da transferencia: " + resultadoTransferencia);

            novaConta.Transferir(70, conta);
            Console.WriteLine("saldo da conta bruno: " + conta.saldo);
            Console.WriteLine("saldo da nova conta djenole: " + novaConta.saldo);


            Console.ReadLine();
        }
    }
}
