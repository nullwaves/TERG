namespace TERG.Core.Interfaces
{
    public interface IReference
    {
        string Type
        {
            get;
        }

        string Name
        {
            get; set;
        }

        string Pull(Engine e);
    }
}