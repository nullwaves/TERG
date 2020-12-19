using System.Collections.Generic;
using System.Linq;
using TERG.Core.Models;

namespace TERG.Core.Managers
{
    internal class PoolManager
    {
        private readonly List<Pool> _pools;

        internal PoolManager()
        {
            _pools = new List<Pool>();
        }

        internal PoolManager(IEnumerable<Pool> pools)
        {
            _pools = pools.ToList();
        }

        internal Pool Add(Pool p)
        {
            p.ID = GetNextID();
            if (Validate(p))
            {
                _pools.Add(p);
                return p;
            }
            return new Pool();
        }

        internal IEnumerable<Pool> GetAll()
        {
            return _pools;
        }

        internal Pool GetByID(int id)
        {
            return _pools.Where(x => id == x.ID).FirstOrDefault();
        }

        private int GetNextID()
        {
            int i = 0;
            foreach (Pool p in _pools)
            {
                if (p.ID >= i) i = p.ID;
            }

            return i + 1;
        }

        internal bool RemovePool(int id)
        {
            return _pools.Remove(GetByID(id));
        }

        internal bool Update(Pool p)
        {
            Pool poolToUpdate = _pools.Where(x => x.ID == p?.ID).FirstOrDefault();
            if (poolToUpdate != null)
            {
                int index = _pools.IndexOf(poolToUpdate);
                _pools[index] = p;
                return p == _pools.Where(x => x.ID == p.ID).FirstOrDefault();
            }
            return false;
        }

        internal bool Validate(Pool p) => p != null && p.ID > 0 && !_pools.Any(x => x.ID == p.ID);

        internal string Pull(int id)
        {
            string retval = string.Empty;
            Pool parent = GetByID(id);
            if (parent != null)
            {
                List<string> full = new List<string>();
                full.AddRange(parent.List);
                var children = _pools.Where(c => c.ParentID == parent.ID);
                foreach (Pool p in children)
                {
                    full.AddRange(p.List);
                }
                retval = full.Count > 0 ? full[Engine.RNG.Next(0, full.Count)] : $"!!EMPTY POOL {parent}";
            }
            return retval;
        }
    }
}