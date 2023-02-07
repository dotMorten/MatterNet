namespace MatterNet
{
    /// <summary>
    ///  An Attribute ID is a 32 bit number and indicates an attribute defined in a cluster specification.
    /// </summary>
    // MatterCoreSpecificationV1_0} § 7.18.2.15
    public class AttributeId
    {
        public AttributeId(uint id)
        {
            Id = id;
        }
        public uint Id { get; }
    }
}
