using System.Net;

namespace Limpou.Faxinas.Controllers.RequestModels
{
    public class HttpResponseModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Mensagem { get; set; }
        public object Corpo { get; set; }
    }
}
