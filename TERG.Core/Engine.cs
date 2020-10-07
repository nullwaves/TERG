using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TERG.Core.Managers;
using TERG.Core.Models;
using TERG.Core.Services;

namespace TERG.Core
{
    public class Engine
    {
        internal PoolManager PoolManager;
        internal PatternManager PatternManager;
        public Composer Composer { get; }
        public ShorthandService ShorthandService { get; }

        public static Random RNG = new Random();

        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All
        };

        public Engine()
        {
            PoolManager = new PoolManager();
            PatternManager = new PatternManager();
            Composer = new Composer(this);
            ShorthandService = new ShorthandService(this);
        }

        // Pattern Methods
        public Pattern AddPattern(Pattern p) => PatternManager.Add(p);

        public IEnumerable<Pattern> GetPatterns() => PatternManager.GetAll();

        public Pattern GetPatternByID(int id) => PatternManager.GetByID(id);

        public bool RemovePattern(int id) => PatternManager.RemovePattern(id);

        public bool UpdatePattern(Pattern p) => PatternManager.Update(p);

        // Pool Methods
        public Pool AddPool(Pool p) => PoolManager.Add(p);

        public IEnumerable<Pool> GetPools() => PoolManager.GetAll();

        public Pool GetPoolByID(int id) => PoolManager.GetByID(id);

        public bool RemovePool(int id) => PoolManager.RemovePool(id);

        public bool UpdatePool(Pool p) => PoolManager.Update(p);

        // TODO: Refactor Saving/Loading an engine state
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
    }
}