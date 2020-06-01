namespace Aula7Encapsulamento
{
    public class Cartao
    {
        public string numero {get; set;}
        public string bandeira { get; set; }
        private string token { get; set; }
        protected int cvc {get; set;}

        public string AprovarCompra(){
            return "Compra aprovada no valor de...";
        }

        private bool ValidarTolken(string tolken){

            if(tolken != null && tolken != ""){
                return true;
            }
            return false;

        }

            protected bool ValidarCompra(){
                return true;
            }

    
    }
}