using System;
using System.Collections.Generic;
using System.Text;

namespace START_UNI
{
    public abstract class Conta
    {
        public abstract void Saca(double valor);
    }

    public class ContaCorrente : Conta
    {
        public double Saldo { get; private set; }

        public override void Saca(double valor)
        {
            this.Saldo -= (valor * 0.03);
        }
       
    }

    public class ContaPoupanca : Conta
    {
        public double Saldo { get; private set; }

        public override void Saca(double valor)
        {
            this.Saldo -= (valor * 0.05 );
        }
      
    }
}
