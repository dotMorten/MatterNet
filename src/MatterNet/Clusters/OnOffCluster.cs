namespace MatterNet.Clusters
{
    /// <summary>
    /// Attributes and commands for turning devices on and off
    /// </summary>
    public class OnOffCluster : Cluster
    {
        public OnOffCluster() : base(0x06, "On/Off", 4,
            features: new() { { "lightingLevelControl", 0x00 } },
            attributes: new() { { "onOff", new Attribute(0, typeof(bool), new() { { "default", false } }) } },
            commands: new() {
                {  "on", new Command(0, null, 0, null) },
                {  "off", new Command(1, null, 1, null) },
                { "toggle", new Command(2, null, 2, null) }
            })
        {
        }

        public void SendOnCommand() => base.SendCommand("on");

        public void SendOffCommand() => base.SendCommand("off");

        public void SendToggleCommand() => base.SendCommand("toggle");
    }
}