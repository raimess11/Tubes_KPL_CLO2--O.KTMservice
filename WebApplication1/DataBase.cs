using System.Diagnostics.Eventing.Reader;

namespace DBServerAPI
{
    public class DataBase
    {
        static private List<Account> userAccounts { get; set; } = new List<Account>() { (Account)new Staff("admin", "admin", 123), (Account)new Mahasiswa("rahma", "password", 1302210095) }; 
        private List<Object> dataPeryaratan = new List<object>();
        private List<Request> requests = new List<Request>();

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
    }
}
