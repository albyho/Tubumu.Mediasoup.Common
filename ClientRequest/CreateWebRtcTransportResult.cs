using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Tubumu.Mediasoup
{
    public class CreateWebRtcTransportResult
    {
        public string TransportId { get; set; }

        public IceParameters IceParameters { get; set; }

        public ReadOnlyCollection<IceCandidate> IceCandidates { get; set; }

        public DtlsParameters DtlsParameters { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SctpParameters? SctpParameters { get; set; }
    }
}
