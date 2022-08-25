using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoExercicio
{
    internal class Conta
    {
        private int _numeroConta;
        private string _nomeTitular;
        private double _saldoConta = 0;

        public Conta(int numeroConta, string nomeTitular, double depositoInicial = 0)
        {
            _numeroConta = numeroConta;
            _nomeTitular = nomeTitular;

            if (depositoInicial != 0)
            {
                this._saldoConta += depositoInicial;
            } else
            {
                return;
            }
        }

        public int NumeroConta
        {
            get { return _numeroConta; }
            set { }

        }
        public string NomeTitular
        {
            get { return _nomeTitular; }
            set { _nomeTitular = value; }
        }
        public double SaldoConta
        {
            get {return _saldoConta;}
        }

        // Os valores comentados abaixo, foram os antigos, pra poder utilizar o Console.WriteLine;

        // public void Depositar(double valorDeposito)
        public void Depositar()

        {
            double valorDeposito = 0;
            Console.WriteLine("Digite o valor para deposito");
            // valorDeposito = Double.Parse(Console.ReadLine());
            valorDeposito = Double.Parse(Console.ReadLine());


            this._saldoConta += valorDeposito;

            Console.WriteLine(ToString());
        }

        // public void Sacar(double valorSaque)
        public void Sacar()
        {

            Console.WriteLine("Digite o valor para realizar o saque");
            // valorSaque = Double.Parse(Console.ReadLine());
            double valorSaque = Double.Parse(Console.ReadLine());
            this._saldoConta = (this._saldoConta - valorSaque) - 5.00;

            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Dados da conta: \n Conta: {this.NumeroConta} Titular: {this.NomeTitular} Saldo: $ {this.SaldoConta.ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }

}
