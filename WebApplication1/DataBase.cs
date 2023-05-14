namespace DBServerAPI
{
    public class DataBase
    {
        private List<KeyValuePair<string, string>> userAccounts;
        private List<Object> dataPeryaratan;
        public static List<Request> requests = new List<Request>();

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
    }
}
