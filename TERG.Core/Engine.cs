using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TERG.Core.Interfaces;
using TERG.Core.Managers;
using TERG.Core.Models;
using TERG.Core.Services;

namespace TERG.Core
{
    public class Engine
    {
        internal PoolManager PoolManager;
        internal PatternManager PatternManager;
        internal IStorageService StorageService;
        public Composer Composer { get; }
        public ShorthandService ShorthandService { get; }
        public static Random RNG = new Random();

        public Engine()
        {
            Init(new Pool[0], new Pattern[0]);
            Composer = new Composer(this);
            ShorthandService = new ShorthandService(this);
            StorageService = new FlatfileStorageService();
        }

        private void Init(Pool[] pools, Pattern[] patterns)
        {
            PoolManager = new PoolManager(pools);
            PatternManager = new PatternManager(patterns);
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
        internal static IStorageService GetDefaultStorageServiceInstance()
        {
            return new FlatfileStorageService();
        }

        public static Engine Load(string file)
        {
            (Pool[], Pattern[]) data = GetDefaultStorageServiceInstance().Load(file);
            Engine engine = new Engine();
            engine.Init(data.Item1, data.Item2);
            return engine;
        }

        public bool Save(string file)
        {
            return StorageService.Save(GetPools().ToArray(), GetPatterns().ToArray(), file);
        }
    }
}