using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace DLL.SimuladorDelClima
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clima según la localización (#DetectaLaLógica: HTTPClient)");

            Console.WriteLine("Ingrese el país en el que está:");

            string pais = Console.ReadLine().ToLower();

            string urlPais = $"https://nominatim.openstreetmap.org/search?q={pais}&format=json";

            HttpClient httpClient = new HttpClient();
            
            HttpResponseMessage responsePais = httpClient.GetAsync(urlPais).Result;

            if (responsePais.IsSuccessStatusCode)
            {
                string contenidoPais = responsePais.Content.ReadAsStringAsync().Result;
                dynamic paisDeserialize = JsonConvert.DeserializeObject(contenidoPais);

                JArray jsonArray = JArray.Parse(contenidoPais);
                JToken result = jsonArray.FirstOrDefault();

                if (result != null)
                {
                    string displayName = (string)result["display_name"];
                    double lat = (double)result["lat"];
                    double lon = (double)result["lon"];
                    Console.WriteLine($"{displayName} - Lat: {lat}, Lon: {lon}");
                }
            }
            else
            {
                Console.WriteLine("No se pudo obtener la longitud y latitud para esa ubicación.");
            }

            Console.WriteLine("Ingrese la latitud de su ubicación:");
            string latitud = Console.ReadLine();

            Console.WriteLine("Ingrese la longitud de su ubicación:");
            string longitud = Console.ReadLine();

            string urlClima = $"https://api.open-meteo.com/v1/forecast?latitude={latitud}&longitude={longitud}&hourly=temperature_2m&timezone=auto&forecast_days=1";

            HttpResponseMessage responseClima = httpClient.GetAsync(urlClima).Result;

            if (responseClima.IsSuccessStatusCode)
            {
                string contenidoClima = responseClima.Content.ReadAsStringAsync().Result;
                dynamic clima = JsonConvert.DeserializeObject(contenidoClima);

                string timezone = clima.timezone;

                Console.WriteLine($"El clima en {timezone} va así por cada hora");

                JObject jsonObject = JObject.Parse(contenidoClima);
                JArray timeArray = (JArray)jsonObject["hourly"]["time"];
                JArray temperatureArray = (JArray)jsonObject["hourly"]["temperature_2m"];

                for (int i = 0; i < timeArray.Count; i++)
                {
                    string hour = ((string)timeArray[i]).Substring(11);
                    double temperature = (double)temperatureArray[i];
                    Console.WriteLine($"Hora {hour} = Temperatura {temperature}");
                }         
            }
            else
            {
                Console.WriteLine("No se pudo obtener el clima para esa ubicación.");
            }

            Console.WriteLine("Presiona una tecla para salir:");
            Console.ReadKey();
        }
    }
}
