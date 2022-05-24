using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extract = new ExtratorValorDeArgumentosURL(url);

            string valor = extract.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);
            
            string valor2 = extract.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valor2);
           
            string valor3 = extract.GetValor("VALOR");
            Console.WriteLine("Valor: " + valor3);

            Console.ReadLine();
        }
    }
}
