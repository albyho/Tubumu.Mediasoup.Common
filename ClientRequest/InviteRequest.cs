using System.Collections.Generic;

namespace Tubumu.Mediasoup
{
    public class InviteRequest
    {
        public string ProducerPeerId { get; set; }

        public HashSet<string> Sources { get; set; }
    }

    public class DeinviteRequest
    {
        public string ProducerPeerId { get; set; }

        public HashSet<string> Sources { get; set; }
    }
}
