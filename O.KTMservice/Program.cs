using DBServerAPI;

namespace O.KTMservice
{
    internal class Program
    {
        static HttpClient client = new HttpClient();
        private static async Task Main(string[] args)
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5299/WeatherForecast");
            if (response.IsSuccessStatusCode)
            {
                List<WeatherForecast> outputWeather = await response.Content.ReadAsAsync<List<WeatherForecast>>();

                foreach (WeatherForecast weather in outputWeather)
                {
                    Console.WriteLine("Nama cuaca = " + weather.Summary);
                }
            }

            Console.WriteLine("Hello, World!");
        }
    }
}