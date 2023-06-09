﻿using System.Text.Json;

namespace O.KTMservice
{
    public static class CantumFoto
    {
        public static void serializeFoto(string path)
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

            Console.WriteLine(fileInfo.Length);

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

        public static Foto deserializeFoto(string path)
        {
            string jsonstr = File.ReadAllText(path);
            Foto imgMetadata = JsonSerializer.Deserialize<Foto>(jsonstr);
            return imgMetadata;
        }

        public static void saveFoto(string savePath, Foto image)
        {
            try
            {
                File.WriteAllBytes(savePath, image.imageByte);
            }catch(Exception e)
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