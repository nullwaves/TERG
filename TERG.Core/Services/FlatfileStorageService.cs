using Newtonsoft.Json;
using System.IO;
using TERG.Core.Interfaces;
using TERG.Core.Models;

namespace TERG.Core.Services
{
    internal class FlatfileStorageService : IStorageService
    {
        internal FlatfileStorageService()
        {
        }

        bool IStorageService.Save(Pool[] pools, Pattern[] patterns, string filePath)
        {
            try
            {
                FileStream fileStream;
                if (!File.Exists(filePath))
                {
                    fileStream = File.Create(filePath);
                }
                else
                {
                    fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
                }

                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    var dump = (pools, patterns);
                    writer.Write(JsonConvert.SerializeObject(dump, Formatting.Indented));
                    writer.Flush();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        (Pool[], Pattern[]) IStorageService.Load(string filePath)
        {
            try
            {
                string json;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }
                var data = JsonConvert.DeserializeObject<(Pool[], Pattern[])>(json);
                return data;
            }
            catch
            {
                return (new Pool[0], new Pattern[0]);
            }
        }
    }
}