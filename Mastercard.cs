namespace Aula7Encapsulamento
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }

        public void ComprarComDescontoMastercard(float desconto){
            cvc = 245;
            System.Console.WriteLine($"O pedido no total de X, com desconto de {desconto}%, com total de {parcelas} parcelas.");
        }
    }
}