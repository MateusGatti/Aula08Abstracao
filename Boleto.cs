using System;

namespace Aula08Abstracao
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }

        public string bancoEmissor { get; set; }

        public string codigoDeBarras { get; set; }

        public string Registrar(){
            return "Boleto registrado!";
        }
    }
}