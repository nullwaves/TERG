using System.Collections.Generic;
using System.Linq;
using TERG.Core.Models;

namespace TERG.Core.Managers
{
    internal class PatternManager
    {
        internal readonly List<Pattern> _patterns;

        internal PatternManager()
        {
            _patterns = new List<Pattern>();
        }

        internal PatternManager(IEnumerable<Pattern> patterns)
        {
            _patterns = patterns.ToList();
        }

        internal Pattern Add(Pattern p)
        {
            p.ID = GetNextID();
            if (Validate(p))
            {
                _patterns.Add(p);
                return p;
            }
            return new Pattern();
        }

        internal IEnumerable<Pattern> GetAll()
        {
            return _patterns;
        }

        internal Pattern GetByID(int id)
        {
            return _patterns.Where(x => id == x.ID).FirstOrDefault();
        }

        private int GetNextID()
        {
            int i = 0;
            foreach (Pattern p in _patterns)
            {
                if (p.ID >= i) i = p.ID;
            }

            return i + 1;
        }

        internal bool RemovePattern(int id)
        {
            return _patterns.Remove(GetByID(id));
        }

        internal bool Update(Pattern p)
        {
            Pattern patternToUpdate = _patterns.Where(x => x.ID == p?.ID).FirstOrDefault();
            if (patternToUpdate != null)
            {
                int index = _patterns.IndexOf(patternToUpdate);
                _patterns[index] = p;
                return p == _patterns.Where(x => x.ID == p.ID).FirstOrDefault();
            }
            return false;
        }

        internal bool Validate(Pattern p) => p != null && p.ID > 0 && !_patterns.Any(x => x.ID == p.ID);
    }
}