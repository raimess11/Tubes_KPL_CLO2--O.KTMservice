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
    internal class Program : LoginController
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            UserLogin();

            
            
        }
    }
}