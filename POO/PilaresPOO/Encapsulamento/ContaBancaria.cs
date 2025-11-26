using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {


        private float Saldo;
        
        public ContaBancaria()
        {
            
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
         if(SaldoInicial > 0)
            {
                
                Saldo = SaldoInicial;

            }
            else
            {
                
             Saldo = 0;

            }


        }

        public void Despositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor Invalido");
                

            }
            else
            {
                
               Saldo += valor;
            }
            
        
        }

        public float GetSaldo()
        {
            return Saldo;

        }


         public void Sacar (float valor)
        {
            if(valor >= 0 && valor <= Saldo)
            {
              Saldo -= valor;
              Console.WriteLine($"Saque efetuado com sucesso!");
                

            }
            else
            {
            Console.WriteLine($"Saldo insuficiente ou negativo");
            
            }
            

        }


    }
}