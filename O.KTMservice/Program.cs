using DBServerAPI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace O.KTMservice
{
    internal class Program
    {
        static HttpClient client = new HttpClient();
        static Account user = null;
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            
            
        }

        public void UserLogin()
        {
            Login().GetAwaiter().GetResult();
        }

        static async Task Login()
        {
            //calling the method using method below.
            //Login().GetAwaiter().GetResult();
            

            Console.Write("username: ");
            string name = Console.ReadLine();
            Console.Write("password: ");
            string password = Console.ReadLine();
            
            string url = "http://localhost:5299/api/Account/login?name="+name+"&password="+password;
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response = await client.GetAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("username dan password salah");
            }

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    user = await response.Content.ReadAsAsync<Account>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}