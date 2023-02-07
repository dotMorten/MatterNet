namespace MatterNet
{
    /// <summary>
    /// A Endpoint Number is a 16-bit number that that indicates an instance of a device type.
    /// </summary>
    // MatterCoreSpecificationV1_0} § 7.18.2.11
    public class EndpointNumber
    {
        public EndpointNumber(ushort id)
        {
            Id = id;
        }
        public ushort Id { get; }
    }
}
