namespace TERG.Core.Interfaces
{
    // find a way to add global variables for reference types.
    public interface IReference
    {
        string Type
        {
            get;
        }

        string Pull(Engine e);
    }
}