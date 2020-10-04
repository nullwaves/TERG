using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TERG.Core.Managers;
using TERG.Core.Models;

namespace TERG.Core
{
    public class Engine
    {
        public List<Pool> Pools;
        internal PatternManager PatternManager;
        public Composer Composer { get; }

        public static Random RNG = new Random();

        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All
        };

        public Engine()
        {
            Pools = new List<Pool>();
            PatternManager = new PatternManager();
            Composer = new Composer(this);
        }

        public Pattern AddPattern(Pattern p) => PatternManager.Add(p);

        public IEnumerable<Pattern> GetPatterns() => PatternManager.GetAll();

        public Pattern GetPatternByID(int id) => PatternManager.GetByID(id);

        public bool RemovePattern(int id) => PatternManager.RemovePattern(id);

        public static Engine Load(string file)
        {
            StreamReader reader = new StreamReader(file);
            string json = reader.ReadToEnd();
            Engine retval = JsonConvert.DeserializeObject<Engine>(json, SerializerSettings);
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
            return Pools.Where(x => id == x.ID).FirstOrDefault();
        }
    }
}