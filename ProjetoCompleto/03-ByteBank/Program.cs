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
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            //ISSO É APRESENTADO COMO FALSE, PQ OS OBJETOS SÃO REFERENCIAS NA CLASSE E APONTAM PRA LUGARES DIFERENTES NA MEMORIA, LOGO, COMO NÃO SÃO VALORES, DEIXAM DE SER IGUAIS
            Console.WriteLine("IGUALDADE DE TIPO DE REFERENCIA: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            // ISSO É APRESENTADO COMO TRUE PQ AS VARIAVEIS GUARDAM VALORES, E ESSES VALORES, SE COMPARADOS, SÃO IGUAIS
            Console.WriteLine("IGUALDADE DE TIPO DE VALOR: " + (idade == idadeMaisUmaVez));

            // AGORA TEMOS DUAS VARIAVEIS QUE GUARDAM AS REFERENCIAS PRO MESMO OBJETO NA MEMORIA DO COMPUTADOR, LOGO, AGORA SERÁ TRUE
            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);

            // O MESMO VALOR SERÁ APRESENTADO EM AMBAS AS VARIAVEIS, POIS AMBAS APONTAM PRO MESMO ENDEREÇO DE MEMORIA NO COMPUTADOR.
            // E SE UMA É ALTERADA, COMO A OUTRA ESTÁ TAMBÉM APONTANDO PRO MESMO LUGAR, ELA IMPRIME O VALOR IGUAL AO QUE FOI ALTERADO,
            // POIS AMBAS TEM A MESMA REFERENCIA
            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);


            if(contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }


            Console.ReadLine();
        }
    }
}
