﻿using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Globalization;

namespace TheeBroders.Client.Servicios
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient http;

        public HttpService(HttpClient http)
        {
            this.http = http;
        }


        public async Task<HttpRespuesta<T>> get<T>(string url)

        {
            var response = await http.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var respuesta = await deserealizarRespuesta<T>(response);
                return new HttpRespuesta<T>(respuesta, false, response);
            }

            else
            {
                return new HttpRespuesta<T>(default, true, response);
            }
        }
         
        public async Task<HttpRespuesta<object>> Post<T>(string url, T enviar)
        {


            try
            {
                var enviarJson = JsonSerializer.Serialize(enviar);
                var enviarContent = new StringContent(enviarJson,
                                                      Encoding.UTF8,
                                                      "application/json");
                var respuesta = await http.PostAsync(url, enviarContent);
                return new HttpRespuesta<object>(null,
                                                 !respuesta.IsSuccessStatusCode,
                                                 respuesta);
            }
            catch (Exception e) { throw; }

        }
        private async Task<T> deserealizarRespuesta<T>(HttpResponseMessage response)
        {
            var respuestaStr = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestaStr,
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
    

