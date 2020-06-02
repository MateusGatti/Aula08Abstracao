namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        protected string token = "5r4325r324r43rr53g44365356456f65f6ytffwef34f3";

        public string bandeira { get; set; }

        public int numero { get; set; }

        public string cvv { get; set; }

        public string titular { get; set; }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
    
}