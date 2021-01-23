using Tubumu.Core.Extensions;

namespace Tubumu.Mediasoup
{
    /// <summary>
    /// Transport protocol.
    /// </summary>
    public enum TransportProtocol
    {
        [EnumStringValue("udp")]
        UDP,

        [EnumStringValue("tcp")]
        TCP
    }
}
