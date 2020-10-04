using System.Collections.Generic;
using System.Linq;
using TERG.Core.Models;

namespace TERG.Core.Managers
{
    internal class PatternManager
    {
        private List<Pattern> _patterns;

        internal PatternManager()
        {
            _patterns = new List<Pattern>();
        }

        internal IEnumerable<Pattern> GetAll()
        {
            return _patterns;
        }

        public Pattern GetByID(int id)
        {
            return _patterns.Where(x => id == x.ID).FirstOrDefault();
        }

        internal int GetNextID()
        {
            int i = 0;
            foreach (Pattern p in _patterns)
            {
                if (p.ID >= i) i = p.ID;
            }

            return i + 1;
        }
    }
}