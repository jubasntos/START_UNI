using System;
using System.Collections.Generic;
using System.Text;

namespace START_UNI
{
    public abstract class Conta
    {

        public double saldo;

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return saldo;
        }
        public abstract void Saca(double valor);
    }

    public class ContaCorrente : Conta
    {
       

        public override void Saca(double valor)
        {
            this.saldo -= (valor * 0.03);
        }
       
    }

    public class ContaPoupanca : Conta
    {

        public override void Saca(double valor)
        {
            this.saldo -= (valor * 0.05 );
        }
      
    }
}
