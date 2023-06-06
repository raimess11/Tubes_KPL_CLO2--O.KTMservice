using System.Diagnostics.Eventing.Reader;
﻿using System.Runtime.CompilerServices;


namespace DBServerAPI
{
    public class DataBase
    {
        static private List<Account> userAccounts { get; set; } = new List<Account>() { (Account)new Staff("admin", "admin", 123), (Account)new Mahasiswa("rahma", "password", 1302210095) }; 
        static private List<Object> dataPeryaratan = new List<object>();
        static public List<Request> requests = new List<Request>();
        
        public DataBase() { }
        public static void addRequest(Request request)
        {
            requests.Add(request);
        }

        public static List<Request> getRequests()
        {
            return requests;
        }

        public static void removeRequest(int id)
        {
            requests.RemoveAt(id);
        }

        static public bool Autentication(Account user)
        {
            try
            {
                foreach (Account account in userAccounts)
                {
                    account.getUID().Equals(user.getUID());
                    return true;
                };
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("anda dalam mode guest, silahkan melakukan login terlebih dahulu");
                throw ex;
            }
            return false;
        }

        static public List<Account> getUserAccounts() {  return userAccounts; }
        static public void addAccount(Account account) { userAccounts.Add(account); }
    }
}
