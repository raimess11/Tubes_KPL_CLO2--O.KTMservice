using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OKTMserviceWindows
{
    internal class LoginController1
    {
        static HttpClient client = new HttpClient();
        static Account user = null;

        static public void UserLogin()
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

            string url = "http://localhost:5299/api/Account/login?name=" + name + "&password=" + password;
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response = await client.GetAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("username dan password salah");
                return;
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
                return;
            }

            Console.WriteLine(user.ToString());

        }
    }
}
