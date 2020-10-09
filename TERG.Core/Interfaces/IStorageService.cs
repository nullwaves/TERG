using TERG.Core.Models;

namespace TERG.Core.Interfaces
{
    internal interface IStorageService
    {
        internal bool Save(Pool[] pools, Pattern[] patterns, string filePath);

        internal (Pool[], Pattern[]) Load(string filePath);
    }
}