namespace MatterNet
{
    /// <summary>
    /// Each fabric supported on a node is referenced by fabric-index that is unique on the node.This
    /// fabric-index enables the look-up of the full fabric information from the fabric-index.A fabric-index
    /// of 0 (zero) or null SHALL indicate that there is no fabric associated with the context in which the
    /// fabric-index is being used. If fabric-index is used in a context that is exclusively associated with
    /// a fabric, such as fabric-scoped data model elements, then the fabric-index values SHALL NOT include 0
    /// (zero) or null.
    /// </summary>
    // @see { @link MatterCoreSpecificationV1_0} § 7.5.2
    public class FabricIndex
    {
        public FabricIndex(byte id)
        {
            Id = id;
        }
        public byte Id { get; }
    }
}
