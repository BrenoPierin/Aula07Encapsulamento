using System;

namespace Aula7Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao cartao = new Cartao();
            cartao.bandeira = "mastercard";
            cartao.numero = "2043230900-07";
            cartao.AprovarCompra();

            Mastercard master = new Mastercard();
            master.parcelas = 5;
            master.ComprarComDescontoMastercard(20f);
            
        }
    }
}
