namespace MatterNet.Clusters
{
    /// <summary>
    /// Clusters are the functional building block elements of the data model. A cluster specification
    /// defines both a client and server side that correspond with each other through interactions.A cluster
    /// may be considered an interface, service, or object class and is the lowest independent functional
    /// element in the data model.Each cluster is defined by a cluster specification that defines elements of
    /// a cluster including attributes, events, commands, as well as behavior associated with interactions
    /// with these elements.Cluster attributes, events, commands and behaviors are mandatory or
    /// optional depending on the definition of the cluster.
    /// Optional items may have dependencies.
    /// </summary>
    public abstract class Cluster
    {
        protected Cluster(ushort id, string name, int revision, Dictionary<string, byte>? features = null, Dictionary<string, Attribute>? attributes = null,
            Dictionary<string, Command>? commands = null, Dictionary<string, Event>? events = null)
        {
            Id = id;
            Name = name;
            Attributes = attributes ?? new Dictionary<string, Attribute>();
            Commands = commands ?? new Dictionary<string, Command>();
            Events = events ?? new Dictionary<string, Event>();
            Features = features ?? new Dictionary<string, byte>();
        }

        public ushort Id { get; }

        public string Name { get; }

        public IDictionary<string, Attribute> Attributes { get; }

        public IDictionary<string, Command> Commands { get; }

        public IDictionary<string, Event> Events { get; }
        
        public IDictionary<string, byte> Features { get; }
        
        public void SendCommand(string name)
        {
            if (!Commands.ContainsKey(name))
                throw new ArgumentException($"Command {name} not found");
            // TODO
            throw new NotImplementedException();
        }
    }
    public class Attribute
    {
        public Attribute(int id, Type type, Dictionary<string, object> values)
        {
        }
    }
    public class Command
    {
        public Command(int requestId, object[]? requestArguments, int responseId, object[]? responseArguments)
        {
        }
    }
    public class Event
    {
    }
}