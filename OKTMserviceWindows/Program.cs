namespace OKTMserviceWindows
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // panggil GUI pertama yang akan ditampilkan, ganti Login() ==> [nama GUI]()
            Application.Run(new GantiKTMMenu());
        }
    }
}