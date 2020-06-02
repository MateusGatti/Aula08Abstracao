namespace Aula08Abstracao
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }

        public string Transferir(){
            return "Transferencia completa!";
        }
        public string PagarTitulo(){
            return "Titulo Pago!";
        }
    }
}