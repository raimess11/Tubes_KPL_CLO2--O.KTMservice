using System.Text.Json;

namespace MenyantumkanDokumen
{
    public static class CantumFoto
    {
        public static Foto holdFotoAPI(string path) //image file into array of byte
        {
            // Load file meta data with FileInfo
            FileInfo fileInfo = new FileInfo(path);

            // The byte[] to save the data in
            byte[] data = new byte[fileInfo.Length];

            // Load a filestream and put its content into the byte[]
            using (FileStream fs = fileInfo.OpenRead())
            {
                fs.Read(data, 0, data.Length);
            }

            // Delete the temporary file \\Note: perlu buat temporary fileinfo
            //fileInfo.Delete();

            Foto e = new Foto();
            e.imageByte = data;
            return e;
        }

        public static void serializeFoto(string path) //serilize Objek Foto into json
        {

            // Load file meta data with FileInfo
            FileInfo fileInfo = new FileInfo(path);

            // The byte[] to save the data in
            byte[] data = new byte[fileInfo.Length];

            // Load a filestream and put its content into the byte[]
            using (FileStream fs = fileInfo.OpenRead())
            {
                fs.Read(data, 0, data.Length);
            }

            // Delete the temporary file \\Note: perlu buat temporary fileinfo
            //fileInfo.Delete();

            //[Opsional] Merapikan format JSON
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            //Melakukan perubahan object menjadi string(Serialization)
            Foto e = new Foto();
            e.imageByte = data;
            string jsonString = JsonSerializer.Serialize(e, options);
            //Membuat file JSON yg berisi string hasil serialization
            File.WriteAllText(@"ImageMetaData.json", jsonString);

        }

        public static Foto deserializeFoto(string path) //from json to Objek Foto
        {
            string jsonstr = File.ReadAllText(path);
            Foto imgMetadata = JsonSerializer.Deserialize<Foto>(jsonstr);
            return imgMetadata;
        }

        public static void saveFoto(string savePath, Foto image) //from object Foto/byte[] to Image file
        {
            try
            {
                File.WriteAllBytes(savePath, image.imageByte);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Template untuk menyimpan byte data dari foto
        public class Foto
        {
            public byte[] imageByte { get; set; }
        }
    }
}