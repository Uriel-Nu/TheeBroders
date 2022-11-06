namespace TheeBroders.Client.Servicios
{
    public interface IHttpService
    {
        Task<HttpRespuesta<T>> get<T>(string url);
        Task<HttpRespuesta<object>> Post<T>(string url, T enviar); 
    }
}