using System.Dynamic;
using System.Net;

namespace integraApi.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode codigoHttp { get; set; }
        public T? DadosRetorno { get;set; }
        public ExpandoObject? ErroRetorno { get; set; }
    
    }
}
