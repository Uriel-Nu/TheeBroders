using System.Reflection;

namespace TheeBroders.Client.Servicios
{
    public class HttpRespuesta<T>
    {
        

        

        public HttpRespuesta(T respuesta ,bool error,HttpResponseMessage httpResponseMessage)
        {
            Respuesta = respuesta;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

        public HttpRespuesta(object value1, object value2, Task<HttpResponseMessage> respuesta)
        {
        }

        public T Respuesta { get; }
        public bool Error { get; }
        public HttpResponseMessage HttpResponseMessage { get; }
        public object Value { get; }
        public object Value1 { get; }
    }
}
