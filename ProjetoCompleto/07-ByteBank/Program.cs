using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

            // a partir de agora os valores são definidos dentro da criação do objeto conta, através dos argumentos com os valores 867 e 86712540
            ContaCorrente conta = new ContaCorrente(876, 86712540);
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

            conta.Agencia = -10;

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGrabriela = new ContaCorrente(867, 86745820);

            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
