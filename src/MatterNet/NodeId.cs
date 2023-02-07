namespace MatterNet
{
    /// <summary>
    /// A Node Identifier (Node ID) is a 64-bit number that uniquely identifies an individual Node or a group of Nodes on a Fabric.
    /// </summary>
    public class NodeId
    {
        public NodeId(ulong id)
        {
            Id = id;
        }
        public ulong Id { get; }
    }
}
