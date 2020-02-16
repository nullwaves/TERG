using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TERGEngine
{
    public class Engine
    {
        public List<Pool> Pools;
        public List<Pattern> Patterns;

        public static Random RNG = new Random();

        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All
        };

        public Engine()
        {
            Pools = new List<Pool>();
            Patterns = new List<Pattern>();
        }

        public static Engine Load(string file)
        {
            StreamReader reader = new StreamReader(file);
            string json = reader.ReadToEnd();
            // Engine retval = JsonConvert.DeserializeObject<Engine>(json); //old
            Engine retval = JsonConvert.DeserializeObject<Engine>(json, SerializerSettings); // new
            reader.Close();
            if (retval == null) throw new Exception("Corrupted Database. Please backup and delete file.");
            return retval;
        }

        public void Save(string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(JsonConvert.SerializeObject(this, Formatting.Indented, SerializerSettings));
                writer.Flush();
                writer.Close();
            }
        }

        public int GetNextPoolID()
        {
            //Find the pool with the highest ID number and return the next.
            int i = 0;
            foreach (Pool p in Pools)
            {
                if (p.ID >= i) i = p.ID;
            }

            return i + 1;
        }

        public Pool FindPoolById(int id)
        {
            foreach (Pool p in Pools)
            {
                if (p.ID == id) return p;
            }
            throw new Exception("Pool with that ID does not exist.");
        }

        public int GetNextPatternID()
        {
            //Find the Pattern with the highest ID number and return the next.
            int i = 0;
            foreach (Pattern p in Patterns)
            {
                if (p.ID >= i) i = p.ID;
            }

            return i + 1;
        }

        public Pattern FindPatternById(int id)
        {
            foreach (Pattern p in Patterns)
            {
                if (p.ID == id) return p;
            }
            throw new Exception("Pattern with that ID does not exist.");
        }
    }
}
