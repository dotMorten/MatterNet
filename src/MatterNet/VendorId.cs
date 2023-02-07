namespace MatterNet
{
    /// <summary>
    /// A Vendor Identifier (Vendor ID or VID) is a 16-bit number that uniquely identifies a particular
    /// product manufacturer,  vendor, or group thereof.Each Vendor ID is statically allocated by the
    /// Connectivity Standards Alliance.
    /// </summary>
    public class VendorId
    {
        public VendorId(ushort id)
        {
            Id = id;
        }
        public ushort Id { get; }
    }
}
