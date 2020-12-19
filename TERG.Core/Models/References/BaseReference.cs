using TERG.Core.Interfaces;

namespace TERG.Core.Models.References
{
    public abstract class BaseReference : IReference
    {
        public string Name { get; set; }

        public virtual string Type { get; }

        public abstract string Pull(Engine e);

        public override string ToString()
        {
            return $"{Type} {Name}";
        }
    }
}