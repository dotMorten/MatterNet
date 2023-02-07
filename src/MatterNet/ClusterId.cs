namespace MatterNet
{
    /// <summary>
    ///  A Cluster Identifier is a 32 bit number and SHALL reference a single cluster specification and
    ///  SHALL define conformance to that specification.
    /// </summary>
    // MatterCoreSpecificationV1_0} § 7.10
    public class ClusterId
    {
        public ClusterId(uint id)
        {
            Id = id;
        }
        public uint Id { get; }
    }
}
