using System.Text.Json;

// class untuk membaca dan menulis konfigurasi
namespace DBServerAPI
{
    public class BannerConfig
    {
        public Banner banner;

        public const string filePath = @"PersyaratanBanner.json";

        public BannerConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private Banner ReadConfigFile()
        {
            string configJsonData = File.ReadAllText(filePath);
            banner = JsonSerializer.Deserialize<Banner>(configJsonData);
            return banner;
        }

        private void SetDefault()
        {
            string penggunaanWebsite = "";
            string perbaikanKTM = "";
            string penggantianKTM = "";
            banner = new Banner(penggunaanWebsite, perbaikanKTM, penggantianKTM);
        }

        private void WriteNewConfigFile()
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonString = JsonSerializer.Serialize(banner, options);

                // Write to file
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.Write(jsonString);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine($"Error writing config file: {ex.Message}");
            }
        }
    }
}
