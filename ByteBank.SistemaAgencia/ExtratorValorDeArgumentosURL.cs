using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string Url { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if(String.IsNullOrEmpty(url))
                throw new ArgumentException("O argumento url não pode ser uma string nua ou vazia.", nameof(url));
            
            Url = url;

            int index = url.IndexOf('?') + 1;
            _argumentos = url.Substring(index);
        }
        
        public string GetValor(string param)
        {
            param = param.ToUpper();
            string upperArgument = _argumentos.ToUpper();
            
            string termo = param + "=";
            int index = upperArgument.IndexOf(termo);

            string result = _argumentos.Substring(index + termo.Length);
            int indexNextParam = result.IndexOf('&');

           if(indexNextParam == -1)
                return result;
           else
                return result.Remove(indexNextParam);
        }
    }
}
