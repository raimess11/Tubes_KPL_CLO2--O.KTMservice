using System.Diagnostics.Eventing.Reader;

namespace DBServerAPI
{
    public class DataBase
    {
        private List<Account> userAccounts = new List<Account>() { (Account)new Staff("admin", "admin", 123), (Account)new Mahasiswa("rahma", "password", 1302210095) };
        private List<Object> dataPeryaratan = new List<object>();
        private List<Request> requests = new List<Request>();

        public bool Autentication(Account user)
        {
            foreach (Account account in userAccounts)
            {
                user.getUID().Equals(user.getUID());
                return true;
            };
            return false;
        }
    }
}
