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
    }
}