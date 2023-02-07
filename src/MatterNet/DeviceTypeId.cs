namespace MatterNet
{
    /// <summary>
    ///   Device type ID is a 32-bit number that defines the type of the device.
    /// </summary>
    // MatterCoreSpecificationV1_0} § 7.15
    public class DeviceTypeId
    {
        public DeviceTypeId(uint id)
        {
            Id = id;
        }
        public uint Id { get; }
    }
}
