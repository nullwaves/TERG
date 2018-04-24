using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TERGEngine
{
    public class Engine
    {
        public List<Pool> Pools;
        public List<Pattern> Patterns;

        public Engine()
        {
            Pools = new List<Pool>();
            Patterns = new List<Pattern>();
        }

        public Engine Load(string file)
        {
                StreamReader reader = new StreamReader(file);
                Engine retval = JsonConvert.DeserializeObject<Engine>(reader.ReadToEnd());

                return retval;
        }

        public void Save(string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(JsonConvert.SerializeObject(this));
                writer.Flush();
                writer.Close();
            }
        }
    }
}
