namespace MatterNet
{
    /// <summary>
    ///  Fabric ID is a 64-bit number that uniquely identifies the Fabric within the scope of a particular root CA.
    /// </summary>
    public class FabricId
    {
        public FabricId(ulong id)
        {
            Id = id;
        }
        public ulong Id { get; }
    }
}
