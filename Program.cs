using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 1200f;

            System.Console.WriteLine("Deseja aumentar seu limite em quanto?");
            float acrescimo = float.Parse(Console.ReadLine());
            
            visa.AumentarLimite(acrescimo);

            System.Console.WriteLine("Seu limite agora é de R$:"+visa.limite);

            System.Console.WriteLine("Quando voce deseja pagar?");
            float valorPago = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Você pagou R$:"+valorPago);
            


            
            


        }
    }
}
