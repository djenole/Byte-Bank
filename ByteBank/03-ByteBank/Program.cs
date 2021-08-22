using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaVovo = new ContaCorrente();
            contaDaVovo.titular = "Vovó Alice";
            contaDaVovo.agencia = 863;
            contaDaVovo.numero = 2312;

            ContaCorrente contaDaMaira = new ContaCorrente();
            contaDaVovo.titular = "Maira";
            contaDaVovo.agencia = 2323;
            contaDaVovo.numero = 1341;

            Console.WriteLine(contaDaVovo == contaDaMaira); //false
            //Os objetos instanciados da mesma classe não são iguais, objetos apontam para a referência de endereço na memória.


            contaDaMaira = contaDaVovo;
            Console.WriteLine(contaDaMaira == contaDaVovo);

            contaDaVovo.saldo = 300;
            Console.WriteLine(contaDaMaira.saldo);
            Console.WriteLine(contaDaVovo.saldo);

            Console.ReadLine();


        }
    }
}
