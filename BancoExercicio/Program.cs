using System;

namespace BancoExercicio
{
    class Programa
    {
        public static void Main(string[] args)
        {
            double valorDeposito;

            Console.WriteLine("********************--- SEJA BEM VINDO AO BANCO ELPODEROSO***************----");
            Console.WriteLine("Digite o número que deseja para a Conta");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Muito bem, agora digite o seu nome completo\n");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? (S/N)");
            char resposta = char.Parse(Console.ReadLine());
            if(resposta == 's')
            {
                Console.WriteLine("Digite o valor que deseja depositar inicialmente");
                valorDeposito = Double.Parse(Console.ReadLine());
            }
            else
            {
                valorDeposito = 0;
            }

            Conta c = new Conta(numeroConta, nomeCompleto, valorDeposito);
            Console.WriteLine(c);

            c.Depositar();
            c.Sacar();

            /*
            Conta c = new Conta(2680, "Rafael Oliveira", 500);

            c.Depositar(250);
            Console.WriteLine(c.SaldoConta);
            c.Sacar(250);
            Console.WriteLine(c.SaldoConta);
            */
        }
    }

}