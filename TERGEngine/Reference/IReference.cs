namespace TERGEngine.Reference
{
    // find a way to add global variables for reference types.
    public interface IReference
    {
        string Type
        {
            get;
        }
        string Pull(Engine e);
        string ToString(Engine e);
    }
}
