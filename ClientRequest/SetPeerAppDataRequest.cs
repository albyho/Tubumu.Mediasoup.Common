using System.Collections.Generic;

namespace Tubumu.Mediasoup
{
    public class SetPeerAppDataRequest
    {
        public Dictionary<string, object> PeerAppData { get; set; }
    }

    public class UnsetPeerAppDataRequest
    {
        public string[] Keys { get; set; }
    }

    public class SetPeerControlDataRequest
    {
        public string PeerId { get; set; }

        public Dictionary<string, object> PeerControlData { get; set; }
    }

    public class UnsetPeerControlDataRequest
    {
        public string PeerId { get; set; }

        public string[] Keys { get; set; }
    }
}
