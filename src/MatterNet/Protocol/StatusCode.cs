namespace MatterNet.Protocol;
// matter code spec 8.10

/// <summary>
/// Global status codes for the Interaction Model. These MAY be used by interaction
/// model processing of actions and as common status codes for cluster specifications.
/// All values not defined here SHALL be reserved(per general conventions). Cluster
/// specifications that wish to communicate a status not defined in this table MAY
/// use a cluster-specific status code as described in
/// /// </summary>
public enum StatusCode : byte
{
    /// <summary>
    /// Operation was successful
    /// </summary>
    Success = 0x00,
    /// <summary>
    /// Operation was not successful.
    /// </summary>
    Failure = 0x01,
    /// <summary>
    /// Subscription ID is not active.
    /// </summary>
    InvalidSubscription = 0x7d,
    /// <summary>
    /// The sender of the action or command does not have authorization or access.
    /// </summary>
    UnsupportedAccess = 0x7e,
    /// <summary>
    /// The endpoint indicated is unsupported on the node.
    /// </summary>
    UnsupportedEndpoint = 0x7f,
    /// <summary>
    /// The action is malformed, has missing fields, or fields with invalid values. Action not carried out.
    /// </summary>
    InvalidAction = 0x80,
    /// <summary>
    /// The indicated command ID is not supported on the cluster instance. Command not carried out.
    /// </summary>
    UnsupportedCommand = 0x81,
    /// <summary>
    /// The cluster command is malformed, has missing fields, or fields with invalid values. Command not carried out.
    /// </summary>
    InvalidCommand = 0x85,
    /// <summary>
    /// The indicated attribute ID, field ID or list entry does not exist for an attribute pat
    /// </summary>
    UnsupportedAttribute = 0x86,
    /// <summary>
    /// Out of range error or set to a reserved value. Attribute keeps its old value. Note that an attribute value may be out of 
    /// range if an attribute is related to another, e.g. with minimum and maximum attributes. See the individual attribute
    /// descriptions for specific details.
    /// </summary>
    ConstraintError = 0x87,
    /// <summary>
    /// Attempt to write a read-only attribute.
    /// </summary>
    UnsupportedWrite = 0x88,
    /// <summary>
    /// An action or operation failed due to insufficient available resources.
    /// </summary>
    ResourceExhausted = 0x89,
    /// <summary>
    /// The indicated data field or entry could not be found.
    /// </summary>
    NotFound = 0x8b,
    /// <summary>
    /// Reports cannot be issued for this attribute.
    /// </summary>
    UnreportableAttribute = 0x8c,
    /// <summary>
    /// The data type indicated is undefined or invalid for the indicated data field. Command or action not carried out.
    /// </summary>
    InvalidDataType = 0x8d,
    /// <summary>
    /// Attempt to read a write-only attribute.
    /// </summary>
    UnsupportedRead = 0x8f,
    /// <summary>
    /// Cluster instance data version did not match request path
    /// </summary>
    DataVersionMismatch = 0x92,
    /// <summary>
    /// The transaction was aborted due to time being exceeded.
    /// </summary>
    Timeout = 0x94,
    /// <summary>
    /// The node ID indicated is not supported on the node.
    /// </summary>
    UnsupportedMode = 0x9b,
    /// <summary>
    /// The receiver is busy processing another action that prevents the execution of the incoming action.
    /// </summary>
    Busy = 0x9c,
    /// <summary>
    /// The cluster indicated is not supported on the endpoint.
    /// </summary>
    UnsupportedCluster = 0xc3,
    /// <summary>
    /// Used by proxies to convey to clients the lack of an upstream subscription to a source.
    /// </summary>
    NoUpstreamSubscription = 0xc5,
    /// <summary>
    /// A Untimed Write or Untimed Invoke interaction was used for an attribute or command that requires a Timed Write or Timed Invoke.
    /// </summary>
    NeedsTimedInteraction = 0xc6,
    /// <summary>
    /// The indicated event ID is not supported on the cluster instance.
    /// </summary>
    UnsupportedEvent = 0xc7,
    /// <summary>
    /// The receiver has insufficient resources to support the specified number of paths in the request
    /// </summary>
    PathsExhausted = 0xc8,
    /// <summary>
    /// A request with TimedRequest field set to <c>true</c> was issued outside a Timed transaction or a request with TimedRequest set to <c>false</c> was issued inside a Timed transaction
    /// </summary>
    TimedRequestMismatch = 0xc9,
    /// <summary>
    /// A request requiring a Fail-safe context was invoked without the Fail-Safe context
    /// </summary>
    FailsafeRequired = 0xca,
}