using System;

namespace DLL.SimuladorDelClima
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el código postal de su ubicación:");
            string codigoPostal = Console.ReadLine();

            string url = "https://api.openweathermap.org/data/2.5/weather?zip=" + codigoPostal + ",us&appid=your_api_key&units=metric";

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string contenido = response.Content.ReadAsStringAsync().Result;
                dynamic clima = JsonConvert.DeserializeObject(contenido);

                string ciudad = clima.name;
                double temperatura = clima.main.temp;
                double humedad = clima.main.humidity;

                Console.WriteLine("El clima en {0} es de {1}°C y la humedad es del {2}%.", ciudad, temperatura, humedad);
            }
            else
            {
                Console.WriteLine("No se pudo obtener el clima para ese código postal.");
            }

            Console.ReadLine();
        }
    }
}
